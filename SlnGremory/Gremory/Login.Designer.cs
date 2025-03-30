namespace Gremory
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Entrar = new Button();
            usuario = new TextBox();
            senha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Mensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Entrar
            // 
            Entrar.AccessibleDescription = "Botão Entrar";
            Entrar.AccessibleName = "Entrar";
            Entrar.AccessibleRole = AccessibleRole.ButtonMenu;
            Entrar.BackColor = SystemColors.ActiveCaption;
            Entrar.BackgroundImage = Properties.Resources.Entrar;
            Entrar.BackgroundImageLayout = ImageLayout.Zoom;
            Entrar.Cursor = Cursors.Hand;
            Entrar.FlatAppearance.BorderSize = 0;
            Entrar.FlatStyle = FlatStyle.Flat;
            Entrar.Location = new Point(835, 268);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(96, 37);
            Entrar.TabIndex = 0;
            Entrar.UseCompatibleTextRendering = true;
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += Entrar_Click;
            // 
            // usuario
            // 
            usuario.Cursor = Cursors.IBeam;
            usuario.Location = new Point(682, 157);
            usuario.Name = "usuario";
            usuario.Size = new Size(249, 24);
            usuario.TabIndex = 1;
            usuario.TextChanged += textBox1_TextChanged;
            // 
            // senha
            // 
            senha.Cursor = Cursors.IBeam;
            senha.Location = new Point(682, 209);
            senha.Name = "senha";
            senha.Size = new Size(249, 24);
            senha.TabIndex = 2;
            senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(682, 137);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 3;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(682, 189);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.ImagemLogin;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 544);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Mensagem
            // 
            Mensagem.ForeColor = Color.Maroon;
            Mensagem.Location = new Point(683, 239);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(248, 19);
            Mensagem.TabIndex = 6;
            Mensagem.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(999, 544);
            Controls.Add(Mensagem);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(senha);
            Controls.Add(usuario);
            Controls.Add(Entrar);
            Font = new Font("Century Gothic", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sitema Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Entrar;
        private TextBox usuario;
        private TextBox senha;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label Mensagem;
    }
}
