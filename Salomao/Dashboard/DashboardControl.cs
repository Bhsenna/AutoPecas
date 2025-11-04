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
    public partial class DashboardControl : UserControl
    {
        private System.Windows.Forms.Timer refreshTimer;

        public DashboardControl()
        {
            InitializeComponent();
            ConfigurarRefreshAutomatico();
            CarregarDados();
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
                AtualizarProximosAgendamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do dashboard: {ex.Message}", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarCards()
        {
            using (var connection = BancoSQLite.GetConnection())
            {
                // Faturamento do Mês
                string queryFaturamento = @"
                    SELECT COALESCE(SUM(ValorPraticado), 0) as Total
                    FROM Atendimentos
                    WHERE strftime('%Y-%m', DataPrestacao) = strftime('%Y-%m', 'now')";

                using (var cmd = new SQLiteCommand(queryFaturamento, connection))
                {
                    decimal faturamentoMes = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblFaturamentoMes.Text = faturamentoMes.ToString("C2");
                }

                // Lucro do Mês
                string queryLucro = @"
                    SELECT COALESCE(SUM(LucroBruto), 0) as Total
                    FROM Atendimentos
                    WHERE strftime('%Y-%m', DataPrestacao) = strftime('%Y-%m', 'now')";

                using (var cmd = new SQLiteCommand(queryLucro, connection))
                {
                    decimal lucroMes = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblLucroMes.Text = lucroMes.ToString("C2");
                }

                // Atendimentos do Mês
                string queryAtendimentos = @"
                    SELECT COUNT(*) as Total
                    FROM Atendimentos
                    WHERE strftime('%Y-%m', DataPrestacao) = strftime('%Y-%m', 'now')";

                using (var cmd = new SQLiteCommand(queryAtendimentos, connection))
                {
                    int atendimentosMes = Convert.ToInt32(cmd.ExecuteScalar());
                    lblAtendimentosMes.Text = atendimentosMes.ToString();
                }

                // Clientes Ativos
                string queryClientes = @"
                    SELECT COUNT(DISTINCT ClienteID) as Total
                    FROM Atendimentos
                    WHERE strftime('%Y-%m', DataPrestacao) = strftime('%Y-%m', 'now')";

                using (var cmd = new SQLiteCommand(queryClientes, connection))
                {
                    int clientesAtivos = Convert.ToInt32(cmd.ExecuteScalar());
                    lblClientesAtivos.Text = clientesAtivos.ToString();
                }
            }
        }

        private void AtualizarGraficoFaturamento()
        {
            chartFaturamento.Series.Clear();
            chartFaturamento.ChartAreas.Clear();

            var chartArea = new ChartArea("MainArea");
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Format = "C0";
            chartFaturamento.ChartAreas.Add(chartArea);

            var seriesFaturamento = new Series("Faturamento");
            seriesFaturamento.ChartType = SeriesChartType.Column;
            seriesFaturamento.Color = Color.FromArgb(59, 130, 246); // Blue-500
            seriesFaturamento.BorderWidth = 2;

            var seriesLucro = new Series("Lucro");
            seriesLucro.ChartType = SeriesChartType.Column;
            seriesLucro.Color = Color.FromArgb(34, 197, 94); // Green-500
            seriesLucro.BorderWidth = 2;

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
                        string mes = DateTime.Parse(reader.GetString(0) + "-01").ToString("MMM/yy");
                        decimal faturamento = reader.GetDecimal(1);
                        decimal lucro = reader.GetDecimal(2);

                        seriesFaturamento.Points.AddXY(mes, faturamento);
                        seriesLucro.Points.AddXY(mes, lucro);
                    }
                }
            }

            chartFaturamento.Series.Add(seriesFaturamento);
            chartFaturamento.Series.Add(seriesLucro);

            var legend = new Legend("Legend");
            legend.Font = new Font("Segoe UI", 9F);
            legend.Docking = Docking.Top;
            chartFaturamento.Legends.Add(legend);
        }

        private void AtualizarGraficoServicos()
        {
            chartServicos.Series.Clear();
            chartServicos.ChartAreas.Clear();
            chartServicos.Legends.Clear();

            var chartArea = new ChartArea("MainArea");
            chartArea.Area3DStyle.Enable3D = true;
            chartArea.Area3DStyle.Rotation = 10;
            chartArea.Area3DStyle.Inclination = 15;
            chartServicos.ChartAreas.Add(chartArea);

            var series = new Series("Serviços");
            series.ChartType = SeriesChartType.Doughnut;
            series.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";

            Color[] colors = new Color[]
            {
                Color.FromArgb(59, 130, 246),   // Blue
                Color.FromArgb(34, 197, 94),    // Green
                Color.FromArgb(249, 115, 22),   // Orange
                Color.FromArgb(168, 85, 247),   // Purple
                Color.FromArgb(236, 72, 153)    // Pink
            };

            using (var connection = BancoSQLite.GetConnection())
            {
                string query = @"
                    SELECT 
                        s.NomeServico,
                        COUNT(ats.AtendimentoID) as Quantidade
                    FROM AtendimentoServicos ats
                    INNER JOIN Servicos s ON s.ServicoID = ats.ServicoID
                    INNER JOIN Atendimentos a ON a.AtendimentoID = ats.AtendimentoID
                    WHERE strftime('%Y-%m', a.DataPrestacao) = strftime('%Y-%m', 'now')
                    GROUP BY s.NomeServico
                    ORDER BY Quantidade DESC
                    LIMIT 5";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    int colorIndex = 0;
                    while (reader.Read())
                    {
                        string servico = reader.GetString(0);
                        int quantidade = reader.GetInt32(1);

                        var point = series.Points.Add(quantidade);
                        point.Label = $"{servico}\n({quantidade})";
                        point.LegendText = servico;
                        point.Color = colors[colorIndex % colors.Length];
                        colorIndex++;
                    }
                }
            }

            if (series.Points.Count == 0)
            {
                series.Points.Add(1).Label = "Sem dados";
                series.Points[0].Color = Color.LightGray;
            }

            chartServicos.Series.Add(series);

            var legend = new Legend("Legend");
            legend.Font = new Font("Segoe UI", 9F);
            legend.Docking = Docking.Right;
            chartServicos.Legends.Add(legend);
        }

        private void AtualizarGraficoEstoque()
        {
            chartEstoque.Series.Clear();
            chartEstoque.ChartAreas.Clear();

            var chartArea = new ChartArea("MainArea");
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisX.Interval = 1;
            chartEstoque.ChartAreas.Add(chartArea);

            var series = new Series("Estoque");
            series.ChartType = SeriesChartType.Bar;
            series.Color = Color.FromArgb(168, 85, 247); // Purple

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
                        
                        var point = series.Points.AddXY(produto, quantidade);
                        
                        // Colorir diferentes baseado na quantidade
                        if (quantidade < 10)
                            series.Points[series.Points.Count - 1].Color = Color.FromArgb(239, 68, 68); // Red
                        else if (quantidade < 20)
                            series.Points[series.Points.Count - 1].Color = Color.FromArgb(249, 115, 22); // Orange
                        else
                            series.Points[series.Points.Count - 1].Color = Color.FromArgb(34, 197, 94); // Green
                    }
                }
            }

            chartEstoque.Series.Add(series);
        }

        private void AtualizarProximosAgendamentos()
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
                    INNER JOIN Clientes c ON c.ClienteID = a.ClienteID
                    INNER JOIN Veiculos v ON v.VeiculoID = a.VeiculoID
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
                            $"{modelo} ({placa})",
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
