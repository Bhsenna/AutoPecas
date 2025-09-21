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
                string query = @"SELECT Categorias.NomeCategoria as Nome,
                                      Categorias.CategoriaID as CategoriaID
                                 FROM Categorias";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Ocultar coluna ID
                    if (dataGridView1.Columns.Contains("CategoriaID"))
                        dataGridView1.Columns["CategoriaID"].Visible = false;
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
                string query;

                if (categoriaSelecionadoId < 0)
                {
                    query = @"INSERT INTO Categorias
                                        (NomeCategoria)
                                    VALUES
                                        (@NomeCategoria)";
                }
                else
                {
                    query = @"UPDATE Categorias
                                 SET NomeCategoria = @NomeCategoria
                               WHERE CategoriaID = @CategoriaId";
                }


                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeCategoria", sNomeCat);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaSelecionadoId);

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
            categoriaSelecionadoId = -1;
        }

        private int categoriaSelecionadoId = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbNomeCat.Text = row.Cells["Nome"].Value?.ToString();

                categoriaSelecionadoId = Convert.ToInt32(row.Cells["CategoriaID"].Value?.ToString());
            }
        }
    }
}
