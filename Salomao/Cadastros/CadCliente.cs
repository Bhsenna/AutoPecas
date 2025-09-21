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
    public partial class CadCliente : UserControl
    {
        public CadCliente()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.GridStyler.Personalizar(dataGridViewVeiculos);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT Clientes.NomeCliente as Nome,
                                        Clientes.Telefone as Telefone,
                                        Clientes.Email as Email,
                                        Clientes.ClienteID as ClienteID
                                 FROM Clientes";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Ocultar a coluna ClienteID
                    if (dataGridView1.Columns.Contains("ClienteID"))
                        dataGridView1.Columns["ClienteID"].Visible = false;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            String sNome     = tbNomeClient.Text;
            String sTelefone = tbTelefone  .Text;
            String sEmail    = tbEmail     .Text;

            if (sNome == "" || sTelefone == "" || sEmail == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query;

                if (clienteSelecionadoId < 0)
                {
                    query = @"INSERT INTO Clientes
                                        (NomeCliente, Telefone, Email)
                                    VALUES
                                        (@NomeCliente,@Telefone,@Email)";
                }
                else
                {
                    query = @"UPDATE Clientes SET
                                        NomeCliente = @NomeCliente,
                                        Telefone    = @Telefone,
                                        Email       = @Email
                                  WHERE ClienteID = @ClienteID";
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeCliente", sNome);
                    cmd.Parameters.AddWithValue("@Telefone"   , sTelefone);
                    cmd.Parameters.AddWithValue("@Email"      , sEmail);
                    cmd.Parameters.AddWithValue("@ClienteID"  , clienteSelecionadoId);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
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
            tbNomeClient.Clear();
            tbTelefone  .Clear();
            tbEmail     .Clear();
            clienteSelecionadoId = -1;
        }

        private int clienteSelecionadoId = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clear();

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Preencher campos do formulário
                tbNomeClient.Text = row.Cells["Nome"].Value?.ToString();
                tbTelefone.Text = row.Cells["Telefone"].Value?.ToString();
                tbEmail.Text = row.Cells["Email"].Value?.ToString();

                clienteSelecionadoId = Convert.ToInt32(row.Cells["ClienteID"].Value?.ToString());
                CarregarVeiculosDoCliente(clienteSelecionadoId);
            }
        }

        private void CarregarVeiculosDoCliente(int clienteId)
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT Placa, Modelo, Marca FROM Veiculos WHERE ClienteID = @ClienteID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", clienteId);
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewVeiculos.DataSource = dt;
                    }
                }
            }
        }

        private void btnGravarVeiculo_Click(object sender, EventArgs e)
        {
            if (clienteSelecionadoId == -1)
            {
                MessageBox.Show("Selecione um cliente antes de cadastrar um veículo.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPlaca.Text) || string.IsNullOrWhiteSpace(tbMarca.Text) || string.IsNullOrWhiteSpace(tbModelo.Text))
            {
                MessageBox.Show("Preencha todos os campos do veículo.");
                return;
            }
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Veiculos (Placa, Modelo, Marca, ClienteID) VALUES (@Placa, @Modelo, @Marca, @ClienteID)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Placa", tbPlaca.Text);
                    cmd.Parameters.AddWithValue("@Modelo", tbModelo.Text);
                    cmd.Parameters.AddWithValue("@Marca", tbMarca.Text);
                    cmd.Parameters.AddWithValue("@ClienteID", clienteSelecionadoId);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        LimparVeiculo();
                        CarregarVeiculosDoCliente(clienteSelecionadoId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar veículo: " + ex.Message);
                    }
                }
            }
        }

        private void btnLimparVeiculo_Click(object sender, EventArgs e)
        {
            LimparVeiculo();
        }

        private void LimparVeiculo()
        {
            tbPlaca.Clear();
            tbMarca.Clear();
            tbModelo.Clear();
        }
    }
}
