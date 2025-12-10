using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AutoPecas.Models;

namespace AutoPecas
{
    public partial class CalendarioForm : UserControl
    {
        private DateTime mesAtual;
        private TipoVisualizacaoCalendario tipoVisualizacao;
        private Dictionary<DateTime, EventoCalendario> eventosDoMes;
        private Panel panelCalendario;
        private Label lblMesAno;
        private Button btnMesAnterior;
        private Button btnMesProximo;
        private Button btnVisualizacaoSemanal;
        private Button btnVisualizacaoMensal;
        private Button btnHoje;

        public CalendarioForm()
        {
            InitializeComponent();
            
            // Configurar propriedades de renderização
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | 
                    ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
            
            mesAtual = DateTime.Now;
            tipoVisualizacao = TipoVisualizacaoCalendario.Mensal;
            eventosDoMes = new Dictionary<DateTime, EventoCalendario>();
            
            ConfigurarInterface();
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        private void ConfigurarInterface()
        {
            this.BackColor = Styler.ModernColors.Background;
            this.Dock = DockStyle.Fill;
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);

            // Header moderno com gradiente
            var panelSuperior = Styler.CalendarStyler.CreateModernHeader(80);
            panelSuperior.Resize += PanelSuperior_Resize;

            // Botão mês anterior
            btnMesAnterior = Styler.CalendarStyler.CreateModernButton("‹", 
                new Size(50, 45), new Point(25, 17), 
                Styler.ModernColors.Primary, Styler.ModernColors.PrimaryLight);
            btnMesAnterior.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            btnMesAnterior.Click += BtnMesAnterior_Click;

            // Label do mês/ano
            lblMesAno = new Label
            {
                Text = mesAtual.ToString("MMMM yyyy", CultureInfo.GetCultureInfo("pt-BR")),
                Size = new Size(300, 45),
                Location = new Point(90, 17),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Styler.ModernColors.TextOnPrimary,
                Font = Styler.ModernFonts.CalendarHeader,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            // Botão mês próximo
            btnMesProximo = Styler.CalendarStyler.CreateModernButton("›", 
                new Size(50, 45), new Point(405, 17), 
                Styler.ModernColors.Primary, Styler.ModernColors.PrimaryLight);
            btnMesProximo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            btnMesProximo.Click += BtnMesProximo_Click;

            // Botão Hoje
            btnHoje = Styler.CalendarStyler.CreateModernButton("Hoje", 
                new Size(85, 45), new Point(470, 17), 
                Styler.ModernColors.Success, Styler.ModernColors.SuccessLight);
            btnHoje.Click += BtnHoje_Click;

            // Container para botões de visualização
            var containerVisualizacao = new Panel
            {
                Size = new Size(200, 45),
                BackColor = Color.FromArgb(20, 255, 255, 255),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            // Botões de visualização
            btnVisualizacaoMensal = Styler.CalendarStyler.CreateModernToggleButton("Mensal", 
                new Size(95, 45), new Point(0, 0), true);
            btnVisualizacaoMensal.Click += BtnVisualizacaoMensal_Click;

            btnVisualizacaoSemanal = Styler.CalendarStyler.CreateModernToggleButton("Semanal", 
                new Size(95, 45), new Point(100, 0), false);
            btnVisualizacaoSemanal.Click += BtnVisualizacaoSemanal_Click;

            containerVisualizacao.Controls.AddRange(new Control[] { btnVisualizacaoMensal, btnVisualizacaoSemanal });
            panelSuperior.Controls.AddRange(new Control[] { 
                btnMesAnterior, lblMesAno, btnMesProximo, btnHoje, containerVisualizacao 
            });

            // Panel do calendário
            panelCalendario = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Styler.ModernColors.Surface,
                Padding = new Padding(20),
                Margin = new Padding(0)
            };

            this.Controls.Add(panelCalendario);
            this.Controls.Add(panelSuperior);

            AtualizarBotoesVisualizacao();
            
            // Adicionar evento de redimensionamento
            this.Resize += CalendarioForm_Resize;
        }

        private void PanelSuperior_Resize(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            if (panel != null)
            {
                // Reposicionar container de visualização
                var containerVisualizacao = panel.Controls.OfType<Panel>()
                    .FirstOrDefault(p => p.Controls.Count == 2);
                
                if (containerVisualizacao != null)
                {
                    containerVisualizacao.Location = new Point(panel.Width - 225, 17);
                }
            }
        }

        private void CalendarioForm_Resize(object sender, EventArgs e)
        {
            // Suspender layout durante redimensionamento
            this.SuspendLayout();
            
            try
            {
                // Forçar redesenho completo após redimensionamento
                this.Invalidate(true);
                
                // Atualizar calendário se necessário
                if (panelCalendario?.Controls.Count > 0)
                {
                    Application.DoEvents();
                }
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private void AtualizarBotoesVisualizacao()
        {
            Styler.CalendarStyler.UpdateToggleButtonStyle(btnVisualizacaoMensal, 
                tipoVisualizacao == TipoVisualizacaoCalendario.Mensal);
            Styler.CalendarStyler.UpdateToggleButtonStyle(btnVisualizacaoSemanal, 
                tipoVisualizacao == TipoVisualizacaoCalendario.Semanal);
        }

        private void CarregarEventosDoMes()
        {
            DateTime inicioMes = new DateTime(mesAtual.Year, mesAtual.Month, 1);
            DateTime fimMes = inicioMes.AddMonths(1).AddDays(-1);
            
            // Expandir para incluir dias da semana anterior e posterior para visualização completa
            DateTime inicioCalendario = inicioMes.AddDays(-(int)inicioMes.DayOfWeek);
            DateTime fimCalendario = fimMes.AddDays(6 - (int)fimMes.DayOfWeek);

            eventosDoMes = CalendarioService.ObterEventosPorPeriodo(inicioCalendario, fimCalendario);
        }

        private void AtualizarCalendario()
        {
            var cultura = CultureInfo.GetCultureInfo("pt-BR");
            var mesAno = mesAtual.ToString("MMMM yyyy", cultura);
            lblMesAno.Text = char.ToUpper(mesAno[0]) + mesAno.Substring(1);
            
            // Suspender layout durante atualização
            panelCalendario.SuspendLayout();
            
            try
            {
                panelCalendario.Controls.Clear();

                if (tipoVisualizacao == TipoVisualizacaoCalendario.Mensal)
                {
                    CriarVisualizacaoMensal();
                }
                else
                {
                    CriarVisualizacaoSemanal();
                }
            }
            finally
            {
                panelCalendario.ResumeLayout(true);
                panelCalendario.Invalidate();
            }
        }

        private void CriarVisualizacaoMensal()
        {
            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 7,
                RowCount = 7, // 1 linha para cabeçalho + 6 linhas para semanas
                BackColor = Color.Transparent,
                Margin = new Padding(0),
                Padding = new Padding(0),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            // Configurar colunas
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285714f));
            }

            // Configurar linhas
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Cabeçalho
            for (int i = 1; i < 7; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666667f));
            }

