using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FontAwesome.Sharp;

namespace Salomao.Dashboard
{
    /// <summary>
    /// Dashboard moderno para sistema AutoPeças
    /// </summary>
    public partial class DashboardControl : UserControl
    {
        #region Paleta de Cores

        private readonly Color AzulPrimario = Color.FromArgb(74, 144, 226);
        private readonly Color AzulEscuro = Color.FromArgb(46, 92, 138);
        private readonly Color Verde = Color.FromArgb(39, 174, 96);
        private readonly Color Laranja = Color.FromArgb(243, 156, 18);
        private readonly Color Roxo = Color.FromArgb(155, 89, 182);
        private readonly Color Vermelho = Color.FromArgb(231, 76, 60);
        private readonly Color Fundo = Color.FromArgb(245, 247, 250);
        private readonly Color CinzaTexto = Color.FromArgb(127, 140, 154);
        private readonly Color TextoEscuro = Color.FromArgb(44, 62, 80);

        #endregion

        private System.Windows.Forms.Timer refreshTimer;

        public DashboardControl()
        {
            InitializeComponent();
            AplicarEstilizacao();
            ConfigurarGraficos();
            ConfigurarRefreshAutomatico();
            CarregarDados();
        }

        private void AplicarEstilizacao()
        {
            // Background geral
            this.BackColor = Fundo;
            tableLayoutPanel1.BackColor = Fundo;
            panelCards.BackColor = Fundo;
            tableLayoutPanel2.BackColor = Fundo;
            tableLayoutPanel3.BackColor = Fundo;

            // Estilizar cards
            EstilizarCard(cardFaturamento, lblFaturamentoMes, AzulPrimario);
            EstilizarCard(cardLucro, lblLucroMes, Verde);
            EstilizarCard(cardAtendimentos, lblAtendimentosMes, Laranja);
            EstilizarCard(cardClientes, lblClientesAtivos, Roxo);

            // Estilizar painéis de gráficos
            EstilizarPainelGrafico(panelGraficoFaturamento);
            EstilizarPainelGrafico(panelGraficoServicos);
            EstilizarPainelGrafico(panelEstoque);
            EstilizarPainelGrafico(panelAgendamentos);

            // Estilizar DataGridView
            EstilizarDataGridView();
        }

        private void EstilizarCard(Panel card, Label lblValor, Color cor)
        {
            card.BackColor = Color.White;
            lblValor.ForeColor = cor;
        }

