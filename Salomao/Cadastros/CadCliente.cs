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
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT NomeCliente as Nome,
                                        Telefone as Telefone,
                                        Email as Email
                                 FROM Clientes";
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
                string query = @"INSERT INTO Clientes
                                    (NomeCliente, Telefone, Email)
                                VALUES
                                    (@NomeCliente,@Telefone,@Email)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeCliente", sNome);
                    cmd.Parameters.AddWithValue("@Telefone"   , sTelefone);
                    cmd.Parameters.AddWithValue("@Email"      , sEmail);

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
        }
    }
}
