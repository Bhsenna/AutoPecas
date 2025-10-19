using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
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
            
            // Configurar propriedades de renderização do formulário
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | 
                         ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
            
            // Inicializar propriedades primeiro
            this.dataSelecionada = data;
            this.agendamentos = agendamentosData ?? new List<AgendamentoCalendario>();
            
            // Configurar interface
            ConfigurarInterface();
            
            // Carregar dados apenas após a interface estar pronta
            CarregarDados();
        }

        private void ConfigurarInterface()
        {
            // Configurações básicas do formulário
            this.Text = $"Agendamentos - {dataSelecionada.ToString("dd/MM/yyyy", CultureInfo.GetCultureInfo("pt-BR"))}";
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterParent;
            this.MinimumSize = new Size(1000, 500);
            this.WindowState = FormWindowState.Normal;
            
            // Aplicar estilo moderno ao formulário
            Styler.FormStyler.ApplyModernStyle(this);

            // Header moderno
            var panelHeader = Styler.FormStyler.CreateFormHeader(
                $"Agendamentos do dia {dataSelecionada:dd/MM/yyyy}",
                $"{agendamentos.Count} agendamento(s) encontrado(s)",
                120
            );

            // Footer moderno com melhor gerenciamento de layout
            var panelFooter = Styler.FormStyler.CreateFormFooter(90); // Aumentar altura do footer

            // Container para os botões com layout responsivo e melhor alinhamento vertical
            var containerBotoes = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.RightToLeft, // Buttons flow from right to left
                Dock = DockStyle.Fill,
                Padding = new Padding(20, 15, 20, 15), // Aumentar padding para melhor espaçamento
                WrapContents = false,
                AutoSize = false,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left
            };

            // Botão Fechar com melhor espaçamento
            var btnFechar = Styler.FormStyler.CreateActionButton("✕  Fechar", false, new Size(140, 50));
            btnFechar.Margin = new Padding(0, 5, 15, 5); // Margem direita para separar os botões
            btnFechar.Click += (s, e) => this.Close();

            // Botão Editar com melhor espaçamento
            var btnEditar = Styler.FormStyler.CreateActionButton("✏  Editar", true, new Size(190, 50));
            btnEditar.Margin = new Padding(0, 5, 0, 5); // Margem vertical para centralizar
            btnEditar.Click += BtnEditar_Click;

            // Adicionar botões ao container com ordem correta (devido ao RightToLeft)
            containerBotoes.Controls.Add(btnFechar);
            containerBotoes.Controls.Add(btnEditar);
            
            panelFooter.Controls.Add(containerBotoes);

            // Painel de conteúdo moderno
            var panelContent = Styler.FormStyler.CreateContentPanel(25);

            // DataGridView modernizado - Usar versão otimizada com melhor espaçamento
            dataGridAgendamentos = new Styler.OptimizedDataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AllowUserToResizeColumns = true,
                Margin = new Padding(0),
                BorderStyle = BorderStyle.None,
                BackgroundColor = Styler.ModernColors.Background,
                GridColor = Styler.ModernColors.Border,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None, // Evitar problemas de redimensionamento automático
                ScrollBars = ScrollBars.Both,
                EnableHeadersVisualStyles = false,
                RowTemplate = { Height = 65 } // Aumentar altura das linhas para melhor espaçamento
            };

            // Aplicar estilo moderno ao grid
            Styler.EnhancedGridStyler.ApplyModernStyle(dataGridAgendamentos);

            // Adicionar evento de duplo clique
            dataGridAgendamentos.CellDoubleClick += DataGridAgendamentos_CellDoubleClick;

            // Eventos para melhor rendering
            dataGridAgendamentos.ColumnWidthChanged += DataGridAgendamentos_ColumnWidthChanged;
            dataGridAgendamentos.Resize += DataGridAgendamentos_Resize;

            panelContent.Controls.Add(dataGridAgendamentos);

            // Adicionar todos os painéis ao form
            this.Controls.Add(panelContent);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);

            // Adicionar evento de redimensionamento do form
            this.Resize += DetalhesAgendamentoForm_Resize;
        }

        private void DataGridAgendamentos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            // Invalidar o grid para forçar redesenho
            if (dataGridAgendamentos != null && !dataGridAgendamentos.IsDisposed)
            {
                dataGridAgendamentos.Invalidate();
            }
        }

        private void DataGridAgendamentos_Resize(object sender, EventArgs e)
        {
            // Suspender layout durante redimensionamento
            var grid = sender as DataGridView;
            if (grid != null && !grid.IsDisposed)
            {
                grid.SuspendLayout();
                try
                {
                    // Forçar redesenho
                    grid.Invalidate();
                }
                finally
                {
                    grid.ResumeLayout(false);
                }
            }
        }

        private void DetalhesAgendamentoForm_Resize(object sender, EventArgs e)
        {
            // Suspender layout durante redimensionamento
            this.SuspendLayout();
            try
            {
                // Forçar redesenho completo
                this.Invalidate(true);
                
                // Recalcular colunas se necessário
                if (dataGridAgendamentos != null && !dataGridAgendamentos.IsDisposed && dataGridAgendamentos.Columns.Count > 0)
                {
                    AjustarLarguraColunas();
                }
            }
            finally
            {
                this.ResumeLayout(false);
            }
        }

        private void CarregarDados()
        {
            try
            {
                // Verificar se há agendamentos
                if (agendamentos == null || agendamentos.Count == 0)
                {
                    // Criar uma tabela vazia mesmo sem dados
                    var dataTableEmpty = new System.Data.DataTable();
                    CriarEstruturaDaTabela(dataTableEmpty);
                    dataGridAgendamentos.DataSource = dataTableEmpty;
                    ConfigurarColunas();
                    return;
                }

                // Criar DataTable com as colunas necessárias
                var dataTable = new System.Data.DataTable();
                CriarEstruturaDaTabela(dataTable);

                foreach (var agendamento in agendamentos)
                {
                    // Verificar se o agendamento e seus dados não são nulos
                    var servicosTexto = "";
                    if (agendamento.Servicos != null && agendamento.Servicos.Count > 0)
                    {
                        servicosTexto = string.Join(", ", agendamento.Servicos.ConvertAll(s => s?.NomeServico ?? "N/A"));
                    }
                    
                    dataTable.Rows.Add(
                        agendamento.NomeCliente ?? "N/A",
                        $"{agendamento.PlacaVeiculo ?? "N/A"} - {agendamento.MarcaVeiculo ?? "N/A"} {agendamento.ModeloVeiculo ?? "N/A"}",
                        agendamento.Data,
                        agendamento.DataPrestacao,
                        agendamento.PrevisaoConclusao ?? (object)DBNull.Value,
                        agendamento.ValorSugerido,
                        agendamento.ValorPraticado,
                        agendamento.LucroBruto,
                        servicosTexto,
                        agendamento.Observacoes ?? ""
                    );
                }

                // Definir o DataSource
                dataGridAgendamentos.DataSource = dataTable;

                // Configurar formatação das colunas diretamente após o binding
                ConfigurarColunas();
            }
            catch (Exception ex)
            {
                ShowModernMessage($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxIcon.Error);
            }
        }

        private void CriarEstruturaDaTabela(System.Data.DataTable dataTable)
        {
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
        }

        private void ConfigurarColunas()
        {
            // Verificar se o formulário não foi descartado e se o DataGridView existe
            if (this.IsDisposed || this.Disposing || dataGridAgendamentos?.Columns == null || dataGridAgendamentos.Columns.Count == 0)
            {
                return;
            }

            // Verificar se o handle da janela foi criado
            if (!this.IsHandleCreated || !dataGridAgendamentos.IsHandleCreated)
            {
                return;
            }

            try
            {
                // Suspender layout durante configuração
                dataGridAgendamentos.SuspendLayout();

                // Ocultar coluna ID
                //var colunaId = dataGridAgendamentos.Columns["ID"];
                //if (colunaId != null)
                //    colunaId.Visible = false;

                // Formatação de datas com verificação segura
                var colunasDatas = new[] { "Data Agendamento", "Data Prestação", "Previsão Conclusão" };
                foreach (var nomeColuna in colunasDatas)
                {
                    var coluna = dataGridAgendamentos.Columns[nomeColuna];
                    if (coluna?.DefaultCellStyle != null)
                    {
                        coluna.DefaultCellStyle.Format = "dd/MM/yyyy";
                        coluna.Width = 120;
                        coluna.MinimumWidth = 100;
                    }
                }

                // Formatação de valores monetários com verificação segura
                var colunasValores = new[] { "Valor Sugerido", "Valor Praticado", "Lucro Bruto" };
                foreach (var nomeColuna in colunasValores)
                {
                    var coluna = dataGridAgendamentos.Columns[nomeColuna];
                    if (coluna?.DefaultCellStyle != null)
                    {
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        coluna.Width = 130;
                        coluna.MinimumWidth = 110;
                    }
                }

                AjustarLarguraColunas();
            }
            catch (Exception ex)
            {
                // Log do erro geral, mas não mostrar ao usuário para não interromper a experiência
                System.Diagnostics.Debug.WriteLine($"Erro geral em ConfigurarColunas: {ex.Message}");
            }
            finally
            {
                dataGridAgendamentos.ResumeLayout(true);
            }
        }

        private void AjustarLarguraColunas()
        {
            if (dataGridAgendamentos?.Columns == null || dataGridAgendamentos.Columns.Count == 0)
                return;

            try
            {
                // Ajustar larguras específicas com verificação segura
                var colunaCliente = dataGridAgendamentos.Columns["Cliente"];
                if (colunaCliente?.DefaultCellStyle != null)
                {
                    colunaCliente.Width = 150;
                    colunaCliente.MinimumWidth = 120;
                    try
                    {
                        colunaCliente.DefaultCellStyle.Font = Styler.ModernFonts.PrimaryBold;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Erro ao aplicar fonte à coluna Cliente: {ex.Message}");
                    }
                }
                
                var colunaVeiculo = dataGridAgendamentos.Columns["Veículo"];
                if (colunaVeiculo != null)
                {
                    colunaVeiculo.Width = 200;
                    colunaVeiculo.MinimumWidth = 150;
                }
                
                var colunaServicos = dataGridAgendamentos.Columns["Serviços"];
                if (colunaServicos != null)
                {
                    colunaServicos.Width = 180;
                    colunaServicos.MinimumWidth = 120;
                }

                var colunaObservacoes = dataGridAgendamentos.Columns["Observações"];
                if (colunaObservacoes != null)
                {
                    colunaObservacoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    colunaObservacoes.MinimumWidth = 100;
                }

                // Adicionar cores específicas para algumas colunas com verificação segura
                var colunaLucro = dataGridAgendamentos.Columns["Lucro Bruto"];
                if (colunaLucro?.DefaultCellStyle != null)
                {
                    try
                    {
                        colunaLucro.DefaultCellStyle.ForeColor = Styler.ModernColors.Success;
                        colunaLucro.DefaultCellStyle.Font = Styler.ModernFonts.PrimaryBold;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Erro ao aplicar estilo à coluna Lucro Bruto: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao ajustar largura das colunas: {ex.Message}");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridAgendamentos.SelectedRows.Count == 0)
            {
                ShowModernMessage("Selecione um agendamento para editar.", "Aviso", MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridAgendamentos.SelectedRows[0];
            
            // Como removemos a coluna ID, vamos usar o nome do cliente como identificação
            string nomeCliente = selectedRow.Cells["Cliente"].Value?.ToString() ?? "Cliente desconhecido";
            DateTime dataAgendamento = Convert.ToDateTime(selectedRow.Cells["Data Agendamento"].Value);

            ShowModernMessage($"Funcionalidade de edição será implementada para:\nCliente: {nomeCliente}\nData: {dataAgendamento:dd/MM/yyyy}", 
                "Informação", MessageBoxIcon.Information);
        }

        private void DataGridAgendamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnEditar_Click(sender, e);
            }
        }

        /// <summary>
        /// Exibe uma mensagem com estilo moderno
        /// </summary>
        private void ShowModernMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// Override do método Paint para melhorar a renderização
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            // Melhorar qualidade de renderização
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            
            // Remover a borda feia - deixar apenas o fundo limpo
            // using (var pen = new Pen(Styler.ModernColors.Border, 1))
            // {
            //     e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            // }
        }
    }
}