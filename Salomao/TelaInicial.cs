using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using ClosedXML.Excel;
using FontAwesome.Sharp;
//using Salomao.Forms;

namespace Salomao
{
    public partial class TelaInicial : Form
    {
        // Fields
        private UserControl telaAtiva = null;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private int borderSize = 2;
        private Size formSize;

        // 720p HD minimum size constants
        private const int MIN_WIDTH = 1280;
        private const int MIN_HEIGHT = 720;

        // Campos para barra lateral retrátil
        private bool sidebarCollapsed = false;
        private const int SIDEBAR_WIDTH_EXPANDED = 239;
        private const int SIDEBAR_WIDTH_COLLAPSED = 60;
        private Button btnToggleSidebar;

        public TelaInicial()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_menu.Controls.Add(leftBorderBtn);

            // Verificar se o botão calendário existe, se não, criar
            VerificarBotaoCalendario();

            // Adicionar botão toggle para sidebar
            AdicionarBotaoToggleSidebar();

            // Form - Set proper minimum size for 720p HD resolution
            this.MinimumSize = new Size(MIN_WIDTH, MIN_HEIGHT);
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(30, 58, 138);//Border color

            // Ensure initial size is at least 720p
            if (this.Size.Width < MIN_WIDTH || this.Size.Height < MIN_HEIGHT)
            {
                this.Size = new Size(Math.Max(MIN_WIDTH, this.Size.Width),
                                   Math.Max(MIN_HEIGHT, this.Size.Height));
            }

            // Start in center with proper size
            this.StartPosition = FormStartPosition.CenterScreen;

            // Remover o panel_shadow feio
            RemoverPanelShadow();
        }

        private void RemoverPanelShadow()
        {
            // O panel_shadow já foi removido do Designer, então apenas precisamos
            // ajustar o panel_desktop para ocupar todo o espaço
            if (panel_desktop != null)
            {
                panel_desktop.Location = new Point(panel_menu.Width, panel_header.Height);
                panel_desktop.Size = new Size(this.Width - panel_menu.Width - borderSize * 2,
                                             this.Height - panel_header.Height - borderSize * 2);
            }
        }

        private void AdicionarBotaoToggleSidebar()
        {
            // Remover o botão antigo do header se existir
            if (btnToggleSidebar != null)
            {
                panel_header.Controls.Remove(btnToggleSidebar);
            }

            // Criar botão toggle moderno na borda da sidebar
            btnToggleSidebar = new Button
            {
                Size = new Size(20, 80), // Botão vertical mais elegante
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(40, 70, 150), // Cor sutilmente diferente da sidebar
                ForeColor = Color.FromArgb(220, 220, 220),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Text = "◀", // Seta apontando para a esquerda (colapsar)
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                UseVisualStyleBackColor = false
            };

            // Posicionar na borda direita da sidebar, verticalmente centralizado
            PositionarBotaoToggle();

            // Estilo moderno sem bordas
            btnToggleSidebar.FlatAppearance.BorderSize = 0;
            btnToggleSidebar.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 100, 180);

            // Adicionar efeitos hover suaves
            btnToggleSidebar.MouseEnter += (s, e) =>
            {
                btnToggleSidebar.BackColor = Color.FromArgb(60, 100, 180);
                btnToggleSidebar.ForeColor = Color.White;
            };

            btnToggleSidebar.MouseLeave += (s, e) =>
            {
                btnToggleSidebar.BackColor = Color.FromArgb(40, 70, 150);
                btnToggleSidebar.ForeColor = Color.FromArgb(220, 220, 220);
            };

            // Adicionar cantos arredondados visuais
            btnToggleSidebar.Paint += (s, e) =>
            {
                var btn = s as Button;
                var rect = btn.ClientRectangle;

                // Desenhar fundo com cantos arredondados apenas do lado direito
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 8;
                    path.AddLine(0, 0, rect.Width - radius, 0);
                    path.AddArc(rect.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                    path.AddLine(rect.Width - radius, rect.Height, 0, rect.Height);
                    path.AddLine(0, rect.Height, 0, 0);

                    btn.Region = new Region(path);
                }
            };

            btnToggleSidebar.Click += BtnToggleSidebar_Click;

