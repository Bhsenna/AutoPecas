namespace AutoPecas.Cadastros
{
    partial class CadUsuarioForcado
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNovoUsuario;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNovoUsuario = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Labels
            this.label1.Text = "Novo usuário:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.AutoSize = true;

            this.label2.Text = "Nova senha:";
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.AutoSize = true;

            this.label3.Text = "Confirme a senha:";
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.AutoSize = true;

            // Textboxes
            this.txtNovoUsuario.Location = new System.Drawing.Point(150, 17);
            this.txtNovoUsuario.Width = 200;

            this.txtNovaSenha.Location = new System.Drawing.Point(150, 57);
            this.txtNovaSenha.Width = 200;
            this.txtNovaSenha.UseSystemPasswordChar = true;

            this.txtConfirmaSenha.Location = new System.Drawing.Point(150, 97);
            this.txtConfirmaSenha.Width = 200;
            this.txtConfirmaSenha.UseSystemPasswordChar = true;

            // Button
            this.btnCadastrar.Location = new System.Drawing.Point(150, 140);
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            // FormCadastroUsuarioForcado
            this.ClientSize = new System.Drawing.Size(380, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNovoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.btnCadastrar);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro obrigatório de usuário";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
