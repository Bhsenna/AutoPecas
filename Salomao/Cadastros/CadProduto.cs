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
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = $"SELECT {campoNome} as Nome, {campoId} as ID FROM {tabela} ORDER BY {campoNome}";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        // Define explicitamente os tipos das colunas ANTES de preencher
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("ID", typeof(int));

                        da.Fill(dt);

                        // Adiciona linha vazia no início
                        DataRow emptyRow = dt.NewRow();
                        emptyRow["Nome"] = "Selecione...";
                        emptyRow["ID"] = -1;
                        dt.Rows.InsertAt(emptyRow, 0);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "Nome";
                        comboBox.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados da tabela {tabela}: {ex.Message}\n\nVerifique se a migração do banco foi executada.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Criar DataTable vazio para evitar erros
                DataTable dt = new DataTable();
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("ID", typeof(int));

                DataRow emptyRow = dt.NewRow();
                emptyRow["Nome"] = "Nenhum registro disponível";
                emptyRow["ID"] = -1;
                dt.Rows.Add(emptyRow);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = "Nome";
                comboBox.ValueMember = "ID";
            }
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT Produtos.NomeProduto as Nome,
                                        Produtos.CodigoProduto as Código,
                                        Produtos.CustoAquisicao as Custo,
                                        Produtos.Status as Status, 
                                        Produtos.Marca as Marca,
                                        Produtos.Descricao as Descrição,
                                        Categorias.NomeCategoria as Categoria,
                                        Fornecedores.NomeFornecedor as Fornecedor,
                                        Produtos.ProdutoID as ProdutoID,
                                        Produtos.CategoriaID as CategoriaID,
                                        Produtos.FornecedorID as FornecedorID
                                 FROM Produtos
                                 LEFT JOIN Categorias ON Categorias.CategoriaID = Produtos.CategoriaID
                                 LEFT JOIN Fornecedores ON Fornecedores.FornecedorID = Produtos.FornecedorID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Ocultar colunas de IDs
                    if (dataGridView1.Columns.Contains("ProdutoID"))
                        dataGridView1.Columns["ProdutoID"].Visible = false;
                    if (dataGridView1.Columns.Contains("CategoriaID"))
                        dataGridView1.Columns["CategoriaID"].Visible = false;
                    if (dataGridView1.Columns.Contains("FornecedorID"))
                        dataGridView1.Columns["FornecedorID"].Visible = false;
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
                string query;

                if (produtoSelecionadoId < 0)
                {
                    query = @"INSERT INTO Produtos
                                        (NomeProduto, CodigoProduto, CustoAquisicao, Marca, Descricao, CategoriaID, FornecedorID)
                                    VALUES
                                        (@NomeProduto,@CodigoProduto,@CustoAquisicao,@Marca,@Descricao, @Categoria, @Fornecedor)";
                }
                else
                {
                    query = @"UPDATE Produtos SET
                                        NomeProduto = @NomeProduto,
                                        CodigoProduto = @CodigoProduto,
                                        CustoAquisicao = @CustoAquisicao,
                                        Marca = @Marca,
                                        Descricao = @Descricao,
                                        CategoriaID = @Categoria,
                                        FornecedorID = @Fornecedor
                                  WHERE ProdutoID = @ProdutoId";
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeProduto"   , sNome          );
                    cmd.Parameters.AddWithValue("@CodigoProduto" , sCodigo        );
                    cmd.Parameters.AddWithValue("@CustoAquisicao", sCustoAquisicao);
                    cmd.Parameters.AddWithValue("@Marca"         , sMarca         );
                    cmd.Parameters.AddWithValue("@Descricao"     , sDescricao     );
                    cmd.Parameters.AddWithValue("@Categoria"     , sCategoria     );
                    cmd.Parameters.AddWithValue("@Fornecedor"    , sFornecedor    );
                    cmd.Parameters.AddWithValue("@ProdutoId"     , produtoSelecionadoId);

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
            cbFornecedor    .SelectedValue = -1;
            cbCategoria     .SelectedValue = -1;
            tbCustoAquisicao.Clear();
            tbMarca         .Clear();
            tbDescricao     .Clear();
            produtoSelecionadoId = -1;
        }

        private int produtoSelecionadoId = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbNomeProd.Text = row.Cells["Nome"].Value?.ToString();
                tbCodigo.Text = row.Cells["Código"].Value?.ToString();
                cbCategoria.SelectedValue = row.Cells["CategoriaID"].Value?.ToString();
                cbFornecedor.SelectedValue = row.Cells["FornecedorID"].Value?.ToString();
                tbCustoAquisicao.Text = row.Cells["Custo"].Value?.ToString();
                tbMarca.Text = row.Cells["Marca"].Value?.ToString();
                tbDescricao.Text = row.Cells["Descrição"].Value?.ToString();

                produtoSelecionadoId = Convert.ToInt32(row.Cells["ProdutoID"].Value?.ToString());
            }
        }
    }
}
