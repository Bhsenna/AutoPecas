using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace AutoPecas.Cadastros
{
    public partial class CadAtendimento : UserControl
    {
        private List<DataRow> servicosSelecionados = new List<DataRow>();

        public CadAtendimento()
        {
            InitializeComponent();
            carregaTabela();
            Styler.GridStyler.Personalizar(dataGridView1);
            Styler.GridStyler.Personalizar(dataGridServicos);
            Styler.ButtonStyler.PersonalizaGravar(btnGravar);
            Styler.ButtonStyler.PersonalizaLimpar(btnLimpar);
            populaCombo(cbCliente, "Clientes", "NomeCliente", "ClienteID");
            populaCombo(cbVeiculo, "Veiculos", "Placa || ' - ' || Modelo", "VeiculoID");
            populaCombo(cbServico, "Servicos", "NomeServico", "ServicoID");
            btnAdicionarServico.Click += btnAdicionarServico_Click;
            btnRemoverServico.Click += btnRemoverServico_Click;
            AtualizarGridServicos();
        }

        private void populaCombo(ComboBox comboBox, String tabela, String campoNome, String campoId)
        {
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query;
                    
                    // Se for a tabela de serviços, incluir MargemLucro
                    if (tabela.Equals("Servicos", StringComparison.OrdinalIgnoreCase))
                    {
                        query = $"SELECT {campoNome} as Nome, {campoId} as ID, MargemLucro FROM {tabela} ORDER BY {campoNome}";
                    }
                    else
                    {
                        query = $"SELECT {campoNome} as Nome, {campoId} as ID FROM {tabela} ORDER BY {campoNome}";
                    }
                    
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        // Define explicitamente os tipos das colunas ANTES de preencher
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("ID", typeof(int));
                        
                        // Se for serviços, adicionar coluna MargemLucro
                        if (tabela.Equals("Servicos", StringComparison.OrdinalIgnoreCase))
                        {
                            dt.Columns.Add("MargemLucro", typeof(decimal));
                        }

                        da.Fill(dt);

                        // Adiciona linha vazia no início
                        DataRow emptyRow = dt.NewRow();
                        emptyRow["Nome"] = "Selecione...";
                        emptyRow["ID"] = -1;
                        if (tabela.Equals("Servicos", StringComparison.OrdinalIgnoreCase))
                        {
                            emptyRow["MargemLucro"] = 0;
                        }
                        dt.Rows.InsertAt(emptyRow, 0);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "Nome";
                        comboBox.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados da tabela {tabela}: {ex.Message}\n\nVerifique se a migração do banco foi executada.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Criar DataTable vazio para evitar erros
                DataTable dt = new DataTable();
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("ID", typeof(int));
                
                // Se for serviços, adicionar coluna MargemLucro
                if (tabela.Equals("Servicos", StringComparison.OrdinalIgnoreCase))
                {
                    dt.Columns.Add("MargemLucro", typeof(decimal));
                }
                
                DataRow emptyRow = dt.NewRow();
                emptyRow["Nome"] = "Nenhum registro disponível";
                emptyRow["ID"] = -1;
                if (tabela.Equals("Servicos", StringComparison.OrdinalIgnoreCase))
                {
                    emptyRow["MargemLucro"] = 0;
                }
                dt.Rows.Add(emptyRow);
                
                comboBox.DataSource = dt;
                comboBox.DisplayMember = "Nome";
                comboBox.ValueMember = "ID";
            }
        }

        private void carregaTabela()
        {
            try
            {
                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = @"SELECT A.Data,
                                            A.DataPrestacao,
                                            A.PrevisaoConclusao,
                                            C.NomeCliente,
                                            V.Placa,
                                            A.ValorSugerido,
                                            A.ValorPraticado,
                                            A.LucroBruto,
                                            A.Observacoes,
                                            A.AtendimentoID,
                                            A.ClienteID,
                                            A.VeiculoID
                                     FROM Atendimentos A
                                     LEFT JOIN Clientes C ON C.ClienteID = A.ClienteID
                                     LEFT JOIN Veiculos V ON V.VeiculoID = A.VeiculoID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Ocultar colunas de IDs
                        if (dataGridView1.Columns.Contains("AtendimentoID"))
                            dataGridView1.Columns["AtendimentoID"].Visible = false;
                        if (dataGridView1.Columns.Contains("ClienteID"))
                            dataGridView1.Columns["ClienteID"].Visible = false;
                        if (dataGridView1.Columns.Contains("VeiculoID"))
                            dataGridView1.Columns["VeiculoID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar atendimentos: {ex.Message}\n\nVerifique se a migração do banco foi executada.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Validação básica
            int clienteId = BancoSQLite.GetComboBoxValue(cbCliente, -1);
            int veiculoId = BancoSQLite.GetComboBoxValue(cbVeiculo, -1);

            if (clienteId == -1 || veiculoId == -1 ||
                dtData.Text == "" || dtDataPrestacao.Text == "" || tbValorSugerido.Text == "" || tbValorPraticado.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            if (servicosSelecionados.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um serviço ao atendimento.");
                return;
            }

            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                using (var transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Insere o atendimento
                        string query;

                        if (atendimentoSelecionadoId < 0)
                        {
                            query = @"INSERT INTO Atendimentos
                                                (Data, DataPrestacao, PrevisaoConclusao, ClienteID, VeiculoID, ValorSugerido, ValorPraticado, LucroBruto, Observacoes)
                                            VALUES
                                                (@Data, @DataPrestacao, @PrevisaoConclusao, @ClienteID, @VeiculoID, @ValorSugerido, @ValorPraticado, @LucroBruto, @Observacoes);
                                    SELECT last_insert_rowid();";
                        }
                        else
                        {
                            query = @"UPDATE Atendimentos SET
                                                Data              = @Data,
                                                DataPrestacao     = @DataPrestacao,
                                                PrevisaoConclusao = @PrevisaoConclusao,
                                                ClienteID         = @ClienteID,
                                                VeiculoID         = @VeiculoID,
                                                ValorSugerido     = @ValorSugerido,
                                                ValorPraticado    = @ValorPraticado,
                                                LucroBruto        = @LucroBruto,
                                                Observacoes       = @Observacoes
                                      WHERE AtendimentoID = @AtendimentoID";
                        }

                        long atendimentoId;
                        using (SQLiteCommand cmd = new SQLiteCommand(query, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Data", dtData.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@DataPrestacao", dtDataPrestacao.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@PrevisaoConclusao", dtPrevisaoConclusao.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@ClienteID", clienteId);
                            cmd.Parameters.AddWithValue("@VeiculoID", veiculoId);
                            cmd.Parameters.AddWithValue("@ValorSugerido", tbValorSugerido.Text);
                            cmd.Parameters.AddWithValue("@ValorPraticado", tbValorPraticado.Text);
                            cmd.Parameters.AddWithValue("@LucroBruto", tbLucroBruto.Text);
                            cmd.Parameters.AddWithValue("@Observacoes", tbObservacoes.Text);
                            cmd.Parameters.AddWithValue("@AtendimentoID", atendimentoSelecionadoId);
                            var scalar = cmd.ExecuteScalar();
                            atendimentoId = Convert.ToInt32(scalar ?? atendimentoSelecionadoId);
                        }

                        // Remover os serviços antigos
                        string deleteProdutos = "DELETE FROM AtendimentoServicos WHERE AtendimentoID = @AtendimentoID";
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteProdutos, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AtendimentoID", atendimentoId);
                            cmd.ExecuteNonQuery();
                        }
                        // Insere os serviços do atendimento
                        string queryServicos = @"INSERT INTO AtendimentoServicos
                                                    (AtendimentoID, ServicoID, Quantidade, ValorUnitario)
                                                VALUES
                                                    (@AtendimentoID, @ServicoID, @Quantidade, @ValorUnitario)";

                        using (var cmd = new SQLiteCommand(queryServicos, con, transaction))
                        {
                            foreach (DataRow servico in servicosSelecionados)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@AtendimentoID", atendimentoId);
                                cmd.Parameters.AddWithValue("@ServicoID", servico["ID"]);
                                cmd.Parameters.AddWithValue("@Quantidade", 1); // Quantidade padrão
                                cmd.Parameters.AddWithValue("@ValorUnitario", CalcularCustoServico(Convert.ToInt32(servico["ID"])));
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        // Processa a baixa automática de estoque
                        try
                        {
                            EstoqueManager.ProcessarBaixaEstoqueAtendimento((int)atendimentoId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Atendimento registrado, mas houve erro na baixa de estoque: {ex.Message}");
                        }

                        MessageBox.Show("Atendimento cadastrado com sucesso!");
                        clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao cadastrar atendimento: " + ex.Message);
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

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            try
            {
                int servicoId = BancoSQLite.GetComboBoxValue(cbServico, -1);

                if (servicoId == -1)
                {
                    MessageBox.Show("Selecione um serviço para adicionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRowView drv = cbServico.SelectedItem as DataRowView;
                if (drv == null)
                    return;

                if (!servicosSelecionados.Any(r => Convert.ToInt32(r["ID"]) == servicoId))
                {
                    servicosSelecionados.Add(drv.Row);
                    AtualizarGridServicos();
                    CalcularValores();
                    //MessageBox.Show("Serviço adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Este serviço já foi adicionado ao atendimento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar serviço: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridServicos.SelectedRows.Count > 0)
                {
                    var cellValue = dataGridServicos.SelectedRows[0].Cells["ID"].Value;
                    int servicoId = Convert.ToInt32(cellValue);
                    servicosSelecionados.RemoveAll(r => Convert.ToInt32(r["ID"]) == servicoId);
                    AtualizarGridServicos();
                    CalcularValores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover serviço: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGridServicos()
        {
            if (servicosSelecionados.Count == 0)
            {
                dataGridServicos.DataSource = null;
                return;
            }

            var dt = servicosSelecionados[0].Table.Clone();
            foreach (var row in servicosSelecionados)
                dt.ImportRow(row);
            dataGridServicos.DataSource = dt;

            // Ocultar colunas de IDs
            if (dataGridServicos.Columns.Contains("ID"))
                dataGridServicos.Columns["ID"].Visible = false;
        }

        private void CalcularValores()
        {
            if (servicosSelecionados.Count == 0)
            {
                tbValorSugerido.Text = "0,00";
                tbLucroBruto.Text = "0,00";
                return;
            }

            decimal custoTotal = 0;
            decimal lucroTotal = 0;

            foreach (DataRow servico in servicosSelecionados)
            {
                decimal margemLucro = Convert.ToDecimal(servico["MargemLucro"]);
                decimal custoServico = CalcularCustoServico(Convert.ToInt32(servico["ID"]));

                custoTotal += custoServico;
                lucroTotal += custoServico * (margemLucro / 100);
            }

            decimal valorSugerido = custoTotal + lucroTotal;
            tbValorSugerido.Text = valorSugerido.ToString("N2");
            tbLucroBruto.Text = lucroTotal.ToString("N2");
        }

        private decimal CalcularCustoServico(int servicoId)
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"
                    SELECT SUM(p.CustoAquisicao * sp.Quantidade) as CustoTotal
                    FROM ServicoParaProduto sp
                    INNER JOIN Produtos p ON p.ProdutoID = sp.ProdutoID
                    WHERE sp.ServicoID = @ServicoID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ServicoID", servicoId);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        private void clear()
        {
            ConfigurarComboBoxesSeguro();
            dtData.Value = DateTime.Now;
            dtDataPrestacao.Value = DateTime.Now;
            dtPrevisaoConclusao.Value = DateTime.Now;
            tbValorSugerido.Clear();
            tbValorPraticado.Clear();
            tbLucroBruto.Clear();
            tbObservacoes.Clear();
            servicosSelecionados.Clear();
            AtualizarGridServicos();

            atendimentoSelecionadoId = -1;
        }

        private void ConfigurarComboBoxesSeguro()
        {
            try
            {
                if (cbCliente.Items.Count > 0)
                {
                    cbCliente.SelectedIndex = 0;
                }
                if (cbVeiculo.Items.Count > 0)
                {
                    cbVeiculo.SelectedIndex = 0;
                }
                if (cbServico.Items.Count > 0)
                {
                    cbServico.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                // Log do erro para debug
                Console.WriteLine($"Erro ao configurar ComboBoxes: {ex.Message}");
            }
        }

        private int atendimentoSelecionadoId = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clear();

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Preencher campos do formulário
                dtData.Value = Convert.ToDateTime(row.Cells["Data"].Value);
                dtDataPrestacao.Value = Convert.ToDateTime(row.Cells["DataPrestacao"].Value);
                dtPrevisaoConclusao.Value = Convert.ToDateTime(row.Cells["PrevisaoConclusao"].Value);
                tbValorSugerido.Text = row.Cells["ValorSugerido"].Value?.ToString();
                tbValorPraticado.Text = row.Cells["ValorPraticado"].Value?.ToString();
                tbLucroBruto.Text = row.Cells["LucroBruto"].Value?.ToString();
                tbObservacoes.Text = row.Cells["Observacoes"].Value?.ToString();

                cbCliente.SelectedValue = row.Cells["ClienteID"].Value?.ToString();
                cbVeiculo.SelectedValue = row.Cells["VeiculoID"].Value?.ToString();

                atendimentoSelecionadoId = Convert.ToInt32(row.Cells["AtendimentoID"].Value);
                CarregarServicosDoAtendimento(atendimentoSelecionadoId);
            }
        }

        private void CarregarServicosDoAtendimento(int atendimentoId)
        {
            using (SQLiteConnection con = BancoSQLite.GetConnection())
            {
                string query = @"
                        SELECT 
                            asp.ServicoID
                        FROM AtendimentoServicos asp
                        WHERE asp.AtendimentoID = @AtendimentoID";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AtendimentoID", atendimentoId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbServico.SelectedValue = reader.GetInt32("ServicoID");
                            btnAdicionarServico_Click(null, null);
                        }
                        cbServico.SelectedValue = -1;
                    }
                }
            }
        }

        private void lbPrevisaoConclusao_Click(object sender, EventArgs e)
        {

        }
    }
} 