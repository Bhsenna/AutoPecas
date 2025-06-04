using System.Diagnostics;
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

        public TelaInicial()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_menu.Controls.Add(leftBorderBtn);

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void ibtn_veiculos_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

            ActivateButton(sender, Color.White);

            MostrarTela(new Cadastros.CadVeiculo());
        }

        //private void ibtn_servicos_Click(object sender, EventArgs e)
        //{
        //    if (sender == currentBtn) return;

        //    ActivateButton(sender, Color.White);
        //}

        private void ibtn_categorias_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;
            
            ActivateButton(sender, Color.White);

            MostrarTela(new Cadastros.CadCategoria());
        }

        private void ibtn_config_Click(object sender, EventArgs e)
        {
            if (sender == currentBtn) return;

            ActivateButton(sender, Color.White);
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
    }
}
