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
    public partial class CadCategoria : UserControl
    {
        public CadCategoria()
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
                string query = @"SELECT Categorias.NomeCategoria as Nome
                                 FROM Categorias";
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
            String sNomeCat = tbNomeCat.Text;

            if (sNomeCat == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Categorias
                                    (NomeCategoria)
                                VALUES
                                    (@NomeCategoria)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeCategoria", sNomeCat);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar categoria: " + ex.Message);
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
            tbNomeCat.Clear();
        }
    }
}
