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
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = "SELECT ProdutoID, NomeProduto, CustoAquisicao FROM Produtos";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbProdutoServico.DataSource = dt;
                    cbProdutoServico.DisplayMember = "NomeProduto";
                    cbProdutoServico.ValueMember = "ProdutoID";
                }
            }
        }

        public CadServicos()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
            populaCombo(cbVeiculo, "Veiculos", "(Placa || ' - ' || Modelo)", "VeiculoID");
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
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT Servicos.ServicoID as Servico,
                                        Veiculos.Placa as Placa,
                                        Veiculos.Modelo as Modelo,
                                        Clientes.NomeCliente as Titular,
                                        Servicos.MargemLucro as Margem
                                 FROM Servicos
                                 LEFT JOIN Veiculos ON Veiculos.VeiculoID = Servicos.VeiculoID
                                 LEFT JOIN Clientes ON Clientes.ClienteID = Veiculos.ClienteID";
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
            String sVeiculo = cbVeiculo.SelectedValue?.ToString() ?? "";
            String sMargem = tbMargem.Text;

            if (sVeiculo == "" || sMargem == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Servicos
                                    (VeiculoID, MargemLucro)
                                VALUES
                                    (@VeiculoID,@MargemLucro)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VeiculoID", sVeiculo);
                    cmd.Parameters.AddWithValue("@MargemLucro", sMargem);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        clear();
                    }
                    catch (Exception ex)
                    {
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
            cbVeiculo.SelectedValue = "";
            tbMargem.Clear();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (cbProdutoServico.SelectedValue == null)
                return;
            int produtoId = Convert.ToInt32(cbProdutoServico.SelectedValue);
            DataRowView drv = cbProdutoServico.SelectedItem as DataRowView;
            if (drv == null)
                return;
            // ...
            if (!produtosSelecionados.Any(r => Convert.ToInt32(r["ProdutoID"]) == produtoId))
            {
                produtosSelecionados.Add(drv.Row);
                AtualizarGridProdutos();
            }

        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dataGridProdutos.SelectedRows.Count > 0)
            {
                int produtoId = Convert.ToInt32(dataGridProdutos.SelectedRows[0].Cells["ProdutoID"].Value);
                produtosSelecionados.RemoveAll(r => Convert.ToInt32(r["ProdutoID"]) == produtoId);
                AtualizarGridProdutos();
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