            // Adicionar ao form principal, não ao panel_header
            this.Controls.Add(btnToggleSidebar);
            btnToggleSidebar.BringToFront();
        }

        private void PositionarBotaoToggle()
        {
            if (btnToggleSidebar == null) return;

            // Calcular posição: na borda direita da sidebar, centralizado verticalmente
            int sidebarWidth = sidebarCollapsed ? SIDEBAR_WIDTH_COLLAPSED : SIDEBAR_WIDTH_EXPANDED;
            int centroVertical = panel_header.Height + (this.Height - panel_header.Height) / 2;

            btnToggleSidebar.Location = new Point(
                sidebarWidth - 1, // Posição na borda direita da sidebar
                centroVertical - btnToggleSidebar.Height / 2 // Centralizado verticalmente
            );
        }

        private void BtnToggleSidebar_Click(object sender, EventArgs e)
        {
            AnimateSidebar();
        }

        private void AnimateSidebar()
        {
            // Toggle estado
            sidebarCollapsed = !sidebarCollapsed;

            int targetWidth = sidebarCollapsed ? SIDEBAR_WIDTH_COLLAPSED : SIDEBAR_WIDTH_EXPANDED;

            // Suspender layout durante animação
            this.SuspendLayout();

            try
            {
                // Animar o painel do menu
                panel_menu.Width = targetWidth;

                // Ajustar posição do botão toggle
                PositionarBotaoToggle();

                // Esconder/mostrar texto dos botões
                foreach (Control control in panel_menu.Controls)
                {
                    if (control is IconButton iconBtn)
                    {
                        if (sidebarCollapsed)
                        {
                            // Modo colapsado - apenas ícones
                            iconBtn.Text = "";
                            iconBtn.ImageAlign = ContentAlignment.MiddleCenter;
                            iconBtn.TextAlign = ContentAlignment.MiddleCenter;
                            iconBtn.TextImageRelation = TextImageRelation.Overlay;
                            iconBtn.Size = new Size(targetWidth - 8, 60);
                        }
                        else
                        {
                            // Modo expandido - ícones + texto
                            RestaurarTextoOriginalBotao(iconBtn);
                            iconBtn.ImageAlign = ContentAlignment.MiddleLeft;
                            iconBtn.TextAlign = ContentAlignment.MiddleLeft;
                            iconBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                            iconBtn.Size = new Size(targetWidth - 8, 60);
                        }
                    }
                }

                // Ajustar panel_desktop
                panel_desktop.Location = new Point(targetWidth, panel_header.Height);
                panel_desktop.Size = new Size(this.Width - targetWidth - borderSize * 2,
                                             this.Height - panel_header.Height - borderSize * 2);

                // Atualizar ícone do botão toggle
                btnToggleSidebar.Text = sidebarCollapsed ? "▶" : "◀";
            }
            finally
            {
                this.ResumeLayout(true);
                this.Invalidate();
            }
        }

        private void RestaurarTextoOriginalBotao(IconButton iconBtn)
        {
            // Restaurar texto original baseado no nome do botão
            switch (iconBtn.Name)
            {
                case "ibtn_produtos": iconBtn.Text = "Produtos"; break;
                case "ibtn_clientes": iconBtn.Text = "Clientes"; break;
                case "ibtn_categorias": iconBtn.Text = "Categorias"; break;
                case "ibtn_fornecedor": iconBtn.Text = "Fornecedores"; break;
                case "ibtn_servico": iconBtn.Text = "Serviços"; break;
                case "ibtn_atendimentos": iconBtn.Text = "Atendimentos"; break;
                case "ibtn_movEstoque": iconBtn.Text = "Mov. Estoque"; break;
                case "ibtn_saldoEstoque": iconBtn.Text = "Saldo Estoque"; break;
                case "ibtn_calendario": iconBtn.Text = "Calendário"; break;
                case "ibtn_config": iconBtn.Text = "Configurações"; break;
                case "ibtn_logout": iconBtn.Text = "Log Out"; break;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void MostrarTela(UserControl novaTela)
        {
            // Remove controle anterior
            if (telaAtiva != null)
            {
                panel_desktop.Controls.Remove(telaAtiva);
                telaAtiva.Dispose();
            }

            // Configura novo controle
            panel_desktop.Controls.Add(novaTela);

            novaTela.Dock = DockStyle.Fill;
            novaTela.BringToFront();
            novaTela.AutoScroll = true;
            novaTela.AutoSize = true;
            novaTela.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            novaTela.BackColor = SystemColors.ActiveBorder;
            novaTela.Dock = DockStyle.Fill;
            novaTela.Location = new Point(0, 0);
            novaTela.Name = "ucProd";
            novaTela.Size = new Size(900, 500);
            novaTela.TabIndex = 0;

            telaAtiva = novaTela;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = ColorTranslator.FromHtml("#2563EB");
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon current form
                icon_current.IconChar = currentBtn.IconChar;
                icon_current.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                // Button
                currentBtn.BackColor = ColorTranslator.FromHtml("#1E3A8A");
                currentBtn.ForeColor = ColorTranslator.FromHtml("#D1D5DB");
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = ColorTranslator.FromHtml("#D1D5DB");
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn = null;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ibtn_produtos_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

            ActivateButton(sender, Color.White);

            MostrarTela(new Cadastros.CadProduto());
        }

        private void ibtn_clientes_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

            ActivateButton(sender, Color.White);

            MostrarTela(new Cadastros.CadCliente());
        }

        private void ibtn_categorias_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

            ActivateButton(sender, Color.White);

            MostrarTela(new Cadastros.CadCategoria());
        }

        private void ibtn_fornecedor_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

            ActivateButton(sender, Color.White);

            MostrarTela(new Cadastros.CadFornecedor());
        }

        private void ibtn_servico_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

            ActivateButton(sender, Color.White);

            MostrarTela(new Cadastros.CadServicos());
        }

        private void ibtn_config_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

        }

        private void ibtn_logout_Click(object sender, EventArgs e)
        {
            //Voltar pra tela de Login
            var login = new Login();

            login.Show();

            this.Dispose();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // Remove controle anterior
            if (telaAtiva != null)
            {
                panel_desktop.Controls.Remove(telaAtiva);
                telaAtiva.Dispose();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icon_current.IconChar = IconChar.House;
            icon_current.IconColor = ColorTranslator.FromHtml("#D1D5DB");
            lbl_title.Text = "Home";
        }

        private void ibtn_atendimentos_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;
            ActivateButton(sender, Color.White);
            MostrarTela(new Cadastros.CadAtendimento());
        }
        private void ibtn_movEstoque_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;
            ActivateButton(sender, Color.White);
            MostrarTela(new Cadastros.MovimentoEstoque());
        }
        private void ibtn_saldoEstoque_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;
            ActivateButton(sender, Color.White);
            MostrarTela(new Cadastros.SaldoEstoque());
        }

        private void VerificarBotaoCalendario()
        {
            // Verificar se o botão calendário já existe
            var botaoExistente = panel_menu.Controls.OfType<FontAwesome.Sharp.IconButton>()
                .FirstOrDefault(b => b.Name == "ibtn_calendario");

            if (botaoExistente == null)
            {
                // Criar o botão calendário se não existir
                var ibtn_calendario = new FontAwesome.Sharp.IconButton
                {
                    Name = "ibtn_calendario",
                    Text = "Calendário",
                    IconChar = FontAwesome.Sharp.IconChar.Calendar,
                    IconColor = Color.FromArgb(209, 213, 219),
                    IconFont = FontAwesome.Sharp.IconFont.Auto,
                    IconSize = 32,
                    ForeColor = Color.FromArgb(209, 213, 219),
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point),
                    Size = new Size(216, 60),
                    Location = new Point(3, 673),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 20, 0),
                    UseVisualStyleBackColor = true,
                    TabIndex = 15
                };

                ibtn_calendario.FlatAppearance.BorderSize = 0;
                ibtn_calendario.Click += ibtn_calendario_Click;

                // Adicionar o botão ao menu
                panel_menu.Controls.Add(ibtn_calendario);
                ibtn_calendario.BringToFront();
            }
        }

        private void ibtn_calendario_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;
            ActivateButton(sender, Color.White);
            MostrarTela(new CalendarioForm());
        }

        private void TelaInicial_Resize(object sender, EventArgs e)
        {
            // Ensure minimum size during resize
            if (this.WindowState == FormWindowState.Normal)
            {
                if (this.Width < MIN_WIDTH || this.Height < MIN_HEIGHT)
                {
                    this.Size = new Size(Math.Max(MIN_WIDTH, this.Width),
                                       Math.Max(MIN_HEIGHT, this.Height));
                }
            }

            AdjustForm();
            AjustarLayoutSemSombra();
        }

        private void AjustarLayoutSemSombra()
        {
            // Ajustar o panel_desktop para funcionar sem o panel_shadow
            if (panel_desktop != null && panel_menu != null && panel_header != null)
            {
                int menuWidth = sidebarCollapsed ? SIDEBAR_WIDTH_COLLAPSED : SIDEBAR_WIDTH_EXPANDED;

                panel_desktop.Location = new Point(menuWidth, panel_header.Height);
                panel_desktop.Size = new Size(this.Width - menuWidth - borderSize * 2,
                                             this.Height - panel_header.Height - borderSize * 2);
            }

            // Ajustar posição do botão toggle se existir
            if (btnToggleSidebar != null)
            {
                PositionarBotaoToggle();
            }
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            // Enforce minimum size constraints
            if (width < MIN_WIDTH) width = MIN_WIDTH;
            if (height < MIN_HEIGHT) height = MIN_HEIGHT;

            base.SetBoundsCore(x, y, width, height, specified);
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                // Simulação de dados — pode vir do seu banco de dados
                DataTable dt = new DataTable();
                dt.Columns.Add("Data", typeof(DateTime));
                dt.Columns.Add("Cliente", typeof(string));
                //dt.Columns.Add("Servico", typeof(string));
                dt.Columns.Add("Valor", typeof(decimal));
                //dt.Columns.Add("FormaPagamento", typeof(string));
                dt.Columns.Add("Observações", typeof(string));

                using (SQLiteConnection con = BancoSQLite.GetConnection())
                {
                    string query = @"SELECT A.Data as Data,
                                            C.NomeCliente as Cliente,
                                            A.ValorPraticado,
                                            A.LucroBruto as Valor,
                                            A.Observacoes as Observações
                                     FROM Atendimentos A
                                     LEFT JOIN Clientes C ON C.ClienteID = A.ClienteID
                                     LEFT JOIN Veiculos V ON V.VeiculoID = A.VeiculoID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                //dt.Rows.Add(DateTime.Now.AddDays(-5), "João da Silva", "Troca de óleo", 150.00m, "Cartão");
                //dt.Rows.Add(DateTime.Now.AddDays(-3), "Maria Souza", "Alinhamento", 100.00m, "Dinheiro");
                //dt.Rows.Add(DateTime.Now.AddDays(-1), "Carlos Santos", "Revisão completa", 400.00m, "Pix");

                // Caminho do arquivo (pode abrir um SaveFileDialog também)
                string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                              $"Relatorio_Faturamento_{DateTime.Now:yyyy_MM}.xlsx");

                // Criação da planilha
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Faturamento");

                    // Cabeçalho
                    ws.Cell("A1").Value = "Relatório de Faturamento Mensal";
                    ws.Cell("A2").Value = $"Gerado em: {DateTime.Now:dd/MM/yyyy}";
                    ws.Cell("A1").Style.Font.Bold = true;
                    ws.Cell("A1").Style.Font.FontSize = 16;
                    ws.Range("A1:E1").Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Inserindo os dados a partir da linha 4
                    ws.Cell(4, 1).InsertTable(dt, "TabelaFaturamento", true);

                    // Estilizando cabeçalhos
                    var headerRange = ws.Range("A4:E4");
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Ajusta largura automática
                    ws.Columns().AdjustToContents();

                    // Totalizador
                    int ultimaLinha = 4 + dt.Rows.Count;
                    ws.Cell(ultimaLinha + 1, 4).Value = "Total:";
                    ws.Cell(ultimaLinha + 1, 5).FormulaA1 = $"=SUM(E5:E{ultimaLinha})";
                    ws.Cell(ultimaLinha + 1, 4).Style.Font.Bold = true;
                    ws.Cell(ultimaLinha + 1, 5).Style.Font.Bold = true;

                    // Salvar arquivo
                    wb.SaveAs(caminho);
                }

                MessageBox.Show($"Relatório gerado com sucesso!\n{caminho}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
