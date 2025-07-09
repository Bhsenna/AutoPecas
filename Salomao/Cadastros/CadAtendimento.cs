using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Salomao.Cadastros
{
    public partial class CadAtendimento : UserControl
    {
        public CadAtendimento()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
            populaCombo(cbCliente, "Clientes", "NomeCliente", "ClienteID");
            populaCombo(cbVeiculo, "Veiculos", "Placa || ' - ' || Modelo", "VeiculoID");
            populaCombo(cbServico, "Servicos", "ServicoID", "ServicoID");
            populaCombo(cbProduto, "Produtos", "NomeProduto", "ProdutoID");
        }

        private void populaCombo(ComboBox comboBox, String tabela, String campoNome, String campoId)
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = $"SELECT {campoNome} as Nome, {campoId} as ID FROM {tabela}";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();

                    // Define explicitamente os tipos das colunas
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

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT A.AtendimentoID, A.Data, A.DataPrestacao, A.PrevisaoConclusao, C.NomeCliente, V.Placa, A.ValorSugerido, A.ValorPraticado, A.LucroBruto, A.Observacoes
                                 FROM Atendimentos A
                                 LEFT JOIN Clientes C ON C.ClienteID = A.ClienteID
                                 LEFT JOIN Veiculos V ON V.VeiculoID = A.VeiculoID";
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
            // Validação básica
            if ((cbCliente.SelectedValue == null || (int)cbCliente.SelectedValue == -1) ||
                (cbVeiculo.SelectedValue == null || (int)cbVeiculo.SelectedValue == -1) ||
                dtData.Text == "" || dtDataPrestacao.Text == "" || tbValorSugerido.Text == "" || tbValorPraticado.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Atendimentos
                                    (Data, DataPrestacao, PrevisaoConclusao, ClienteID, VeiculoID, ValorSugerido, ValorPraticado, LucroBruto, Observacoes)
                                VALUES
                                    (@Data, @DataPrestacao, @PrevisaoConclusao, @ClienteID, @VeiculoID, @ValorSugerido, @ValorPraticado, @LucroBruto, @Observacoes)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Data", dtData.Value.Date);
                    cmd.Parameters.AddWithValue("@DataPrestacao", dtDataPrestacao.Value.Date);
                    cmd.Parameters.AddWithValue("@PrevisaoConclusao", dtPrevisaoConclusao.Value.Date);
                    cmd.Parameters.AddWithValue("@ClienteID", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@VeiculoID", cbVeiculo.SelectedValue);
                    cmd.Parameters.AddWithValue("@ValorSugerido", tbValorSugerido.Text);
                    cmd.Parameters.AddWithValue("@ValorPraticado", tbValorPraticado.Text);
                    cmd.Parameters.AddWithValue("@LucroBruto", tbLucroBruto.Text);
                    cmd.Parameters.AddWithValue("@Observacoes", tbObservacoes.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar atendimento: " + ex.Message);
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
            cbCliente.SelectedIndex = 0;
            cbVeiculo.SelectedIndex = 0;
            cbServico.SelectedIndex = 0;
            cbProduto.SelectedIndex = 0;
            dtData.Value = DateTime.Now;
            dtDataPrestacao.Value = DateTime.Now;
            dtPrevisaoConclusao.Value = DateTime.Now;
            tbValorSugerido.Clear();
            tbValorPraticado.Clear();
            tbLucroBruto.Clear();
            tbObservacoes.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Preencher campos do formulário
                dtData.Value = Convert.ToDateTime(row.Cells["Data"].Value);
                dtDataPrestacao.Value = Convert.ToDateTime(row.Cells["DataPrestacao"].Value);
                dtPrevisaoConclusao.Value = Convert.ToDateTime(row.Cells["PrevisaoConclusao"].Value);
                tbValorSugerido.Text = row.Cells["ValorSugerido"].Value?.ToString();
                tbValorPraticado.Text = row.Cells["ValorPraticado"].Value?.ToString();
                tbLucroBruto.Text = row.Cells["LucroBruto"].Value?.ToString();
                tbObservacoes.Text = row.Cells["Observacoes"].Value?.ToString();

                cbCliente.SelectedIndex = cbCliente.FindStringExact(row.Cells["NomeCliente"].Value?.ToString());
                cbVeiculo.SelectedIndex = cbVeiculo.FindString(row.Cells["Placa"].Value?.ToString());
            }
        }
    }
} 