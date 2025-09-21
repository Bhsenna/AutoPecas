﻿using System;
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
                                        Fornecedores.Email as Email,
                                        Fornecedores.FornecedorID as FornecedorID
                                 FROM Fornecedores";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Ocultar coluna ID
                    if (dataGridView1.Columns.Contains("FornecedorID"))
                        dataGridView1.Columns["FornecedorID"].Visible = false;
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
                string query;

                if (fornecedorSelecionadoId < 0)
                {
                    query = @"INSERT INTO Fornecedores
                                        (NomeFornecedor, Endereco, Telefone, Email)
                                    VALUES
                                        (@NomeFornecedor,@Endereco,@Telefone,@Email)";
                }
                else
                {
                    query = @"UPDATE Fornecedores SET
                                        NomeFornecedor = @NomeFornecedor,
                                        Endereco = @Endereco,
                                        Telefone = @Telefone,
                                        Email = @Email
                                  WHERE FornecedorID = @FornecedorID";
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NomeFornecedor", sNome);
                    cmd.Parameters.AddWithValue("@Endereco"      , sEndereco);
                    cmd.Parameters.AddWithValue("@Telefone"      , sTelefone);
                    cmd.Parameters.AddWithValue("@Email"         , sEmail);
                    cmd.Parameters.AddWithValue("@FornecedorID"  , fornecedorSelecionadoId);

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
            fornecedorSelecionadoId = -1;
        }

        private int fornecedorSelecionadoId = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbNomeFor .Text = row.Cells["Nome"].Value?.ToString();
                tbEndereco.Text = row.Cells["Endereço"].Value?.ToString();
                tbTelefone.Text = row.Cells["Telefone"].Value?.ToString();
                tbEmail   .Text = row.Cells["Email"].Value?.ToString();

                fornecedorSelecionadoId = Convert.ToInt32(row.Cells["FornecedorID"].Value?.ToString());
            }
        }
    }
}
