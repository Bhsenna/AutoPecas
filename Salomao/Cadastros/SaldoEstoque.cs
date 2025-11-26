using System;
using System.Data;
using System.Windows.Forms;

namespace Salomao.Cadastros
{
    public partial class SaldoEstoque : UserControl
    {
        public SaldoEstoque()
        {
            InitializeComponent();
            
            // Background moderno
            this.BackColor = Styler.ModernColors.Background;
            this.Padding = new Padding(Styler.Spacing.MD);
            
            CarregarTabela();
            
            // Grid moderno com destaque para estoque baixo
            Styler.EnhancedGridStyler.ApplyModernStyle(dataGridView1);
            Styler.GridStyler.PersonalizarSaldoEstoque(dataGridView1, 5.0);
        }

        private void CarregarTabela()
        {
            try
            {
                dataGridView1.DataSource = EstoqueManager.ObterSaldosEstoque();
                
                // Aplicar formatação específica
                if (dataGridView1.Columns.Contains("QuantidadeAtual"))
                {
                    var colQtd = dataGridView1.Columns["QuantidadeAtual"];
                    colQtd.DefaultCellStyle.Font = Styler.ModernFonts.PrimaryBold;
                    colQtd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                
                if (dataGridView1.Columns.Contains("CustoAquisicao"))
                {
                    var colCusto = dataGridView1.Columns["CustoAquisicao"];
                    colCusto.DefaultCellStyle.Format = "C2";
                    colCusto.DefaultCellStyle.ForeColor = Styler.ModernColors.Success;
                    colCusto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar saldos de estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                saveDialog.FileName = $"SaldoEstoque_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportarParaCSV(saveDialog.FileName);
                    MessageBox.Show("Arquivo exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarParaCSV(string fileName)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName, false, System.Text.Encoding.UTF8))
            {
                // Cabeçalho
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName);
                    if (i < dt.Columns.Count - 1)
                        sw.Write(";");
                }
                sw.WriteLine();

                // Dados
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sw.Write(row[i]?.ToString() ?? "");
                        if (i < dt.Columns.Count - 1)
                            sw.Write(";");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
} 