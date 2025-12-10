using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;

namespace AutoPecas.Models
{
    public class AgendamentoCalendario
    {
        public int AtendimentoID { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataPrestacao { get; set; }
        public DateTime? PrevisaoConclusao { get; set; }
        public string NomeCliente { get; set; }
        public string PlacaVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string MarcaVeiculo { get; set; }
        public decimal ValorSugerido { get; set; }
        public decimal ValorPraticado { get; set; }
        public decimal LucroBruto { get; set; }
        public string Observacoes { get; set; }
        public List<ServicoAgendamento> Servicos { get; set; } = new List<ServicoAgendamento>();
    }

    public class ServicoAgendamento
    {
        public int ServicoID { get; set; }
        public string NomeServico { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }

    public class EventoCalendario
    {
        public DateTime Data { get; set; }
        public int QuantidadeAgendamentos { get; set; }
        public List<AgendamentoCalendario> Agendamentos { get; set; } = new List<AgendamentoCalendario>();
        public string DescricaoResumida { get; set; }
    }

    public enum TipoVisualizacaoCalendario
    {
        Mensal,
        Semanal
    }

    /// <summary>
    /// Serviço para operações de dados do calendário
    /// </summary>
    public static class CalendarioService
    {
        /// <summary>
        /// Obtém todos os agendamentos para um período específico
        /// </summary>
        public static List<AgendamentoCalendario> ObterAgendamentosPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            var agendamentos = new List<AgendamentoCalendario>();

            try
            {
                using (var connection = BancoSQLite.GetConnection())
                {
                    string query = @"
                        SELECT 
                            a.AtendimentoID,
                            a.Data,
                            a.DataPrestacao,
                            a.PrevisaoConclusao,
                            c.NomeCliente,
                            v.Placa,
                            v.Modelo,
                            v.Marca,
                            a.ValorSugerido,
                            a.ValorPraticado,
                            a.LucroBruto,
                            a.Observacoes
                        FROM Atendimentos a
                        INNER JOIN Clientes c ON c.ClienteID = a.ClienteID
                        INNER JOIN Veiculos v ON v.VeiculoID = a.VeiculoID
                        WHERE a.DataPrestacao >= @dataInicio AND a.DataPrestacao <= @dataFim
                        ORDER BY a.DataPrestacao, a.Data";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dataInicio", dataInicio.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@dataFim", dataFim.ToString("yyyy-MM-dd"));

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var agendamento = new AgendamentoCalendario
                                {
                                    AtendimentoID = reader.GetInt32("AtendimentoID"),
                                    Data = reader.GetDateTime("Data"),
                                    DataPrestacao = reader.GetDateTime("DataPrestacao"),
                                    PrevisaoConclusao = reader.IsDBNull("PrevisaoConclusao") ? 
                                        (DateTime?)null : reader.GetDateTime("PrevisaoConclusao"),
                                    NomeCliente = reader.GetString("NomeCliente"),
                                    PlacaVeiculo = reader.GetString("Placa"),
                                    ModeloVeiculo = reader.GetString("Modelo"),
                                    MarcaVeiculo = reader.GetString("Marca"),
                                    ValorSugerido = reader.GetDecimal("ValorSugerido"),
                                    ValorPraticado = reader.GetDecimal("ValorPraticado"),
                                    LucroBruto = reader.GetDecimal("LucroBruto"),
                                    Observacoes = reader.IsDBNull("Observacoes") ? "" : reader.GetString("Observacoes")
                                };

                                // Carregar serviços do agendamento
                                agendamento.Servicos = ObterServicosPorAtendimento(agendamento.AtendimentoID);
                                agendamentos.Add(agendamento);
                            }
                        }
                    }
                }
            }
                         catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show($"Erro ao carregar agendamentos: {ex.Message}");
             }

            return agendamentos;
        }

        /// <summary>
        /// Obtém agendamentos para uma data específica
        /// </summary>
        public static List<AgendamentoCalendario> ObterAgendamentosPorData(DateTime data)
        {
            return ObterAgendamentosPorPeriodo(data.Date, data.Date);
        }

        /// <summary>
        /// Obtém os serviços de um atendimento específico
        /// </summary>
        private static List<ServicoAgendamento> ObterServicosPorAtendimento(int atendimentoId)
        {
            var servicos = new List<ServicoAgendamento>();

            try
            {
                using (var connection = BancoSQLite.GetConnection())
                {
                    string query = @"
                        SELECT 
                            s.ServicoID,
                            s.NomeServico,
                            ats.Quantidade,
                            ats.ValorUnitario
                        FROM AtendimentoServicos ats
                        INNER JOIN Servicos s ON s.ServicoID = ats.ServicoID
                        WHERE ats.AtendimentoID = @atendimentoId";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@atendimentoId", atendimentoId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                servicos.Add(new ServicoAgendamento
                                {
                                    ServicoID = reader.GetInt32("ServicoID"),
                                    NomeServico = reader.GetString("NomeServico"),
                                    Quantidade = reader.GetDecimal("Quantidade"),
                                    ValorUnitario = reader.GetDecimal("ValorUnitario")
                                });
                            }
                        }
                    }
                }
            }
                         catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show($"Erro ao carregar serviços: {ex.Message}");
             }

            return servicos;
        }

        /// <summary>
        /// Obtém eventos agrupados por data para um período
        /// </summary>
        public static Dictionary<DateTime, EventoCalendario> ObterEventosPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            var eventos = new Dictionary<DateTime, EventoCalendario>();
            var agendamentos = ObterAgendamentosPorPeriodo(dataInicio, dataFim);

            foreach (var agendamento in agendamentos)
            {
                var dataKey = agendamento.DataPrestacao.Date;

                if (!eventos.ContainsKey(dataKey))
                {
                    eventos[dataKey] = new EventoCalendario
                    {
                        Data = dataKey,
                        QuantidadeAgendamentos = 0,
                        Agendamentos = new List<AgendamentoCalendario>(),
                        DescricaoResumida = ""
                    };
                }

                eventos[dataKey].Agendamentos.Add(agendamento);
                eventos[dataKey].QuantidadeAgendamentos++;
                
                // Criar descrição resumida
                if (eventos[dataKey].QuantidadeAgendamentos == 1)
                {
                    eventos[dataKey].DescricaoResumida = agendamento.NomeCliente;
                }
                else if (eventos[dataKey].QuantidadeAgendamentos == 2)
                {
                    eventos[dataKey].DescricaoResumida += $", {agendamento.NomeCliente}";
                }
                else if (eventos[dataKey].QuantidadeAgendamentos > 2)
                {
                    eventos[dataKey].DescricaoResumida = $"{eventos[dataKey].Agendamentos[0].NomeCliente} e mais {eventos[dataKey].QuantidadeAgendamentos - 1}";
                }
            }

            return eventos;
        }
    }
}
