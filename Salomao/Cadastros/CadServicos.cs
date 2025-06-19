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
    public partial class CadServicos : UserControl
    {
        public CadServicos()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);

            populaCombo(cbVeiculo, "Veiculos", "(Placa || ' - ' || Modelo)", "VeiculoID");
        }

        private void populaCombo(ComboBox comboBox, String tabela, String campoNome, String campoId)
        {

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = $"SELECT {campoNome} Nome, cast({campoId} as text) as ID FROM {tabela}";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow emptyRow = dt.NewRow();
                    emptyRow["Nome"] = "";
                    emptyRow["ID"] = "";
                    dt.Rows.Add(emptyRow);

                    DataView dv = new DataView(dt, "", "Nome", DataViewRowState.CurrentRows);

                    comboBox.DataSource = dv;
                    comboBox.DisplayMember = "Nome";
                    comboBox.ValueMember = "ID";
                }
            }
        }

        private void carregaTabela()
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"SELECT Servicos.ServicoID as Servico,
                                        Veiculos.Placa as Placa,
                                        Veiculos.Modelo as Modelo,
                                        Clientes.NomeCliente as Titular,
                                        Servicos.MargemLucro as Margem
                                 FROM Servicos
                                 LEFT JOIN Veiculos ON Veiculos.VeiculoID = Servicos.VeiculoID
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
            String sVeiculo = cbVeiculo.SelectedValue?.ToString() ?? "";
            String sMargem = tbMargem.Text;

            if (sVeiculo == "" || sMargem == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"INSERT INTO Servicos
                                    (VeiculoID, MargemLucro)
                                VALUES
                                    (@VeiculoID,@MargemLucro)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VeiculoID", sVeiculo);
                    cmd.Parameters.AddWithValue("@MargemLucro", sMargem);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar serviço: " + ex.Message);
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
            cbVeiculo.SelectedValue = "";
            tbMargem.Clear();
        }
    }
}
