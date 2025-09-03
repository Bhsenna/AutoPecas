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
                    string query = "SELECT ProdutoID, NomeProduto, CustoAquisicao FROM Produtos ORDER BY NomeProduto";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        
                        // Define explicitamente os tipos das colunas ANTES de preencher
                        dt.Columns.Add("ProdutoID", typeof(int));
                        dt.Columns.Add("NomeProduto", typeof(string));
                        dt.Columns.Add("CustoAquisicao", typeof(decimal));
                        
                        da.Fill(dt);
                        
                        // Adiciona linha vazia no início
                        DataRow emptyRow = dt.NewRow();
                        emptyRow["ProdutoID"] = -1;
                        emptyRow["NomeProduto"] = "Selecione um produto";
                        emptyRow["CustoAquisicao"] = 0;
                        dt.Rows.InsertAt(emptyRow, 0);
                        
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
                
                // Criar DataTable vazio para evitar erros
                DataTable dt = new DataTable();
                dt.Columns.Add("ProdutoID", typeof(int));
                dt.Columns.Add("NomeProduto", typeof(string));
                dt.Columns.Add("CustoAquisicao", typeof(decimal));
                
                DataRow emptyRow = dt.NewRow();
                emptyRow["ProdutoID"] = -1;
                emptyRow["NomeProduto"] = "Nenhum produto disponível";
                emptyRow["CustoAquisicao"] = 0;
                dt.Rows.Add(emptyRow);
                
                cbProdutoServico.DataSource = dt;
                cbProdutoServico.DisplayMember = "NomeProduto";
                cbProdutoServico.ValueMember = "ProdutoID";
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
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = $"SELECT {campoNome} as Nome, {campoId} as ID FROM {tabela} ORDER BY {campoNome}";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        
                        // Define explicitamente os tipos das colunas
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("ID", typeof(int));
                        
                        da.Fill(dt);

                        // Garantir que a coluna ID tenha o tipo correto
                        if (dt.Columns.Contains("ID"))
                        {
                            dt.Columns["ID"].DataType = typeof(int);
                        }

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
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = @"SELECT S.ServicoID, S.NomeServico, S.Descricao, S.MargemLucro,
                                     (SELECT SUM(P.CustoAquisicao * SP.Quantidade) 
                                      FROM ServicoParaProduto SP 
                                      INNER JOIN Produtos P ON P.ProdutoID = SP.ProdutoID 
                                      WHERE SP.ServicoID = S.ServicoID) as CustoTotal
                                     FROM Servicos S
                                     ORDER BY S.NomeServico";
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
                
                // Criar DataTable vazio
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    using (SQLiteConnection con = BancoSQLite.GetConnection())
                    {
                        using (var transaction = con.BeginTransaction())
                        {
                            try
                            {
                                // Inserir serviço
                                string insertServico = @"INSERT INTO Servicos (NomeServico, Descricao, MargemLucro) 
                                                       VALUES (@NomeServico, @Descricao, @MargemLucro);
                                                       SELECT last_insert_rowid();";

                                int servicoId;
                                using (SQLiteCommand cmd = new SQLiteCommand(insertServico, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@NomeServico", tbNomeServico.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Descricao", tbDescricao.Text.Trim());
                                    cmd.Parameters.AddWithValue("@MargemLucro", decimal.Parse(tbMargem.Text));
                                    servicoId = Convert.ToInt32(cmd.ExecuteScalar());
                                }

                                // Inserir produtos do serviço
                                if (produtosSelecionados.Count > 0)
                                {
                                    string insertProduto = "INSERT INTO ServicoParaProduto (ServicoID, ProdutoID, Quantidade) VALUES (@ServicoID, @ProdutoID, @Quantidade)";
                                    using (SQLiteCommand cmd = new SQLiteCommand(insertProduto, con, transaction))
                                    {
                                        foreach (DataRow produto in produtosSelecionados)
                                        {
                                            cmd.Parameters.Clear();
                                            cmd.Parameters.AddWithValue("@ServicoID", servicoId);
                                            cmd.Parameters.AddWithValue("@ProdutoID", produto["ProdutoID"]);
                                            cmd.Parameters.AddWithValue("@Quantidade", 1.0); // Quantidade padrão
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                }

                                transaction.Commit();
                                MessageBox.Show("Serviço cadastrado com sucesso!");
                                LimparCampos();
                                carregaTabela();
                            }
                            catch
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar serviço: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tbNomeServico.Text))
            {
                MessageBox.Show("Informe o nome do serviço.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeServico.Focus();
                return false;
            }

            if (!decimal.TryParse(tbMargem.Text, out decimal margem) || margem < 0)
            {
                MessageBox.Show("Informe uma margem de lucro válida.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMargem.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbNomeServico.Clear();
            tbDescricao.Clear();
            tbMargem.Clear();
            tbCustoServico.Clear();
            produtosSelecionados.Clear();
            AtualizarGridProdutos();
            
            // Configurar ComboBoxes de forma segura
            ConfigurarComboBoxesSeguro();
        }

        private void ConfigurarComboBoxesSeguro()
        {
            try
            {
                if (cbProdutoServico.Items.Count > 0)
                {
                    cbProdutoServico.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                // Log do erro para debug
                Console.WriteLine($"Erro ao configurar ComboBox: {ex.Message}");
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int produtoId = BancoSQLite.GetComboBoxValue(cbProdutoServico, -1);
                
                if (produtoId == -1)
                {
                    MessageBox.Show("Selecione um produto para adicionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRowView drv = cbProdutoServico.SelectedItem as DataRowView;
                if (drv == null)
                    return;

                if (!produtosSelecionados.Any(r => Convert.ToInt32(r["ProdutoID"]) == produtoId))
                {
                    produtosSelecionados.Add(drv.Row);
                    AtualizarGridProdutos();
                    CalcularCustoServico();
                }
                else
                {
                    MessageBox.Show("Este produto já foi adicionado ao serviço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    CalcularCustoServico();
                }
                else
                {
                    MessageBox.Show("Selecione um produto para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                return;
            }

            var dt = produtosSelecionados[0].Table.Clone();
            foreach (var row in produtosSelecionados)
                dt.ImportRow(row);
            dataGridProdutos.DataSource = dt;
        }

        private void CalcularCustoServico()
        {
            if (produtosSelecionados.Count == 0)
            {
                tbCustoServico.Text = "0,00";
                return;
            }

            decimal custoTotal = 0;
            foreach (DataRow produto in produtosSelecionados)
            {
                custoTotal += Convert.ToDecimal(produto["CustoAquisicao"]);
            }

            tbCustoServico.Text = custoTotal.ToString("N2");
        }
    }
}
