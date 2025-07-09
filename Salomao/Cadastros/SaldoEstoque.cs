using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Salomao.Cadastros
{
    public partial class SaldoEstoque : UserControl
    {
        public SaldoEstoque()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.PersonalizarSaldoEstoque(dataGridView1);
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT P.ProdutoID, P.NomeProduto, E.QuantidadeAtual
                                 FROM Produtos P
                                 LEFT JOIN EstoqueAtual E ON E.ProdutoID = P.ProdutoID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
} 