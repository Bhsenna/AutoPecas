using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salomao.Cadastros
{
    public partial class CadServicos : UserControl
    {
        private List<DataRow> produtosSelecionados = new List<DataRow>();

        private void PopularComboProdutos()
        {
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = "SELECT ProdutoID, NomeProduto, CustoAquisicao FROM Produtos";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        // Garantir que as colunas tenham os tipos corretos
                        if (dt.Columns.Contains("ProdutoID"))
                        {
                            dt.Columns["ProdutoID"].DataType = typeof(int);
                        }
                        
                        cbProdutoServico.DataSource = dt;
                        cbProdutoServico.DisplayMember = "NomeProduto";
                        cbProdutoServico.ValueMember = "ProdutoID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}\n\nVerifique se a migração do banco foi executada.", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public CadServicos()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            btnRemoverProduto.Click += btnRemoverProduto_Click;
            PopularComboProdutos();
            AtualizarGridProdutos();
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
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = @"SELECT Servicos.ServicoID as ID,
                                            Servicos.NomeServico as Nome,
                                            Servicos.Descricao as Descrição,
                                            Servicos.MargemLucro as Margem
                                     FROM Servicos
                                     ORDER BY Servicos.NomeServico";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar serviços: {ex.Message}\n\nVerifique se a migração do banco foi executada.", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            String sNomeServico = tbNomeServico.Text;
            String sDescricao = tbDescricao.Text;
            String sMargem = tbMargem.Text;

            if (sNomeServico == "" || sMargem == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            if (produtosSelecionados.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto ao serviço.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                using (var transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Insere o serviço
                        string query = @"INSERT INTO Servicos
                                            (NomeServico, Descricao, MargemLucro)
                                        VALUES
                                            (@NomeServico, @Descricao, @MargemLucro)";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@NomeServico", sNomeServico);
                            cmd.Parameters.AddWithValue("@Descricao", sDescricao);
                            cmd.Parameters.AddWithValue("@MargemLucro", sMargem);
                            cmd.ExecuteNonQuery();
                        }

                        // Obtém o ID do serviço inserido
                        long servicoId;
                        using (var cmd = new SQLiteCommand("SELECT last_insert_rowid()", con, transaction))
                        {
                            servicoId = Convert.ToInt64(cmd.ExecuteScalar());
                        }

                        // Insere os produtos do serviço
                        string queryProdutos = @"INSERT INTO ServicoParaProduto
                                                    (ServicoID, ProdutoID, Quantidade)
                                                VALUES
                                                    (@ServicoID, @ProdutoID, @Quantidade)";

                        using (var cmd = new SQLiteCommand(queryProdutos, con, transaction))
                        {
                            foreach (DataRow produto in produtosSelecionados)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@ServicoID", servicoId);
                                cmd.Parameters.AddWithValue("@ProdutoID", produto["ProdutoID"]);
                                cmd.Parameters.AddWithValue("@Quantidade", 1); // Quantidade padrão
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Serviço cadastrado com sucesso!");
                        clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao cadastrar serviço: " + ex.Message);
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
            tbNomeServico.Clear();
            tbDescricao.Clear();
            tbMargem.Clear();
            produtosSelecionados.Clear();
            AtualizarGridProdutos();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int produtoId = BancoSQLite.GetComboBoxValue(cbProdutoServico, -1);
                
                if (produtoId == -1)
                    return;

                DataRowView drv = cbProdutoServico.SelectedItem as DataRowView;
                if (drv == null)
                    return;

                if (!produtosSelecionados.Any(r => Convert.ToInt32(r["ProdutoID"]) == produtoId))
                {
                    produtosSelecionados.Add(drv.Row);
                    AtualizarGridProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto: {ex.Message}", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProdutos.SelectedRows.Count > 0)
                {
                    var cellValue = dataGridProdutos.SelectedRows[0].Cells["ProdutoID"].Value;
                    int produtoId = Convert.ToInt32(cellValue);
                    produtosSelecionados.RemoveAll(r => Convert.ToInt32(r["ProdutoID"]) == produtoId);
                    AtualizarGridProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover produto: {ex.Message}", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGridProdutos()
        {
            if (produtosSelecionados.Count == 0)
            {
                dataGridProdutos.DataSource = null;
                tbCustoServico.Text = "0,00";
                return;
            }
            var dt = produtosSelecionados[0].Table.Clone();
            foreach (var row in produtosSelecionados)
                dt.ImportRow(row);
            dataGridProdutos.DataSource = dt;
            decimal total = produtosSelecionados.Sum(r => Convert.ToDecimal(r["CustoAquisicao"]));
            tbCustoServico.Text = total.ToString("N2");
        }

    }
}
