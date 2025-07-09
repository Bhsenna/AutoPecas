namespace Salomao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            stc_usuario = new Label();
            stc_senha = new Label();
            lbl_mensagem = new Label();
            dragControl1 = new DragControl();
            panel_Drag = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            btn_login = new Button();
            stc_title = new Label();
            panel_Drag.SuspendLayout();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.None;
            txt_usuario.Cursor = Cursors.IBeam;
            txt_usuario.ForeColor = Color.FromArgb(55, 65, 81);
            txt_usuario.Location = new Point(50, 115);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(250, 24);
            txt_usuario.TabIndex = 1;
            txt_usuario.KeyDown += txt_usuario_KeyDown;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.None;
            txt_senha.Cursor = Cursors.IBeam;
            txt_senha.ForeColor = Color.FromArgb(55, 65, 81);
            txt_senha.Location = new Point(50, 165);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(250, 24);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.KeyDown += txt_senha_KeyDown;
            // 
            // stc_usuario
            // 
            stc_usuario.Anchor = AnchorStyles.None;
            stc_usuario.AutoSize = true;
            stc_usuario.ForeColor = Color.Black;
            stc_usuario.Location = new Point(50, 95);
            stc_usuario.Name = "stc_usuario";
            stc_usuario.Size = new Size(62, 19);
            stc_usuario.TabIndex = 3;
            stc_usuario.Text = "Usuário:";
            // 
            // stc_senha
            // 
            stc_senha.Anchor = AnchorStyles.None;
            stc_senha.AutoSize = true;
            stc_senha.ForeColor = Color.Black;
            stc_senha.Location = new Point(50, 145);
            stc_senha.Name = "stc_senha";
            stc_senha.Size = new Size(57, 19);
            stc_senha.TabIndex = 4;
            stc_senha.Text = "Senha:";
            // 
            // lbl_mensagem
            // 
            lbl_mensagem.Anchor = AnchorStyles.None;
            lbl_mensagem.ForeColor = Color.Red;
            lbl_mensagem.Location = new Point(50, 195);
            lbl_mensagem.Name = "lbl_mensagem";
            lbl_mensagem.Size = new Size(250, 19);
            lbl_mensagem.TabIndex = 6;
            lbl_mensagem.Visible = false;
            // 
            // dragControl1
            // 
            dragControl1.SelectControl = panel_Drag;
            // 
            // panel_Drag
            // 
            panel_Drag.BackColor = Color.FromArgb(30, 58, 138);
            panel_Drag.Controls.Add(btn_minimize);
            panel_Drag.Controls.Add(btn_close);
            panel_Drag.Dock = DockStyle.Top;
            panel_Drag.Location = new Point(0, 0);
            panel_Drag.Name = "panel_Drag";
            panel_Drag.Size = new Size(350, 25);
            panel_Drag.TabIndex = 8;
            // 
            // btn_minimize
            // 
            btn_minimize.AccessibleName = "";
            btn_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = (Image)resources.GetObject("btn_minimize.BackgroundImage");
            btn_minimize.BackgroundImageLayout = ImageLayout.Zoom;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.ForeColor = Color.Black;
            btn_minimize.Location = new Point(296, 0);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(24, 24);
            btn_minimize.TabIndex = 9;
            btn_minimize.UseVisualStyleBackColor = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_close
            // 
            btn_close.AccessibleName = "";
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.BackColor = Color.Transparent;
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Cursor = Cursors.Hand;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.ForeColor = Color.Black;
            btn_close.Location = new Point(326, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(24, 24);
            btn_close.TabIndex = 9;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.Transparent;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.FromArgb(16, 185, 129);
            btn_login.Location = new Point(50, 217);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(250, 36);
            btn_login.TabIndex = 9;
            btn_login.Text = "Logar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // stc_title
            // 
            stc_title.AutoSize = true;
            stc_title.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stc_title.ForeColor = Color.FromArgb(17, 24, 39);
            stc_title.Location = new Point(133, 45);
            stc_title.Name = "stc_title";
            stc_title.Size = new Size(84, 30);
            stc_title.TabIndex = 11;
            stc_title.Text = "Log in";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 310);
            Controls.Add(stc_title);
            Controls.Add(btn_login);
            Controls.Add(panel_Drag);
            Controls.Add(lbl_mensagem);
            Controls.Add(stc_senha);
            Controls.Add(stc_usuario);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Font = new Font("Century Gothic", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sitema Login";
            panel_Drag.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label stc_usuario;
        private Label stc_senha;
        private Label lbl_mensagem;
        private DragControl dragControl1;
        private Panel panel_Drag;
        private Button btn_close;
        private Button btn_minimize;
        private Button btn_login;
        private Label stc_title;
    }
}
