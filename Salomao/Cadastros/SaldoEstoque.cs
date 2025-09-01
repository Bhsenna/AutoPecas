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
            CarregarTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
        }

        private void CarregarTabela()
        {
            try
            {
                dataGridView1.DataSource = EstoqueManager.ObterSaldosEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar saldos de estoque: " + ex.Message);
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
                    MessageBox.Show("Arquivo exportado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar arquivo: " + ex.Message);
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