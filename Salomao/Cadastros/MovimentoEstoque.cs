using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Salomao.Cadastros
{
    public partial class MovimentoEstoque : UserControl
    {
        public MovimentoEstoque()
        {
            InitializeComponent();
            CarregarTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
            PopularComboProdutos();
            ConfigurarFiltros();
        }

        private void PopularComboProdutos()
        {
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = "SELECT ProdutoID, NomeProduto, CodigoProduto FROM Produtos ORDER BY NomeProduto";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Garantir que as colunas tenham os tipos corretos
                        if (dt.Columns.Contains("ProdutoID"))
                        {
                            dt.Columns["ProdutoID"].DataType = typeof(int);
                        }

                        DataRow emptyRow = dt.NewRow();
                        emptyRow["ProdutoID"] = -1;
                        emptyRow["NomeProduto"] = "Selecione um produto";
                        emptyRow["CodigoProduto"] = "";
                        dt.Rows.InsertAt(emptyRow, 0);

                        cbProduto.DataSource = dt;
                        cbProduto.DisplayMember = "NomeProduto";
                        cbProduto.ValueMember = "ProdutoID";

                        // Cria uma cópia para o filtro
                        DataTable dtFiltro = dt.Copy();
                        DataRow emptyRowFiltro = dtFiltro.NewRow();
                        emptyRowFiltro["ProdutoID"] = -1;
                        emptyRowFiltro["NomeProduto"] = "Todos os produtos";
                        emptyRowFiltro["CodigoProduto"] = "";
                        dtFiltro.Rows.InsertAt(emptyRowFiltro, 0);

                        cbProdutoFiltro.DataSource = dtFiltro;
                        cbProdutoFiltro.DisplayMember = "NomeProduto";
                        cbProdutoFiltro.ValueMember = "ProdutoID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}\n\nVerifique se a migração do banco foi executada.", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarFiltros()
        {
            dtDataInicio.Value = DateTime.Now.AddDays(-30);
            dtDataFim.Value = DateTime.Now;
            cbProdutoFiltro.SelectedIndex = 0;
        }

        private void CarregarTabela()
        {
            try
            {
                DateTime? dataInicio = dtDataInicio.Value.Date;
                DateTime? dataFim = dtDataFim.Value.Date.AddDays(1).AddSeconds(-1);
                int? produtoId = null;

                if (cbProdutoFiltro.SelectedValue != null && (int)cbProdutoFiltro.SelectedValue != -1)
                {
                    produtoId = (int)cbProdutoFiltro.SelectedValue;
                }

                dataGridView1.DataSource = EstoqueManager.ObterMovimentosEstoque(dataInicio, dataFim, produtoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar movimentos: " + ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int produtoId = (int)cbProduto.SelectedValue;
                    decimal quantidade = decimal.Parse(tbQuantidade.Text);
                    string tipoMovimento = rbEntrada.Checked ? "E" : "S";
                    string origem = rbEntrada.Checked ? "Entrada Manual" : "Saída Manual";
                    string observacao = tbObservacao.Text;

                    if (rbEntrada.Checked)
                    {
                        EstoqueManager.RegistrarEntrada(produtoId, quantidade, origem, observacao);
                    }
                    else
                    {
                        EstoqueManager.RegistrarSaida(produtoId, quantidade, origem, observacao);
                    }

                    MessageBox.Show("Movimento registrado com sucesso!");
                    LimparCampos();
                    CarregarTabela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar movimento: " + ex.Message);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (cbProduto.SelectedValue == null || (int)cbProduto.SelectedValue == -1)
            {
                MessageBox.Show("Selecione um produto.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbQuantidade.Text))
            {
                MessageBox.Show("Informe a quantidade.");
                return false;
            }

            if (!decimal.TryParse(tbQuantidade.Text, out decimal quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade deve ser um número positivo.");
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
            cbProduto.SelectedIndex = 0;
            tbQuantidade.Clear();
            tbObservacao.Clear();
            rbEntrada.Checked = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            ConfigurarFiltros();
            CarregarTabela();
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int produtoId = BancoSQLite.GetComboBoxValue(cbProduto, -1);
                
                if (produtoId != -1)
                {
                    decimal saldo = EstoqueManager.ObterSaldoAtual(produtoId);
                    lblSaldoAtual.Text = $"Saldo Atual: {saldo:N2}";
                }
                else
                {
                    lblSaldoAtual.Text = "Saldo Atual: 0,00";
                }
            }
            catch (Exception ex)
            {
                lblSaldoAtual.Text = "Saldo Atual: 0,00";
                // Opcional: log do erro para debug
                // Console.WriteLine($"Erro ao obter saldo: {ex.Message}");
            }
        }
    }
} 