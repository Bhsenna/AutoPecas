namespace Gremory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string sUsuario = usuario.Text.ToString();
                string sSenha = senha.Text.ToString();

                //Implementacao para pegar dados do usuario do banco e comparar senha

                if (sUsuario.Equals("usuario") && sSenha.Equals("senha"))
                {
                    //Abrir tela principal
                    this.Close();
                    return;
                }
                else
                {
                    Mensagem.Text = "Usuário ou senha incorretos";
                    Mensagem.Enabled = true;
                    Mensagem.ForeColor = Color.Red;
                    //MessageBox.Show("Usuário ou senha incorretos", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na aplicação", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
