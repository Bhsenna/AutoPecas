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
    public partial class CadFornecedor : UserControl
    {
        public CadFornecedor()
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
                string query = @"SELECT Fornecedores.NomeFornecedor as Nome,
                                        Fornecedores.Endereco as Endereço,
                                        Fornecedores.Telefone as Telefone,
                                        Fornecedores.Email as Email
                                 FROM Fornecedores";
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
            String sNome     = tbNomeFor .Text;
            String sEndereco = tbEndereco.Text;
            String sTelefone = tbTelefone.Text;
            String sEmail    = tbEmail   .Text;

            if (sNome == "" || sEndereco == "" || sTelefone == "" || sEmail == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Fornecedores
                                    (NomeFornecedor, Endereco, Telefone, Email)
                                VALUES
                                    (@NomeFornecedor,@Endereco,@Telefone,@Email)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeFornecedor", sNome);
                    cmd.Parameters.AddWithValue("@Endereco"      , sEndereco);
                    cmd.Parameters.AddWithValue("@Telefone"      , sTelefone);
                    cmd.Parameters.AddWithValue("@Email"         , sEmail);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message);
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
            tbNomeFor .Clear();
            tbEndereco.Clear();
            tbTelefone.Clear();
            tbEmail   .Clear();
        }
    }
}
