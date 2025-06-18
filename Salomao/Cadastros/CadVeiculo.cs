using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = "SELECT NomeCliente, cast(ClienteID as text) as ClienteID FROM Clientes";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow emptyRow = dt.NewRow();
                    emptyRow["NomeCliente"] = "";
                    emptyRow["ClienteID"] = "";
                    dt.Rows.Add(emptyRow);

                    DataView dv = new DataView(dt, "", "NomeCliente", DataViewRowState.CurrentRows);

                    cbTitular.DataSource = dv;
                    cbTitular.DisplayMember = "NomeCliente";
                    cbTitular.ValueMember = "ClienteID";
                }
            }
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT Placa as Placa,
                                        Modelo as Modelo,
                                        Marca as Marca,
                                        NomeCliente as Titular
                                 FROM Veiculos
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
            String sPlaca   = tbPlaca  .Text;
            String sModelo  = tbModelo .Text;
            String sMarca   = tbMarca  .Text;
            String sTitular = cbTitular.SelectedValue?.ToString() ?? "";

            if (sPlaca == "" || sModelo == "" || sMarca == "" || sTitular == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Veiculos
                                    (Placa, Modelo, Marca, ClienteID)
                                VALUES
                                    (@Placa,@Modelo,@Marca,@ClienteID)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Placa"    , sPlaca);
                    cmd.Parameters.AddWithValue("@Modelo"   , sModelo);
                    cmd.Parameters.AddWithValue("@Marca"    , sMarca);
                    cmd.Parameters.AddWithValue("@ClienteID", sTitular);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar veículo: " + ex.Message);
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
            cbTitular.SelectedValue = "";
            tbModelo .Clear();
            tbPlaca  .Clear();
            tbMarca  .Clear();
        }
    }
}