        private void EstilizarPainelGrafico(Panel panel)
        {
            panel.BackColor = Color.White;
            
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is Label lbl && lbl.Font.Bold)
                {
                    lbl.ForeColor = AzulEscuro;
                }
            }
        }

        private void EstilizarDataGridView()
        {
            dgvAgendamentos.BackgroundColor = Color.White;
            dgvAgendamentos.GridColor = Color.FromArgb(224, 230, 237);
            
            dgvAgendamentos.ColumnHeadersDefaultCellStyle.BackColor = AzulPrimario;
            dgvAgendamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAgendamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAgendamentos.ColumnHeadersDefaultCellStyle.SelectionBackColor = AzulPrimario;
            dgvAgendamentos.EnableHeadersVisualStyles = false;

            dgvAgendamentos.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvAgendamentos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 242, 252);
            dgvAgendamentos.DefaultCellStyle.SelectionForeColor = TextoEscuro;
            dgvAgendamentos.AlternatingRowsDefaultCellStyle.BackColor = Fundo;
        }

        private void ConfigurarGraficos()
        {
            ConfigurarGraficoFaturamento();
            ConfigurarGraficoServicos();
            ConfigurarGraficoEstoque();
        }

        private void ConfigurarGraficoFaturamento()
        {
            chartFaturamento.Series.Clear();
            chartFaturamento.ChartAreas.Clear();
            chartFaturamento.Legends.Clear();

            var chartArea = new ChartArea("MainArea");
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Format = "C0";
            chartArea.AxisX.LineColor = Color.FromArgb(200, 200, 200);
            chartArea.AxisY.LineColor = Color.FromArgb(200, 200, 200);
            chartFaturamento.ChartAreas.Add(chartArea);

            var seriesFaturamento = new Series("Faturamento");
            seriesFaturamento.ChartType = SeriesChartType.Column;
            seriesFaturamento.Color = AzulPrimario;
            seriesFaturamento.BorderWidth = 0;

            var seriesLucro = new Series("Lucro");
            seriesLucro.ChartType = SeriesChartType.Column;
            seriesLucro.Color = Verde;
            seriesLucro.BorderWidth = 0;

            chartFaturamento.Series.Add(seriesFaturamento);
            chartFaturamento.Series.Add(seriesLucro);

            var legend = new Legend("Legend");
            legend.Font = new Font("Segoe UI", 9F);
            legend.Docking = Docking.Top;
            legend.BackColor = Color.Transparent;
            legend.BorderColor = Color.Transparent;
            chartFaturamento.Legends.Add(legend);

            chartFaturamento.BackColor = Color.White;
            chartFaturamento.BorderlineColor = Color.Transparent;
        }

        private void ConfigurarGraficoServicos()
        {
            chartServicos.Series.Clear();
            chartServicos.ChartAreas.Clear();
            chartServicos.Legends.Clear();

            var chartArea = new ChartArea("MainArea");
            chartArea.BackColor = Color.White;
            chartServicos.ChartAreas.Add(chartArea);

            var series = new Series("Servicos");
            series.ChartType = SeriesChartType.Doughnut;
            series.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
            series["DoughnutRadius"] = "60";

            chartServicos.Series.Add(series);

            var legend = new Legend("Legend");
            legend.Font = new Font("Segoe UI", 9F);
            legend.Docking = Docking.Right;
            legend.BackColor = Color.Transparent;
            legend.BorderColor = Color.Transparent;
            chartServicos.Legends.Add(legend);

            chartServicos.BackColor = Color.White;
            chartServicos.BorderlineColor = Color.Transparent;
        }

        private void ConfigurarGraficoEstoque()
        {
            chartEstoque.Series.Clear();
            chartEstoque.ChartAreas.Clear();

            var chartArea = new ChartArea("MainArea");
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LineColor = Color.FromArgb(200, 200, 200);
            chartArea.AxisY.LineColor = Color.FromArgb(200, 200, 200);
            chartEstoque.ChartAreas.Add(chartArea);

            var series = new Series("Estoque");
            series.ChartType = SeriesChartType.Bar;
            series.Color = Verde;

            chartEstoque.Series.Add(series);
            chartEstoque.BackColor = Color.White;
            chartEstoque.BorderlineColor = Color.Transparent;
        }

        private void ConfigurarRefreshAutomatico()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 300000; // 5 minutos
            refreshTimer.Tick += (s, e) => CarregarDados();
            refreshTimer.Start();
        }

        private void CarregarDados()
        {
            try
            {
                AtualizarCards();
                AtualizarGraficoFaturamento();
                AtualizarGraficoServicos();
                AtualizarGraficoEstoque();
                AtualizarAgendamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarCards()
        {
            try
            {
                using (var connection = BancoSQLite.GetConnection())
                {
                    // DEBUG: Primeiro vamos verificar SE HÁ DADOS na tabela
                    string queryDebugTotal = "SELECT COUNT(*) FROM Atendimentos";
                    using (var cmdDebug = new SQLiteCommand(queryDebugTotal, connection))
                    {
                        int totalAtendimentos = Convert.ToInt32(cmdDebug.ExecuteScalar());
                        System.Diagnostics.Debug.WriteLine($"=== DIAGNÓSTICO DASHBOARD ===");
                        System.Diagnostics.Debug.WriteLine($"Total de atendimentos no banco: {totalAtendimentos}");
                    }

                    // DEBUG: Verificar datas dos atendimentos
                    string queryDebugDatas = @"
                        SELECT 
                            MIN(DataPrestacao) as MenorData,
                            MAX(DataPrestacao) as MaiorData,
                            date('now') as DataHoje,
                            date('now', '-30 days') as Data30DiasAtras
                        FROM Atendimentos";
                    
                    using (var cmdDebug = new SQLiteCommand(queryDebugDatas, connection))
                    using (var reader = cmdDebug.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            System.Diagnostics.Debug.WriteLine($"Menor data: {reader.GetString(0)}");
                            System.Diagnostics.Debug.WriteLine($"Maior data: {reader.GetString(1)}");
                            System.Diagnostics.Debug.WriteLine($"Hoje: {reader.GetString(2)}");
                            System.Diagnostics.Debug.WriteLine($"30 dias atrás: {reader.GetString(3)}");
                        }
                    }

                    // DEBUG: Verificar quantos atendimentos nos últimos 30 dias
                    string queryDebug30Dias = @"
                        SELECT 
                            COUNT(*) as Total,
                            SUM(ValorPraticado) as Faturamento,
                            SUM(LucroBruto) as Lucro
                        FROM Atendimentos
                        WHERE DataPrestacao >= date('now', '-30 days')";
                    
                    using (var cmdDebug = new SQLiteCommand(queryDebug30Dias, connection))
                    using (var reader = cmdDebug.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var total = reader.GetInt32(0);
                            var fat = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                            var luc = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                            
                            System.Diagnostics.Debug.WriteLine($"Atendimentos últimos 30 dias: {total}");
                            System.Diagnostics.Debug.WriteLine($"Faturamento últimos 30 dias: R$ {fat:N2}");
                            System.Diagnostics.Debug.WriteLine($"Lucro últimos 30 dias: R$ {luc:N2}");
                        }
                    }

                    // DEBUG: Verificar TODOS os atendimentos com datas
                    string queryDebugTodos = @"
                        SELECT 
                            AtendimentoID,
                            DataPrestacao,
                            ValorPraticado,
                            LucroBruto
                        FROM Atendimentos
                        ORDER BY DataPrestacao DESC
                        LIMIT 10";
                    
                    System.Diagnostics.Debug.WriteLine($"=== ÚLTIMOS 10 ATENDIMENTOS ===");
                    using (var cmdDebug = new SQLiteCommand(queryDebugTodos, connection))
                    using (var reader = cmdDebug.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Diagnostics.Debug.WriteLine(
                                $"ID: {reader.GetInt32(0)} | " +
                                $"Data: {reader.GetString(1)} | " +
                                $"Valor: R$ {reader.GetDecimal(2):N2} | " +
                                $"Lucro: R$ {reader.GetDecimal(3):N2}");
                        }
                    }
                    System.Diagnostics.Debug.WriteLine($"============================");

                    // Faturamento - Últimos 30 dias
                    string queryFaturamento = @"
                        SELECT COALESCE(SUM(ValorPraticado), 0) as Total
                        FROM Atendimentos
                        WHERE DataPrestacao >= date('now', '-30 days')";

                    using (var cmd = new SQLiteCommand(queryFaturamento, connection))
                    {
                        var resultado = cmd.ExecuteScalar();
                        decimal faturamento = resultado != null && resultado != DBNull.Value 
                            ? Convert.ToDecimal(resultado) 
                            : 0;
                        
                        System.Diagnostics.Debug.WriteLine($"Faturamento calculado: R$ {faturamento:N2}");
                        lblFaturamentoMes.Text = faturamento.ToString("C2");
                        lblFaturamentoMes.ForeColor = AzulPrimario;
                    }

                    // Lucro - Últimos 30 dias
                    string queryLucro = @"
                        SELECT COALESCE(SUM(LucroBruto), 0) as Total
                        FROM Atendimentos
                        WHERE DataPrestacao >= date('now', '-30 days')";

                    using (var cmd = new SQLiteCommand(queryLucro, connection))
                    {
                        var resultado = cmd.ExecuteScalar();
                        decimal lucro = resultado != null && resultado != DBNull.Value 
                            ? Convert.ToDecimal(resultado) 
                            : 0;
                        
                        System.Diagnostics.Debug.WriteLine($"Lucro calculado: R$ {lucro:N2}");
                        lblLucroMes.Text = lucro.ToString("C2");
                        lblLucroMes.ForeColor = Verde;
                    }

                    // Atendimentos - Últimos 30 dias
                    string queryAtendimentos = @"
                        SELECT COUNT(*) as Total
                        FROM Atendimentos
                        WHERE DataPrestacao >= date('now', '-30 days')";

                    using (var cmd = new SQLiteCommand(queryAtendimentos, connection))
                    {
                        var resultado = cmd.ExecuteScalar();
                        int atendimentos = resultado != null && resultado != DBNull.Value 
                            ? Convert.ToInt32(resultado) 
                            : 0;
                        
                        System.Diagnostics.Debug.WriteLine($"Atendimentos calculados: {atendimentos}");
                        lblAtendimentosMes.Text = atendimentos.ToString();
                        lblAtendimentosMes.ForeColor = Laranja;
                    }

                    // Clientes Ativos - Últimos 30 dias
                    string queryClientes = @"
                        SELECT COUNT(DISTINCT ClienteID) as Total
                        FROM Atendimentos
                        WHERE DataPrestacao >= date('now', '-30 days')";

                    using (var cmd = new SQLiteCommand(queryClientes, connection))
                    {
                        var resultado = cmd.ExecuteScalar();
                        int clientes = resultado != null && resultado != DBNull.Value 
                            ? Convert.ToInt32(resultado) 
                            : 0;
                        
                        System.Diagnostics.Debug.WriteLine($"Clientes calculados: {clientes}");
                        lblClientesAtivos.Text = clientes.ToString();
                        lblClientesAtivos.ForeColor = Roxo;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ERRO em AtualizarCards: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"StackTrace: {ex.StackTrace}");
                MessageBox.Show($"Erro ao atualizar cards: {ex.Message}\n\n{ex.StackTrace}", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGraficoFaturamento()
        {
            chartFaturamento.Series["Faturamento"].Points.Clear();
            chartFaturamento.Series["Lucro"].Points.Clear();

            using (var connection = BancoSQLite.GetConnection())
            {
                string query = @"
                    SELECT 
                        strftime('%Y-%m', DataPrestacao) as Mes,
                        SUM(ValorPraticado) as Faturamento,
                        SUM(LucroBruto) as Lucro
                    FROM Atendimentos
                    WHERE DataPrestacao >= date('now', '-6 months')
                    GROUP BY strftime('%Y-%m', DataPrestacao)
                    ORDER BY Mes";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string mesAno = reader.GetString(0);
                        DateTime data = DateTime.Parse(mesAno + "-01");
                        string mesFormatado = data.ToString("MMM/yy",
                            System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

                        double faturamento = Convert.ToDouble(reader["Faturamento"]);
                        double lucro = Convert.ToDouble(reader["Lucro"]);

                        chartFaturamento.Series["Faturamento"].Points.AddXY(mesFormatado, faturamento);
                        chartFaturamento.Series["Lucro"].Points.AddXY(mesFormatado, lucro);
                    }
                }
            }
        }

        private void AtualizarGraficoServicos()
        {
            chartServicos.Series["Servicos"].Points.Clear();

            Color[] cores = { AzulPrimario, Verde, Laranja, Roxo, Vermelho };

            using (var connection = BancoSQLite.GetConnection())
            {
                // Últimos 30 dias ao invés de mês atual
                string query = @"
                    SELECT s.NomeServico, COUNT(*) as Quantidade
                    FROM AtendimentoServicos ats
                    INNER JOIN Servicos s ON ats.ServicoID = s.ServicoID
                    INNER JOIN Atendimentos a ON a.AtendimentoID = ats.AtendimentoID
                    WHERE a.DataPrestacao >= date('now', '-30 days')
                    GROUP BY s.ServicoID, s.NomeServico
                    ORDER BY Quantidade DESC
                    LIMIT 5";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    int corIndex = 0;
                    while (reader.Read())
                    {
                        string servico = reader["NomeServico"].ToString();
                        int quantidade = Convert.ToInt32(reader["Quantidade"]);

                        var ponto = chartServicos.Series["Servicos"].Points.AddXY(servico, quantidade);
                        chartServicos.Series["Servicos"].Points[ponto].Color = cores[corIndex % cores.Length];
                        chartServicos.Series["Servicos"].Points[ponto].Label = $"{servico}\n({quantidade})";
                        chartServicos.Series["Servicos"].Points[ponto].LegendText = servico;

                        corIndex++;
                    }
                }
            }

            if (chartServicos.Series["Servicos"].Points.Count == 0)
            {
                chartServicos.Series["Servicos"].Points.AddXY("Sem dados", 1);
                chartServicos.Series["Servicos"].Points[0].Color = Color.LightGray;
            }
        }

        private void AtualizarGraficoEstoque()
        {
            chartEstoque.Series["Estoque"].Points.Clear();

            using (var connection = BancoSQLite.GetConnection())
            {
                string query = @"
                    SELECT 
                        p.NomeProduto,
                        COALESCE(e.QuantidadeAtual, 0) as Quantidade
                    FROM Produtos p
                    LEFT JOIN EstoqueAtual e ON e.ProdutoID = p.ProdutoID
                    ORDER BY Quantidade ASC
                    LIMIT 8";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string produto = reader.GetString(0);
                        if (produto.Length > 20) produto = produto.Substring(0, 17) + "...";

                        decimal quantidade = reader.GetDecimal(1);

                        chartEstoque.Series["Estoque"].Points.AddXY(produto, quantidade);
                        int index = chartEstoque.Series["Estoque"].Points.Count - 1;
                        chartEstoque.Series["Estoque"].Points[index].Color = Verde;
                    }
                }
            }
        }

        private void AtualizarAgendamentos()
        {
            dgvAgendamentos.Rows.Clear();

            using (var connection = BancoSQLite.GetConnection())
            {
                string query = @"
                    SELECT 
                        a.DataPrestacao,
                        c.NomeCliente,
                        v.Placa,
                        v.Modelo,
                        a.ValorPraticado,
                        a.Observacoes
                    FROM Atendimentos a
                    INNER JOIN Clientes c ON a.ClienteID = c.ClienteID
                    INNER JOIN Veiculos v ON a.VeiculoID = v.VeiculoID
                    WHERE a.DataPrestacao >= date('now')
                    ORDER BY a.DataPrestacao
                    LIMIT 5";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime data = reader.GetDateTime(0);
                        string cliente = reader.GetString(1);
                        string placa = reader.GetString(2);
                        string modelo = reader.GetString(3);
                        decimal valor = reader.GetDecimal(4);
                        string obs = reader.IsDBNull(5) ? "" : reader.GetString(5);

                        dgvAgendamentos.Rows.Add(
                            data.ToString("dd/MM/yyyy"),
                            cliente,
                            $"{placa} - {modelo}",
                            valor.ToString("C2"),
                            obs.Length > 30 ? obs.Substring(0, 27) + "..." : obs
                        );
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                refreshTimer?.Stop();
                refreshTimer?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