            // Cabeçalho dos dias da semana
            string[] diasSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            for (int i = 0; i < 7; i++)
            {
                var lblDia = new Label
                {
                    Text = diasSemana[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Styler.ModernColors.SurfaceElevated,
                    ForeColor = Styler.ModernColors.TextPrimary,
                    Font = Styler.ModernFonts.SubHeader,
                    Margin = new Padding(1)
                };

                tableLayoutPanel.Controls.Add(lblDia, i, 0);
            }

            // Dias do mês
            DateTime inicioMes = new DateTime(mesAtual.Year, mesAtual.Month, 1);
            DateTime inicioCalendario = inicioMes.AddDays(-(int)inicioMes.DayOfWeek);

            for (int semana = 1; semana < 7; semana++)
            {
                for (int dia = 0; dia < 7; dia++)
                {
                    DateTime dataAtual = inicioCalendario.AddDays((semana - 1) * 7 + dia);
                    var panelDia = CriarPanelDiaModerno(dataAtual, dataAtual.Month == mesAtual.Month);
                    tableLayoutPanel.Controls.Add(panelDia, dia, semana);
                }
            }

            panelCalendario.Controls.Add(tableLayoutPanel);
        }

        private void CriarVisualizacaoSemanal()
        {
            // Encontrar o início da semana atual
            DateTime inicioSemana = mesAtual.AddDays(-(int)mesAtual.DayOfWeek);
            
            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 7,
                RowCount = 2, // 1 linha para cabeçalho + 1 linha para dias
                BackColor = Color.Transparent,
                Margin = new Padding(0),
                Padding = new Padding(0),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            // Configurar colunas
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285714f));
            }

            // Configurar linhas
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Cabeçalho
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f)); // Dias

            // Cabeçalho dos dias da semana
            string[] diasSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            for (int i = 0; i < 7; i++)
            {
                var dataAtual = inicioSemana.AddDays(i);
                var lblDia = new Label
                {
                    Text = $"{diasSemana[i]}\n{dataAtual.Day}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Styler.ModernColors.SurfaceElevated,
                    ForeColor = Styler.ModernColors.TextPrimary,
                    Font = Styler.ModernFonts.Primary,
                    Margin = new Padding(1)
                };

                tableLayoutPanel.Controls.Add(lblDia, i, 0);
            }

            // Dias da semana
            for (int dia = 0; dia < 7; dia++)
            {
                DateTime dataAtual = inicioSemana.AddDays(dia);
                var panelDia = CriarPanelDiaModerno(dataAtual, true);
                tableLayoutPanel.Controls.Add(panelDia, dia, 1);
            }

            panelCalendario.Controls.Add(tableLayoutPanel);
        }

        private Panel CriarPanelDiaModerno(DateTime data, bool destacar)
        {
            var panel = Styler.CalendarStyler.CreateDayPanel(data, destacar);
            panel.AutoScroll = false; // Desabilitar scroll automático
            panel.Padding = new Padding(4, 4, 4, 4);

            // Label do número do dia
            var lblNumero = Styler.CalendarStyler.CreateDayLabel(data, destacar);
            panel.Controls.Add(lblNumero);

            // Adicionar eventos do dia
            if (eventosDoMes.ContainsKey(data.Date))
            {
                var evento = eventosDoMes[data.Date];
                CriarListaAgendamentos(panel, evento, data);
            }

            // Event handler para clique no dia
            panel.Click += (s, e) => AbrirDetalhesAgendamento(data);
            lblNumero.Click += (s, e) => AbrirDetalhesAgendamento(data);

            return panel;
        }

        private void AbrirDetalhesAgendamento(DateTime data)
        {
            try
            {
                var agendamentos = CalendarioService.ObterAgendamentosPorData(data);
                
                if (agendamentos.Count == 0)
                {
                    MessageBox.Show($"Nenhum agendamento encontrado para {data:dd/MM/yyyy}.", 
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Usar using para garantir que o form seja descartado corretamente
                using (var detalhesForm = new DetalhesAgendamentoForm(data, agendamentos))
                {
                    detalhesForm.ShowDialog(this.FindForm());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir detalhes do agendamento: {ex.Message}", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Event Handlers

        private void BtnMesAnterior_Click(object sender, EventArgs e)
        {
            if (tipoVisualizacao == TipoVisualizacaoCalendario.Mensal)
            {
                mesAtual = mesAtual.AddMonths(-1);
            }
            else
            {
                mesAtual = mesAtual.AddDays(-7);
            }
            
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        private void BtnMesProximo_Click(object sender, EventArgs e)
        {
            if (tipoVisualizacao == TipoVisualizacaoCalendario.Mensal)
            {
                mesAtual = mesAtual.AddMonths(1);
            }
            else
            {
                mesAtual = mesAtual.AddDays(7);
            }
            
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        private void BtnHoje_Click(object sender, EventArgs e)
        {
            mesAtual = DateTime.Now;
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        private void BtnVisualizacaoMensal_Click(object sender, EventArgs e)
        {
            tipoVisualizacao = TipoVisualizacaoCalendario.Mensal;
            AtualizarBotoesVisualizacao();
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        private void BtnVisualizacaoSemanal_Click(object sender, EventArgs e)
        {
            tipoVisualizacao = TipoVisualizacaoCalendario.Semanal;
            AtualizarBotoesVisualizacao();
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        #endregion

        /// <summary>
        /// Método público para atualizar o calendário quando houver mudanças nos agendamentos
        /// </summary>
        public void AtualizarEventos()
        {
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            // Melhorar qualidade de renderização
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        }

        /// <summary>
        /// Cria a lista de agendamentos dentro do painel do dia
        /// </summary>
        private void CriarListaAgendamentos(Panel panelDia, EventoCalendario evento, DateTime data)
        {
            if (evento == null || evento.Agendamentos == null || evento.Agendamentos.Count == 0)
                return;

            try
            {
                // Calcular espaço disponível (descontando o espaço do número do dia)
                int espacoDisponivel = panelDia.Height - 28; // Reduzir margem superior
                int alturaLinha = 20; // Aumentar altura das linhas para não cortar o texto
                int maxLinhas = Math.Max(1, espacoDisponivel / alturaLinha);

                // Posição inicial Y (abaixo do número do dia)
                int posY = 26;

                // Verificar se é visualização semanal para permitir mais espaço
                bool isVisualizacaoSemanal = tipoVisualizacao == TipoVisualizacaoCalendario.Semanal;
                if (isVisualizacaoSemanal)
                {
                    maxLinhas = Math.Max(15, maxLinhas); // Permitir mais linhas na visualização semanal
                    alturaLinha = 22; // Mais espaço na visualização semanal
                }

                // Lista dos agendamentos a exibir
                var agendamentosParaExibir = evento.Agendamentos.Take(maxLinhas - 1).ToList();
                bool temMaisAgendamentos = evento.Agendamentos.Count > agendamentosParaExibir.Count;

                // Se há mais agendamentos do que o espaço permite, ajustar a lista
                if (temMaisAgendamentos && maxLinhas > 1)
                {
                    agendamentosParaExibir = evento.Agendamentos.Take(maxLinhas - 1).ToList();
                }

                // Criar labels para cada agendamento com altura adequada
                for (int i = 0; i < agendamentosParaExibir.Count; i++)
                {
                    var agendamento = agendamentosParaExibir[i];
                    
                    // Calcular largura disponível
                    int larguraDisponivel = Math.Max(60, panelDia.Width - 12);
                    
                    var lblAgendamento = new Label
                    {
                        Text = TruncarTexto(agendamento.NomeCliente ?? "Cliente", larguraDisponivel, new Font("Segoe UI", 8.5F)),
                        AutoSize = false,
                        Size = new Size(larguraDisponivel, alturaLinha), // Altura completa sem subtração
                        Location = new Point(6, posY + (i * alturaLinha)),
                        ForeColor = Styler.ModernColors.TextSecondary,
                        Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleLeft, // Centralizar verticalmente o texto
                        Cursor = Cursors.Hand,
                        Tag = agendamento,
                        Padding = new Padding(0) // Remover padding que pode interferir
                    };

                    // Adicionar hover effect
                    lblAgendamento.MouseEnter += (s, e) => {
                        lblAgendamento.BackColor = Color.FromArgb(40, Styler.ModernColors.Primary.R, 
                            Styler.ModernColors.Primary.G, Styler.ModernColors.Primary.B);
                        lblAgendamento.ForeColor = Styler.ModernColors.Primary;
                        
                        // Mostrar tooltip
                        var tooltip = new ToolTip();
                        tooltip.SetToolTip(lblAgendamento, 
                            $"Cliente: {agendamento.NomeCliente}\n" +
                            $"Veículo: {agendamento.PlacaVeiculo} - {agendamento.MarcaVeiculo} {agendamento.ModeloVeiculo}\n" +
                            $"Valor: {agendamento.ValorPraticado:C2}");
                    };

                    lblAgendamento.MouseLeave += (s, e) => {
                        lblAgendamento.BackColor = Color.Transparent;
                        lblAgendamento.ForeColor = Styler.ModernColors.TextSecondary;
                    };

                    // Adicionar clique no agendamento
                    lblAgendamento.Click += (s, e) => AbrirDetalhesAgendamento(data);

                    panelDia.Controls.Add(lblAgendamento);
                }

                // Adicionar label "..." se há mais agendamentos
                if (temMaisAgendamentos)
                {
                    var lblMais = new Label
                    {
                        Text = $"... (+{evento.Agendamentos.Count - agendamentosParaExibir.Count})",
                        AutoSize = false,
                        Size = new Size(Math.Max(60, panelDia.Width - 12), alturaLinha),
                        Location = new Point(6, posY + (agendamentosParaExibir.Count * alturaLinha)),
                        ForeColor = Styler.ModernColors.TextMuted,
                        Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Cursor = Cursors.Hand,
                        Padding = new Padding(0)
                    };

                    lblMais.MouseEnter += (s, e) => {
                        lblMais.BackColor = Color.FromArgb(30, Styler.ModernColors.Warning.R, 
                            Styler.ModernColors.Warning.G, Styler.ModernColors.Warning.B);
                        lblMais.ForeColor = Styler.ModernColors.Warning;
                    };

                    lblMais.MouseLeave += (s, e) => {
                        lblMais.BackColor = Color.Transparent;
                        lblMais.ForeColor = Styler.ModernColors.TextMuted;
                    };

                    lblMais.Click += (s, e) => AbrirDetalhesAgendamento(data);
                    panelDia.Controls.Add(lblMais);
                }

                // Se não há agendamentos visíveis mas há agendamentos, mostrar apenas contador
                if (agendamentosParaExibir.Count == 0 && evento.Agendamentos.Count > 0)
                {
                    var lblContador = new Label
                    {
                        Text = $"{evento.Agendamentos.Count} agendamento(s)",
                        AutoSize = false,
                        Size = new Size(Math.Max(60, panelDia.Width - 12), alturaLinha),
                        Location = new Point(6, posY),
                        ForeColor = Styler.ModernColors.CalendarEventText,
                        Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                        BackColor = Styler.ModernColors.CalendarEvent,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand,
                        Padding = new Padding(0)
                    };

                    lblContador.Click += (s, e) => AbrirDetalhesAgendamento(data);
                    panelDia.Controls.Add(lblContador);
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, mostrar um indicador simples
                var lblErro = new Label
                {
                    Text = $"{evento.Agendamentos.Count} agend.",
                    AutoSize = false,
                    Size = new Size(Math.Max(60, panelDia.Width - 12), 20),
                    Location = new Point(6, 26),
                    ForeColor = Styler.ModernColors.Error,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(0)
                };
                
                lblErro.Click += (s, e) => AbrirDetalhesAgendamento(data);
                panelDia.Controls.Add(lblErro);
                
                System.Diagnostics.Debug.WriteLine($"Erro ao criar lista de agendamentos: {ex.Message}");
            }
        }

        /// <summary>
        /// Trunca o texto se necessário e adiciona reticências
        /// </summary>
        private string TruncarTexto(string texto, int larguraDisponivel, Font font)
        {
            if (string.IsNullOrEmpty(texto))
                return "";

            try
            {
                // Usar Graphics para medir o texto
                using (var g = this.CreateGraphics())
                {
                    var tamanhoTexto = g.MeasureString(texto, font);
                    
                    // Se o texto cabe, retornar como está
                    if (tamanhoTexto.Width <= larguraDisponivel)
                        return texto;

                    // Caso contrário, truncar e adicionar reticências
                    var reticencias = "...";
                    var tamanhoReticencias = g.MeasureString(reticencias, font);
                    var larguraParaTexto = larguraDisponivel - tamanhoReticencias.Width;

                    if (larguraParaTexto <= 0)
                        return reticencias;

                    // Encontrar quantos caracteres cabem
                    for (int i = texto.Length - 1; i > 0; i--)
                    {
                        var textoTruncado = texto.Substring(0, i);
                        var tamanhoTruncado = g.MeasureString(textoTruncado, font);
                        
                        if (tamanhoTruncado.Width <= larguraParaTexto)
                        {
                            return textoTruncado + reticencias;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Em caso de erro, fazer truncamento simples
                if (texto.Length > 12)
                    return texto.Substring(0, 9) + "...";
            }

            return texto;
        }
    }
}

