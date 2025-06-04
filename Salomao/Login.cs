using System.Data.SQLite;
using Salomao.Security;

namespace Salomao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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
            btn_login.Text = "...";

            await Task.Delay(300); // UX delay simulado

            string usuario = txt_usuario.Text.Trim();
            string senha = txt_senha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                lbl_mensagem.Text = "Preencha usuário e senha.";
                lbl_mensagem.Visible = true;
                btn_login.Enabled = true;
                btn_login.Text = "Logar";
                return;
            }

            if (LoginService.TentarLogin(usuario, senha, out string msgErro))
            {
                var telaInicial = new TelaInicial();
                telaInicial.Opacity = 0;
                telaInicial.Show();
                var timer = new System.Windows.Forms.Timer { Interval = 10 };
                timer.Tick += (s, ev) =>
                {
                    if (telaInicial.Opacity >= 1) timer.Stop();
                    telaInicial.Opacity += 0.05;
                };
                timer.Start();
                this.Hide();
            }
            else
            {
                lbl_mensagem.Text = msgErro;
                lbl_mensagem.Visible = true;
            }

            btn_login.Enabled = true;
            btn_login.Text = "Logar";
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Opacity = 0;
            register.Show();
            var timer = new System.Windows.Forms.Timer { Interval = 10 };
            timer.Tick += (s, ev) =>
            {
                if (register.Opacity >= 1) timer.Stop();
                register.Opacity += 0.05;
            };
            timer.Start();
            this.Close();
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
