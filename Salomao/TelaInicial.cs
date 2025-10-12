using System.Diagnostics;
using System.Linq;
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

        public TelaInicial()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_menu.Controls.Add(leftBorderBtn);

            // Verificar se o botão calendário existe, se não, criar
            VerificarBotaoCalendario();

            // Form
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(30, 58, 138);//Border color
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
            AdjustForm();
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
    }
}
