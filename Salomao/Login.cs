using System.Data.SQLite;
using Salomao.Cadastros;
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

            await Task.Delay(300);

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

            bool primeiroLogin;
            if (LoginService.TentarLogin(usuario, senha, out string msgErro, out primeiroLogin))
            {
                if (primeiroLogin)
                {
                    var cadastroUsuario = new Register();
                    cadastroUsuario.Show();

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
                lbl_mensagem.Text = msgErro;
                lbl_mensagem.Visible = true;
            }

            btn_login.Enabled = true;
            btn_login.Text = "Logar";
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
