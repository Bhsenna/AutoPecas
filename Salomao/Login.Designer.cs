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
            panel_LeftSide = new Panel();
            lbl_WelcomeSubtitle = new Label();
            lbl_WelcomeTitle = new Label();
            panel_LoginContainer = new Panel();
            panel_PasswordContainer = new Panel();
            panel_PasswordInput = new Panel();
            panel_UsernameContainer = new Panel();
            panel_UsernameInput = new Panel();
            lbl_AppSubtitle = new Label();
            panel_Drag.SuspendLayout();
            panel_LeftSide.SuspendLayout();
            panel_LoginContainer.SuspendLayout();
            panel_PasswordContainer.SuspendLayout();
            panel_PasswordInput.SuspendLayout();
            panel_UsernameContainer.SuspendLayout();
            panel_UsernameInput.SuspendLayout();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Font = new Font("Segoe UI", 11F);
            txt_usuario.ForeColor = Color.FromArgb(30, 41, 59);
            txt_usuario.Location = new Point(17, 11);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Digite seu usuário";
            txt_usuario.Size = new Size(354, 25);
            txt_usuario.TabIndex = 1;
            txt_usuario.KeyDown += txt_usuario_KeyDown;
            // 
            // txt_senha
            // 
            txt_senha.BorderStyle = BorderStyle.None;
            txt_senha.Font = new Font("Segoe UI", 11F);
            txt_senha.ForeColor = Color.FromArgb(30, 41, 59);
            txt_senha.Location = new Point(17, 11);
            txt_senha.Margin = new Padding(3, 4, 3, 4);
            txt_senha.Name = "txt_senha";
            txt_senha.PlaceholderText = "Digite sua senha";
            txt_senha.Size = new Size(354, 25);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.KeyDown += txt_senha_KeyDown;
            // 
            // stc_usuario
            // 
            stc_usuario.AutoSize = true;
            stc_usuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            stc_usuario.ForeColor = Color.FromArgb(30, 41, 59);
            stc_usuario.Location = new Point(0, 0);
            stc_usuario.Name = "stc_usuario";
            stc_usuario.Size = new Size(68, 23);
            stc_usuario.TabIndex = 3;
            stc_usuario.Text = "Usuário";
            // 
            // stc_senha
            // 
            stc_senha.AutoSize = true;
            stc_senha.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            stc_senha.ForeColor = Color.FromArgb(30, 41, 59);
            stc_senha.Location = new Point(0, 0);
            stc_senha.Name = "stc_senha";
            stc_senha.Size = new Size(57, 23);
            stc_senha.TabIndex = 4;
            stc_senha.Text = "Senha";
            // 
            // lbl_mensagem
            // 
            lbl_mensagem.Font = new Font("Segoe UI", 9F);
            lbl_mensagem.ForeColor = Color.FromArgb(239, 68, 68);
            lbl_mensagem.Location = new Point(46, 353);
            lbl_mensagem.Name = "lbl_mensagem";
            lbl_mensagem.Size = new Size(389, 53);
            lbl_mensagem.TabIndex = 6;
            lbl_mensagem.TextAlign = ContentAlignment.TopCenter;
            lbl_mensagem.Visible = false;
            // 
            // dragControl1
            // 
            dragControl1.SelectControl = panel_Drag;
            // 
            // panel_Drag
            // 
            panel_Drag.BackColor = Color.Transparent;
            panel_Drag.Controls.Add(btn_minimize);
            panel_Drag.Controls.Add(btn_close);
            panel_Drag.Dock = DockStyle.Top;
            panel_Drag.Location = new Point(0, 0);
            panel_Drag.Margin = new Padding(3, 4, 3, 4);
            panel_Drag.Name = "panel_Drag";
            panel_Drag.Size = new Size(1029, 47);
            panel_Drag.TabIndex = 8;
            // 
            // btn_minimize
            // 
            btn_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 165, 250);
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_minimize.ForeColor = Color.FromArgb(71, 85, 105);
            btn_minimize.Location = new Point(933, 0);
            btn_minimize.Margin = new Padding(3, 4, 3, 4);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(46, 47);
            btn_minimize.TabIndex = 9;
            btn_minimize.Text = "─";
            btn_minimize.UseVisualStyleBackColor = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.BackColor = Color.Transparent;
            btn_close.Cursor = Cursors.Hand;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 68, 68);
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_close.ForeColor = Color.FromArgb(71, 85, 105);
            btn_close.Location = new Point(978, 0);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(46, 47);
            btn_close.TabIndex = 9;
            btn_close.Text = "✕";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(59, 130, 246);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(46, 420);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(389, 64);
            btn_login.TabIndex = 3;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // stc_title
            // 
            stc_title.AutoSize = true;
            stc_title.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            stc_title.ForeColor = Color.FromArgb(30, 41, 59);
            stc_title.Location = new Point(46, 80);
            stc_title.Name = "stc_title";
            stc_title.Size = new Size(253, 60);
            stc_title.TabIndex = 11;
            stc_title.Text = "Bem-vindo";
            // 
            // panel_LeftSide
            // 
            panel_LeftSide.BackColor = Color.FromArgb(59, 130, 246);
            panel_LeftSide.Controls.Add(lbl_WelcomeSubtitle);
            panel_LeftSide.Controls.Add(lbl_WelcomeTitle);
            panel_LeftSide.Dock = DockStyle.Left;
            panel_LeftSide.Location = new Point(0, 47);
            panel_LeftSide.Margin = new Padding(3, 4, 3, 4);
            panel_LeftSide.Name = "panel_LeftSide";
            panel_LeftSide.Size = new Size(514, 753);
            panel_LeftSide.TabIndex = 12;
            // 
            // lbl_WelcomeSubtitle
            // 
            lbl_WelcomeSubtitle.Font = new Font("Segoe UI", 12F);
            lbl_WelcomeSubtitle.ForeColor = Color.FromArgb(224, 242, 254);
            lbl_WelcomeSubtitle.Location = new Point(48, 393);
            lbl_WelcomeSubtitle.Name = "lbl_WelcomeSubtitle";
            lbl_WelcomeSubtitle.Size = new Size(400, 133);
            lbl_WelcomeSubtitle.TabIndex = 1;
            lbl_WelcomeSubtitle.Text = "Faça login para acessar o sistema de gestão de peças automotivas";
            lbl_WelcomeSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_WelcomeTitle
            // 
            lbl_WelcomeTitle.AutoSize = true;
            lbl_WelcomeTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lbl_WelcomeTitle.ForeColor = Color.White;
            lbl_WelcomeTitle.Location = new Point(5, 294);
            lbl_WelcomeTitle.Name = "lbl_WelcomeTitle";
            lbl_WelcomeTitle.Size = new Size(506, 72);
            lbl_WelcomeTitle.TabIndex = 0;
            lbl_WelcomeTitle.Text = "Sistema AutoPeças";
            // 
            // panel_LoginContainer
            // 
            panel_LoginContainer.BackColor = Color.White;
            panel_LoginContainer.Controls.Add(panel_PasswordContainer);
            panel_LoginContainer.Controls.Add(panel_UsernameContainer);
            panel_LoginContainer.Controls.Add(lbl_AppSubtitle);
            panel_LoginContainer.Controls.Add(stc_title);
            panel_LoginContainer.Controls.Add(lbl_mensagem);
            panel_LoginContainer.Controls.Add(btn_login);
            panel_LoginContainer.Dock = DockStyle.Fill;
            panel_LoginContainer.Location = new Point(514, 47);
            panel_LoginContainer.Margin = new Padding(3, 4, 3, 4);
            panel_LoginContainer.Name = "panel_LoginContainer";
            panel_LoginContainer.Size = new Size(515, 753);
            panel_LoginContainer.TabIndex = 13;
            // 
            // panel_PasswordContainer
            // 
            panel_PasswordContainer.Controls.Add(stc_senha);
            panel_PasswordContainer.Controls.Add(panel_PasswordInput);
            panel_PasswordContainer.Location = new Point(46, 287);
            panel_PasswordContainer.Margin = new Padding(3, 4, 3, 4);
            panel_PasswordContainer.Name = "panel_PasswordContainer";
            panel_PasswordContainer.Size = new Size(389, 87);
            panel_PasswordContainer.TabIndex = 2;
            // 
            // panel_PasswordInput
            // 
            panel_PasswordInput.BackColor = Color.White;
            panel_PasswordInput.Controls.Add(txt_senha);
            panel_PasswordInput.Location = new Point(0, 33);
            panel_PasswordInput.Margin = new Padding(3, 4, 3, 4);
            panel_PasswordInput.Name = "panel_PasswordInput";
            panel_PasswordInput.Size = new Size(389, 48);
            panel_PasswordInput.TabIndex = 2;
            // 
            // panel_UsernameContainer
            // 
            panel_UsernameContainer.Controls.Add(stc_usuario);
            panel_UsernameContainer.Controls.Add(panel_UsernameInput);
            panel_UsernameContainer.Location = new Point(46, 180);
            panel_UsernameContainer.Margin = new Padding(3, 4, 3, 4);
            panel_UsernameContainer.Name = "panel_UsernameContainer";
            panel_UsernameContainer.Size = new Size(389, 87);
            panel_UsernameContainer.TabIndex = 1;
            // 
            // panel_UsernameInput
            // 
            panel_UsernameInput.BackColor = Color.White;
            panel_UsernameInput.Controls.Add(txt_usuario);
            panel_UsernameInput.Location = new Point(0, 33);
            panel_UsernameInput.Margin = new Padding(3, 4, 3, 4);
            panel_UsernameInput.Name = "panel_UsernameInput";
            panel_UsernameInput.Size = new Size(389, 48);
            panel_UsernameInput.TabIndex = 1;
            // 
            // lbl_AppSubtitle
            // 
            lbl_AppSubtitle.AutoSize = true;
            lbl_AppSubtitle.Font = new Font("Segoe UI", 11F);
            lbl_AppSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lbl_AppSubtitle.Location = new Point(46, 143);
            lbl_AppSubtitle.Name = "lbl_AppSubtitle";
            lbl_AppSubtitle.Size = new Size(326, 25);
            lbl_AppSubtitle.TabIndex = 13;
            lbl_AppSubtitle.Text = "Entre com suas credenciais de acesso";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1029, 800);
            Controls.Add(panel_LoginContainer);
            Controls.Add(panel_LeftSide);
            Controls.Add(panel_Drag);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Login";
            panel_Drag.ResumeLayout(false);
            panel_LeftSide.ResumeLayout(false);
            panel_LeftSide.PerformLayout();
            panel_LoginContainer.ResumeLayout(false);
            panel_LoginContainer.PerformLayout();
            panel_PasswordContainer.ResumeLayout(false);
            panel_PasswordContainer.PerformLayout();
            panel_PasswordInput.ResumeLayout(false);
            panel_PasswordInput.PerformLayout();
            panel_UsernameContainer.ResumeLayout(false);
            panel_UsernameContainer.PerformLayout();
            panel_UsernameInput.ResumeLayout(false);
            panel_UsernameInput.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel_LeftSide;
        private Label lbl_WelcomeTitle;
        private Label lbl_WelcomeSubtitle;
        private Panel panel_LoginContainer;
        private Label lbl_AppSubtitle;
        private Panel panel_UsernameContainer;
        private Panel panel_UsernameInput;
        private Panel panel_PasswordContainer;
        private Panel panel_PasswordInput;
    }
}
