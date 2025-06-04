using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salomao.Cadastros
{
    public partial class CadProduto : UserControl
    {
        public CadProduto()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = "SELECT * FROM Produtos";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            String sNome           = tbNomeProd      .Text;
            String sCodigo         = tbCodigo        .Text;
            String sFornecedor     = tbFornecedor    .Text;
            String sCategoria      = tbCategoria     .Text;
            String sCustoAquisicao = tbCustoAquisicao.Text;
            String sMarca          = tbMarca         .Text;
            String sDescricao      = tbDescricao     .Text;

            if (sNome == "" || sCodigo == "" || sFornecedor == "" || sCategoria == "" || sCustoAquisicao == "" || sMarca == "" || sDescricao == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Produtos
                                    (NomeProduto, CodigoProduto, CustoAquisicao, Marca, Descricao, CategoriaID, FornecedorID)
                                VALUES
                                    (@NomeProduto,@CodigoProduto,@CustoAquisicao,@Marca,@Descricao, @Categoria, @Fornecedor)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeProduto"   , sNome          );
                    cmd.Parameters.AddWithValue("@CodigoProduto" , sCodigo        );
                    cmd.Parameters.AddWithValue("@CustoAquisicao", sCustoAquisicao);
                    cmd.Parameters.AddWithValue("@Marca"         , sMarca         );
                    cmd.Parameters.AddWithValue("@Descricao"     , sDescricao     );
                    cmd.Parameters.AddWithValue("@Categoria"     , sCategoria     );
                    cmd.Parameters.AddWithValue("@Fornecedor"    , sFornecedor    );

                    try
                    {
                        cmd.ExecuteNonQuery();

                        tbNomeProd      .Clear();
                        tbCodigo        .Clear();
                        tbFornecedor    .Clear();
                        tbCategoria     .Clear();
                        tbCustoAquisicao.Clear();
                        tbMarca         .Clear();
                        tbDescricao     .Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                    }

                    carregaTabela();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNomeProd      .Text = "";
            tbCodigo        .Text = "";
            tbFornecedor    .Text = "";
            tbCategoria     .Text = "";
            tbCustoAquisicao.Text = "";
            tbMarca         .Text = "";
            tbDescricao     .Text = "";
        }
    }
}
