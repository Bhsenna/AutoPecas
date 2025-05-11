using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text.RegularExpressions;

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
            try
            {
                string sUsuario = txt_usuario.Text.ToString();
                string sSenha = txt_senha.Text.ToString();
                string sConfirma = txt_confirma.Text.ToString();

                List<string> erros = new List<string>();

                if (sUsuario.Length < 5)
                {
                    erros.Add("Usuário deve ter no mínimo 5 caracteres");
                }
                else
                {
                    SQLiteConnection connection = BancoSQLite.GetConnection();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Login = @usuario";
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.Parameters.AddWithValue("@usuario", sUsuario);

                    connection.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        erros.Add("Usuário já existe");
                    }

                    connection.Close();
                }

                if (!Regex.IsMatch(sSenha, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$"))
                {
                    erros.Add("Senha deve ter entre 8 e 15 caracteres, com pelo menos uma letra maiúscula, uma letra minúscula e um número");
                }

                if (sSenha != sConfirma)
                {
                    erros.Add("Senhas não conferem");
                }

                if (erros.Count > 0)
                {
                    string mensagem = string.Join("\n", erros);
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string hashPassword = PasswordManager.HashPassword(sSenha, out string salt);

                    SQLiteConnection connection = BancoSQLite.GetConnection();

                    string query = "INSERT INTO Usuarios (Login, SenhaHash, Salt) VALUES (@usuario, @senha, @salt)";
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.Parameters.AddWithValue("@usuario", sUsuario);
                    cmd.Parameters.AddWithValue("@senha", hashPassword);
                    cmd.Parameters.AddWithValue("@salt", salt);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Abrir tela principal
                    var telaInicial = new TelaInicial();

                    telaInicial.Show();

                    this.Dispose();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na aplicação -\n" + ex, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var login = new Login();

            login.Show();

            this.Dispose();
            return;
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
