using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Salomao.Models;

namespace Salomao
{
    public partial class DetalhesAgendamentoForm : Form
    {
        private DateTime dataSelecionada;
        private List<AgendamentoCalendario> agendamentos;
        private DataGridView dataGridAgendamentos;

        public DetalhesAgendamentoForm(DateTime data, List<AgendamentoCalendario> agendamentosData)
        {
            InitializeComponent();
            this.dataSelecionada = data;
            this.agendamentos = agendamentosData;
            
            ConfigurarInterface();
            CarregarDados();
        }

        private void ConfigurarInterface()
        {
            this.Text = $"Agendamentos - {dataSelecionada.ToString("dd/MM/yyyy", CultureInfo.GetCultureInfo("pt-BR"))}";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.MinimumSize = new Size(800, 400);
            this.BackColor = ColorTranslator.FromHtml("#F3F4F6");

            // Panel superior com informações
            var panelSuperior = new Panel
            {
                Height = 80,
                Dock = DockStyle.Top,
                BackColor = ColorTranslator.FromHtml("#1E3A8A"),
                Padding = new Padding(20)
            };

            var lblTitulo = new Label
            {
                Text = $"Agendamentos do dia {dataSelecionada:dd/MM/yyyy}",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblQuantidade = new Label
            {
                Text = $"{agendamentos.Count} agendamento(s) encontrado(s)",
                Size = new Size(200, 30),
                Location = new Point(20, 45),
                ForeColor = ColorTranslator.FromHtml("#E5E7EB"),
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.MiddleLeft
            };

            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Controls.Add(lblQuantidade);

            // Panel inferior com botões
            var panelInferior = new Panel
            {
                Height = 60,
                Dock = DockStyle.Bottom,
                BackColor = ColorTranslator.FromHtml("#E5E7EB"),
                Padding = new Padding(20, 10, 20, 10)
            };

            var btnFechar = new Button
            {
                Text = "Fechar",
                Size = new Size(100, 40),
                Dock = DockStyle.Right,
                BackColor = ColorTranslator.FromHtml("#6B7280"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.Click += (s, e) => this.Close();

            var btnEditar = new Button
            {
                Text = "Editar Selecionado",
                Size = new Size(150, 40),
                Location = new Point(panelInferior.Width - 280, 10),
                BackColor = ColorTranslator.FromHtml("#2563EB"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Click += BtnEditar_Click;

            panelInferior.Controls.Add(btnFechar);
            panelInferior.Controls.Add(btnEditar);

            // DataGridView para agendamentos
            dataGridAgendamentos = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false
            };

            // Aplicar estilo do sistema
            Styler.GridStyler.Personalizar(dataGridAgendamentos);

            // Panel central para o grid
            var panelCentral = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };
            panelCentral.Controls.Add(dataGridAgendamentos);

            this.Controls.Add(panelCentral);
            this.Controls.Add(panelSuperior);
            this.Controls.Add(panelInferior);
        }

        private void CarregarDados()
        {
            // Criar DataTable com as colunas necessárias
            var dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Cliente", typeof(string));
            dataTable.Columns.Add("Veículo", typeof(string));
            dataTable.Columns.Add("Data Agendamento", typeof(DateTime));
            dataTable.Columns.Add("Data Prestação", typeof(DateTime));
            dataTable.Columns.Add("Previsão Conclusão", typeof(DateTime));
            dataTable.Columns.Add("Valor Sugerido", typeof(decimal));
            dataTable.Columns.Add("Valor Praticado", typeof(decimal));
            dataTable.Columns.Add("Lucro Bruto", typeof(decimal));
            dataTable.Columns.Add("Serviços", typeof(string));
            dataTable.Columns.Add("Observações", typeof(string));

            foreach (var agendamento in agendamentos)
            {
                var servicosTexto = string.Join(", ", agendamento.Servicos.ConvertAll(s => s.NomeServico));
                
                dataTable.Rows.Add(
                    agendamento.AtendimentoID,
                    agendamento.NomeCliente,
                    $"{agendamento.PlacaVeiculo} - {agendamento.MarcaVeiculo} {agendamento.ModeloVeiculo}",
                    agendamento.Data,
                    agendamento.DataPrestacao,
                    agendamento.PrevisaoConclusao,
                    agendamento.ValorSugerido,
                    agendamento.ValorPraticado,
                    agendamento.LucroBruto,
                    servicosTexto,
                    agendamento.Observacoes
                );
            }

            dataGridAgendamentos.DataSource = dataTable;

            // Configurar formatação das colunas
            if (dataGridAgendamentos.Columns["Data Agendamento"] != null)
                dataGridAgendamentos.Columns["Data Agendamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            
            if (dataGridAgendamentos.Columns["Data Prestação"] != null)
                dataGridAgendamentos.Columns["Data Prestação"].DefaultCellStyle.Format = "dd/MM/yyyy";
            
            if (dataGridAgendamentos.Columns["Previsão Conclusão"] != null)
                dataGridAgendamentos.Columns["Previsão Conclusão"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dataGridAgendamentos.Columns["Valor Sugerido"] != null)
            {
                dataGridAgendamentos.Columns["Valor Sugerido"].DefaultCellStyle.Format = "C2";
                dataGridAgendamentos.Columns["Valor Sugerido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridAgendamentos.Columns["Valor Praticado"] != null)
            {
                dataGridAgendamentos.Columns["Valor Praticado"].DefaultCellStyle.Format = "C2";
                dataGridAgendamentos.Columns["Valor Praticado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridAgendamentos.Columns["Lucro Bruto"] != null)
            {
                dataGridAgendamentos.Columns["Lucro Bruto"].DefaultCellStyle.Format = "C2";
                dataGridAgendamentos.Columns["Lucro Bruto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Ocultar coluna ID
            if (dataGridAgendamentos.Columns["ID"] != null)
                dataGridAgendamentos.Columns["ID"].Visible = false;

            // Ajustar larguras específicas
            if (dataGridAgendamentos.Columns["Cliente"] != null)
                dataGridAgendamentos.Columns["Cliente"].FillWeight = 150;
            
            if (dataGridAgendamentos.Columns["Veículo"] != null)
                dataGridAgendamentos.Columns["Veículo"].FillWeight = 200;
            
            if (dataGridAgendamentos.Columns["Serviços"] != null)
                dataGridAgendamentos.Columns["Serviços"].FillWeight = 200;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridAgendamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um agendamento para editar.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridAgendamentos.SelectedRows[0];
            int atendimentoId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            MessageBox.Show($"Funcionalidade de edição será implementada para o atendimento ID: {atendimentoId}", 
                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Aqui você pode implementar a abertura da tela de edição de atendimentos
            // Por exemplo, abrir o CadAtendimento com os dados carregados
        }

        // Event handler para duplo clique na linha
        private void DataGridAgendamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnEditar_Click(sender, e);
            }
        }
    }
}