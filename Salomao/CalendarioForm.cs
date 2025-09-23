using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Salomao.Models;

namespace Salomao
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

            // Label do número do dia
            var lblNumero = Styler.CalendarStyler.CreateDayLabel(data, destacar);
            panel.Controls.Add(lblNumero);

            // Adicionar eventos do dia
            if (eventosDoMes.ContainsKey(data.Date))
            {
                var evento = eventosDoMes[data.Date];
                
                var lblEvento = Styler.CalendarStyler.CreateEventLabel(
                    $"{evento.QuantidadeAgendamentos} agend.", 28);
                panel.Controls.Add(lblEvento);

                // Adicionar descrição resumida se houver espaço
                if (tipoVisualizacao == TipoVisualizacaoCalendario.Semanal || panel.Height > 60)
                {
                    var lblDescricao = new Label
                    {
                        Text = evento.DescricaoResumida,
                        AutoSize = false,
                        Size = new Size(Math.Max(1, panel.Width - 8), 40),
                        Location = new Point(4, 48),
                        ForeColor = Styler.ModernColors.TextSecondary,
                        Font = Styler.ModernFonts.Small,
                        AutoEllipsis = true,
                        BackColor = Color.Transparent
                    };
                    
                    panel.Controls.Add(lblDescricao);
                }
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
    }
}

