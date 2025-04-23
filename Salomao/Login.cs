using System.Data.SQLite;

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

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string sUsuario = usuario.Text.ToString();
                string sSenha = senha.Text.ToString();
                bool erro = false;

                //Implementacao para pegar dados do usuario do banco e comparar senha
                SQLiteConnection con = BancoSQLite.ObterConexao();

                string query = "SELECT SenhaHash, Salt FROM Usuarios WHERE Login = @usuario";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", sUsuario);
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                string senhaHash = null;
                string salt = null;
                if (reader.Read())
                {
                    senhaHash = reader["SenhaHash"].ToString();
                    salt = reader["Salt"].ToString();
                }
                con.Close();
                if (senhaHash == null || salt == null)
                {
                    erro = true;
                }
                else
                {
                    //Verifica se a senha informada é igual a senha do banco
                    if (!PasswordManager.VerifyPassword(sSenha, senhaHash, salt))
                    {
                        erro = true;
                    }
                }

                //Verifica se o usuario existe
                if (!erro)
                {
                    //Abrir tela principal
                    var telaInicial = new TelaInicial();

                    telaInicial.Show();

                    this.Dispose();
                    return;
                }
                else
                {
                    lbl_mensage.Text = "Usuário ou senha incorretos";
                    lbl_mensage.Visible = true;
                    lbl_mensage.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na aplicação -\n" + ex, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            var register = new Register();

            register.Show();

            this.Dispose();
            return;
        }

        private void usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            SelectNextControl(ActiveControl, true, true, true, true);
        }

        private void senha_KeyDown(object sender, KeyEventArgs e)
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
