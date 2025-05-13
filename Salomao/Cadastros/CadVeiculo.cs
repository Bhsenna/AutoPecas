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
    public partial class CadVeiculo : UserControl
    {
        public CadVeiculo()
        {
            InitializeComponent();
            carregaTabela();
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Veiculos";
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
            String sTitular = tbTitular.Text;
            String sModelo  = tbModelo .Text;
            String sPlaca   = tbPlaca  .Text;
            String sMarca   = tbMarca  .Text;

            if (sTitular == "" || sPlaca == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                con.Open();
                string query = @"INSERT INTO Veiculos (Placa, Modelo, Marca, ClienteID)
                         VALUES (@Placa, @Modelo, @Marca, @ClienteID)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Placa", sPlaca);
                    cmd.Parameters.AddWithValue("@Modelo", sModelo);
                    cmd.Parameters.AddWithValue("@Marca", sMarca);
                    cmd.Parameters.AddWithValue("@ClienteID", sTitular);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        tbTitular.Clear();
                        tbModelo.Clear();
                        tbPlaca.Clear();
                        tbMarca.Clear();
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
            tbTitular.Text = "";
            tbModelo.Text = "";
            tbPlaca.Text = "";
            tbMarca.Text = "";
        }
    }
}
