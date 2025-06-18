using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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

            populaCombo(cbCategoria, "Categorias", "NomeCategoria", "CategoriaID");
            populaCombo(cbFornecedor, "Fornecedores", "NomeFornecedor", "FornecedorID");
        }

        private void populaCombo(ComboBox comboBox, String tabela, String campoNome, String campoId)
        {

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = $"SELECT {campoNome} Nome, cast({campoId} as text) as ID FROM {tabela}";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow emptyRow = dt.NewRow();
                    emptyRow["Nome"] = "";
                    emptyRow["ID"] = "";
                    dt.Rows.Add(emptyRow);

                    DataView dv = new DataView(dt, "", "Nome", DataViewRowState.CurrentRows);

                    comboBox.DataSource = dv;
                    comboBox.DisplayMember = "Nome";
                    comboBox.ValueMember = "ID";
                }
            }
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT NomeProduto as Nome,
                                        CodigoProduto as Código,
                                        CustoAquisicao as Custo,
                                        Status as Status, 
                                        Marca as Marca,
                                        Descricao as Descrição,
                                        NomeCategoria as Categoria,
                                        NomeFornecedor as Fornecedor
                                 FROM Produtos
                                 LEFT JOIN Categorias ON Categorias.CategoriaID = Produtos.CategoriaID
                                 LEFT JOIN Fornecedores ON Fornecedores.FornecedorID = Produtos.FornecedorID";
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
            String sFornecedor     = cbFornecedor    .SelectedValue?.ToString() ?? "";
            String sCategoria      = cbCategoria     .SelectedValue?.ToString() ?? "";
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

                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                    }
                    finally
                    {
                        carregaTabela();
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            tbNomeProd      .Clear();
            tbCodigo        .Clear();
            cbFornecedor    .SelectedValue = "";
            cbCategoria     .SelectedValue = "";
            tbCustoAquisicao.Clear();
            tbMarca         .Clear();
            tbDescricao     .Clear();
        }
    }
}
