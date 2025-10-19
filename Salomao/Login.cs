using System.Data.SQLite;
using Salomao.Cadastros;
using Salomao.Security;
using System.Drawing.Drawing2D;

namespace Salomao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CustomizeComponents();
        }

        private void CustomizeComponents()
        {
            // Aplicar cantos arredondados ao formulário
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Estilizar painel esquerdo com gradiente
            panel_LeftSide.Paint += Panel_LeftSide_Paint;

            // Estilizar campos de entrada
            CustomizeInputPanel(panel_UsernameInput);
            CustomizeInputPanel(panel_PasswordInput);

            // Estilizar botão de login
            CustomizeLoginButton();

            // Efeitos de foco nos campos de texto
            txt_usuario.Enter += (s, e) => AnimateInputFocus(panel_UsernameInput, true);
            txt_usuario.Leave += (s, e) => AnimateInputFocus(panel_UsernameInput, false);
            txt_senha.Enter += (s, e) => AnimateInputFocus(panel_PasswordInput, true);
            txt_senha.Leave += (s, e) => AnimateInputFocus(panel_PasswordInput, false);
        }

        private void Panel_LeftSide_Paint(object sender, PaintEventArgs e)
        {
            var rect = panel_LeftSide.ClientRectangle;
            using (var brush = new LinearGradientBrush(rect,
                Styler.ModernColors.Primary,
                Styler.ModernColors.PrimaryDark,
                LinearGradientMode.Vertical))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, rect);
            }

            // Adicionar círculos decorativos
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var circleBrush = new SolidBrush(Color.FromArgb(30, 255, 255, 255)))
            {
                e.Graphics.FillEllipse(circleBrush, -100, -100, 300, 300);
                e.Graphics.FillEllipse(circleBrush, 250, 400, 250, 250);
            }
        }

        private void CustomizeInputPanel(Panel panel)
        {
            panel.BackColor = Styler.ModernColors.Surface;
            panel.Paint += (s, e) =>
            {
                var p = s as Panel;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Desenhar fundo branco
                using (var backgroundBrush = new SolidBrush(Color.White))
                {
                    var rect = new Rectangle(0, 0, p.Width, p.Height);
                    using (var path = Styler.GetRoundedRectangle(rect, 8))
                    {
                        e.Graphics.FillPath(backgroundBrush, path);
                    }
                }

                // Desenhar borda
                using (var pen = new Pen(Styler.ModernColors.Border, 2))
                {
                    var rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
                    using (var path = Styler.GetRoundedRectangle(rect, 8))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }

        private void AnimateInputFocus(Panel panel, bool focused)
        {
            panel.Invalidate();
            panel.Paint += (s, e) =>
            {
                var p = s as Panel;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                var borderColor = focused ? Styler.ModernColors.Primary : Styler.ModernColors.Border;
                var borderWidth = 2;

                // Desenhar fundo branco
                using (var backgroundBrush = new SolidBrush(Color.White))
                {
                    var rect = new Rectangle(0, 0, p.Width, p.Height);
                    using (var path = Styler.GetRoundedRectangle(rect, 8))
                    {
                        e.Graphics.FillPath(backgroundBrush, path);
                    }
                }

                // Desenhar borda
                using (var pen = new Pen(borderColor, borderWidth))
                {
                    var rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
                    using (var path = Styler.GetRoundedRectangle(rect, 8))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }

        private void CustomizeLoginButton()
        {
            // Aplicar cantos arredondados
            btn_login.Paint += (s, e) =>
            {
                var btn = s as Button;
                var rect = btn.ClientRectangle;
                using (var buttonPath = Styler.GetRoundedRectangle(rect, 8))
                {
                    btn.Region = new Region(buttonPath);

                    // Adicionar gradiente sutil
                    using (var brush = new LinearGradientBrush(rect,
                        Styler.ModernColors.Primary,
                        Styler.ModernColors.PrimaryDark,
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        e.Graphics.FillPath(brush, buttonPath);
                    }

                    // Desenhar texto
                    var sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    using (var textBrush = new SolidBrush(btn.ForeColor))
                    {
                        e.Graphics.DrawString(btn.Text, btn.Font, textBrush, rect, sf);
                    }
                }
            };

            // Efeito hover
            btn_login.MouseEnter += (s, e) =>
            {
                btn_login.BackColor = Styler.ModernColors.PrimaryLight;
                btn_login.Invalidate();
            };

            btn_login.MouseLeave += (s, e) =>
            {
                btn_login.BackColor = Styler.ModernColors.Primary;
                btn_login.Invalidate();
            };
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            lbl_mensagem.Visible = false;
            btn_login.Enabled = false;
            var originalText = btn_login.Text;
            btn_login.Text = "Autenticando...";

            await Task.Delay(300);

            string usuario = txt_usuario.Text.Trim();
            string senha = txt_senha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                lbl_mensagem.Text = "? Por favor, preencha usuário e senha.";
                lbl_mensagem.Visible = true;
                btn_login.Enabled = true;
                btn_login.Text = originalText;
                return;
            }

            bool primeiroLogin;
            if (LoginService.TentarLogin(usuario, senha, out string msgErro, out primeiroLogin))
            {
                // Animação de sucesso
                btn_login.Text = "? Acesso concedido!";
                btn_login.BackColor = Styler.ModernColors.Success;
                await Task.Delay(500);

                if (primeiroLogin)
                {
                    var cadastroUsuario = new CadUsuarioForcado();
                    cadastroUsuario.Show();

                    var telaInicial = new TelaInicial();
                    telaInicial.Show();

                    this.Hide();
                }
                else
                {
                    var telaInicial = new TelaInicial();
                    telaInicial.Show();
                    this.Hide();
                }
            }
            else
            {
                lbl_mensagem.Text = "? " + msgErro;
                lbl_mensagem.Visible = true;
                
                // Animação de erro
                btn_login.BackColor = Styler.ModernColors.Error;
                await Task.Delay(300);
                btn_login.BackColor = Styler.ModernColors.Primary;
            }

            btn_login.Enabled = true;
            btn_login.Text = originalText;
        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            SelectNextControl(ActiveControl, true, true, true, true);
        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            if (btn_login.Enabled)
            {
                btn_login.PerformClick();
            }
        }
    }
}
