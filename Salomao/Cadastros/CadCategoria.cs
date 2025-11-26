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
            
            // Background moderno
            this.BackColor = Styler.ModernColors.Background;
            this.Padding = new Padding(Styler.Spacing.MD);
            
            carregaTabela();
            
            // Grid moderno com hover effects
            Styler.EnhancedGridStyler.ApplyModernStyle(dataGridView1);
            
            // Botões com estados visuais
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
            
            Styler.InteractionStyler.ApplyButtonStates(btnGravar, Styler.InteractionStyler.ButtonStyle.Success);
            Styler.InteractionStyler.ApplyButtonStates(btnLimpar, Styler.InteractionStyler.ButtonStyle.Danger);
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
                        
                    // Aplicar fonte moderna na coluna Nome
                    if (dataGridView1.Columns.Contains("Nome"))
                    {
                        dataGridView1.Columns["Nome"].DefaultCellStyle.Font = Styler.ModernFonts.BodyMedium;
                    }
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            String sNomeCat = tbNomeCat.Text;

            if (sNomeCat == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
