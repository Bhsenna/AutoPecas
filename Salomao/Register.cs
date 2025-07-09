using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Salomao.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Salomao
{
    public partial class Register : Form
    {
        public Register()
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

        private void btn_register_Click(object sender, EventArgs e)
        {
            string novoLogin = txt_usuario.Text.Trim();
            string novaSenha = txt_senha.Text;
            string confirmaSenha = txt_confirma.Text;

            if (string.IsNullOrEmpty(novoLogin) || string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmaSenha))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(novaSenha, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$"))
            {
                MessageBox.Show("Senha deve ter entre 8 e 15 caracteres, com pelo menos uma letra maiúscula, uma letra minúscula e um número");
                return;
            }

            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LoginService.ExisteUsuario(novoLogin))
            {
                MessageBox.Show("Usuário já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Cria novo usuário
                LoginService.CriarUsuario(novoLogin, novaSenha);

                // Troca a senha do admin para Auto@AdminSecurity
                LoginService.TrocarSenha("admin", "Auto@AdminSecurity");

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var telaInicial = new TelaInicial();
                telaInicial.Show();

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            SelectNextControl(ActiveControl, true, true, true, true);
        }

        private void txt_confirma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            if (btn_register.Enabled)
            {
                btn_register.PerformClick();
            }
        }
    }
}
