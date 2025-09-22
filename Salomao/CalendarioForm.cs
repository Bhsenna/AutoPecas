using System;
using System.Collections.Generic;
using System.Drawing;
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
            mesAtual = DateTime.Now;
            tipoVisualizacao = TipoVisualizacaoCalendario.Mensal;
            eventosDoMes = new Dictionary<DateTime, EventoCalendario>();
            
            ConfigurarInterface();
            CarregarEventosDoMes();
            AtualizarCalendario();
        }

        private void ConfigurarInterface()
        {
            this.Size = new Size(900, 650);
            this.BackColor = ColorTranslator.FromHtml("#F3F4F6");

            // Panel superior com controles
            var panelSuperior = new Panel
            {
                Height = 60,
                Dock = DockStyle.Top,
                BackColor = ColorTranslator.FromHtml("#1E3A8A"),
                Padding = new Padding(10)
            };

            // Botão mês anterior
            btnMesAnterior = new Button
            {
                Text = "<",
                Size = new Size(40, 40),
                Location = new Point(10, 10),
                BackColor = ColorTranslator.FromHtml("#2563EB"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnMesAnterior.FlatAppearance.BorderSize = 0;
            btnMesAnterior.Click += BtnMesAnterior_Click;

            // Label do mês/ano
            lblMesAno = new Label
            {
                Text = mesAtual.ToString("MMMM yyyy", CultureInfo.GetCultureInfo("pt-BR")),
                Size = new Size(200, 40),
                Location = new Point(60, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold)
            };

            // Botão mês próximo
            btnMesProximo = new Button
            {
                Text = ">",
                Size = new Size(40, 40),
                Location = new Point(270, 10),
                BackColor = ColorTranslator.FromHtml("#2563EB"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnMesProximo.FlatAppearance.BorderSize = 0;
            btnMesProximo.Click += BtnMesProximo_Click;

            // Botão Hoje
            btnHoje = new Button
            {
                Text = "Hoje",
                Size = new Size(60, 40),
                Location = new Point(320, 10),
                BackColor = ColorTranslator.FromHtml("#10B981"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnHoje.FlatAppearance.BorderSize = 0;
            btnHoje.Click += BtnHoje_Click;

            // Botões de visualização
            btnVisualizacaoMensal = new Button
            {
                Text = "Mensal",
                Size = new Size(80, 40),
                Location = new Point(700, 10),
                BackColor = ColorTranslator.FromHtml("#6B7280"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnVisualizacaoMensal.FlatAppearance.BorderSize = 0;
            btnVisualizacaoMensal.Click += BtnVisualizacaoMensal_Click;

            btnVisualizacaoSemanal = new Button
            {
                Text = "Semanal",
                Size = new Size(80, 40),
                Location = new Point(790, 10),
                BackColor = ColorTranslator.FromHtml("#374151"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnVisualizacaoSemanal.FlatAppearance.BorderSize = 0;
            btnVisualizacaoSemanal.Click += BtnVisualizacaoSemanal_Click;

            panelSuperior.Controls.AddRange(new Control[] {
                btnMesAnterior, lblMesAno, btnMesProximo, btnHoje,
                btnVisualizacaoMensal, btnVisualizacaoSemanal
            });

            // Panel do calendário
            panelCalendario = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            this.Controls.Add(panelCalendario);
            this.Controls.Add(panelSuperior);

            AtualizarBotoesVisualizacao();
        }

        private void AtualizarBotoesVisualizacao()
        {
            if (tipoVisualizacao == TipoVisualizacaoCalendario.Mensal)
            {
                btnVisualizacaoMensal.BackColor = ColorTranslator.FromHtml("#2563EB");
                btnVisualizacaoSemanal.BackColor = ColorTranslator.FromHtml("#6B7280");
            }
            else
            {
                btnVisualizacaoMensal.BackColor = ColorTranslator.FromHtml("#6B7280");
                btnVisualizacaoSemanal.BackColor = ColorTranslator.FromHtml("#2563EB");
            }
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
            lblMesAno.Text = mesAtual.ToString("MMMM yyyy", CultureInfo.GetCultureInfo("pt-BR"));
            
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

        private void CriarVisualizacaoMensal()
        {
            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 7,
                RowCount = 7, // 1 linha para cabeçalho + 6 linhas para semanas
                BackColor = Color.White
            };

            // Configurar colunas
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28f));
            }

            // Configurar linhas
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Cabeçalho
            for (int i = 1; i < 7; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67f));
            }

            // Cabeçalho dos dias da semana
            string[] diasSemana = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            for (int i = 0; i < 7; i++)
            {
                var lblDia = new Label
                {
                    Text = diasSemana[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = ColorTranslator.FromHtml("#E5E7EB"),
                    ForeColor = ColorTranslator.FromHtml("#374151"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    BorderStyle = BorderStyle.FixedSingle
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
                    var panelDia = CriarPanelDia(dataAtual, dataAtual.Month == mesAtual.Month);
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
                BackColor = Color.White
            };

            // Configurar colunas
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28f));
            }

            // Configurar linhas
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Cabeçalho
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f)); // Dias

            // Cabeçalho dos dias da semana
            string[] diasSemana = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            for (int i = 0; i < 7; i++)
            {
                var lblDia = new Label
                {
                    Text = diasSemana[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = ColorTranslator.FromHtml("#E5E7EB"),
                    ForeColor = ColorTranslator.FromHtml("#374151"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    BorderStyle = BorderStyle.FixedSingle
                };
                tableLayoutPanel.Controls.Add(lblDia, i, 0);
            }

            // Dias da semana
            for (int dia = 0; dia < 7; dia++)
            {
                DateTime dataAtual = inicioSemana.AddDays(dia);
                var panelDia = CriarPanelDia(dataAtual, true);
                panelDia.Height = 400; // Mais altura para visualização semanal
                tableLayoutPanel.Controls.Add(panelDia, dia, 1);
            }

            panelCalendario.Controls.Add(tableLayoutPanel);
        }

        private Panel CriarPanelDia(DateTime data, bool destacar)
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = destacar ? Color.White : ColorTranslator.FromHtml("#F9FAFB"),
                Padding = new Padding(2),
                Cursor = Cursors.Hand
            };

            // Label do número do dia
            var lblNumero = new Label
            {
                Text = data.Day.ToString(),
                Size = new Size(25, 20),
                Location = new Point(2, 2),
                ForeColor = destacar ? ColorTranslator.FromHtml("#374151") : ColorTranslator.FromHtml("#9CA3AF"),
                Font = new Font("Segoe UI", 10, data.Date == DateTime.Today ? FontStyle.Bold : FontStyle.Regular)
            };

            // Destacar dia atual
            if (data.Date == DateTime.Today)
            {
                lblNumero.BackColor = ColorTranslator.FromHtml("#2563EB");
                lblNumero.ForeColor = Color.White;
                lblNumero.TextAlign = ContentAlignment.MiddleCenter;
            }

            panel.Controls.Add(lblNumero);

            // Adicionar eventos do dia
            if (eventosDoMes.ContainsKey(data.Date))
            {
                var evento = eventosDoMes[data.Date];
                
                var lblEvento = new Label
                {
                    Text = $"{evento.QuantidadeAgendamentos} agend.",
                    Size = new Size(panel.Width - 4, 15),
                    Location = new Point(2, 25),
                    ForeColor = ColorTranslator.FromHtml("#DC2626"),
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    BackColor = ColorTranslator.FromHtml("#FEE2E2"),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                
                panel.Controls.Add(lblEvento);

                // Adicionar descrição resumida se houver espaço
                if (tipoVisualizacao == TipoVisualizacaoCalendario.Semanal || panel.Height > 60)
                {
                    var lblDescricao = new Label
                    {
                        Text = evento.DescricaoResumida,
                        Size = new Size(panel.Width - 4, 30),
                        Location = new Point(2, 42),
                        ForeColor = ColorTranslator.FromHtml("#6B7280"),
                        Font = new Font("Segoe UI", 7),
                        AutoEllipsis = true
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
            var agendamentos = CalendarioService.ObterAgendamentosPorData(data);
            
            if (agendamentos.Count == 0)
            {
                MessageBox.Show($"Nenhum agendamento encontrado para {data:dd/MM/yyyy}.", 
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var detalhesForm = new DetalhesAgendamentoForm(data, agendamentos);
            detalhesForm.ShowDialog();
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
    }
}

