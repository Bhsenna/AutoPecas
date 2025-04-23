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
            usuario = new TextBox();
            senha = new TextBox();
            stc_usuario = new Label();
            stc_senha = new Label();
            lbl_mensage = new Label();
            dragControl1 = new DragControl();
            panel_Drag = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            btn_login = new Button();
            btn_register = new Button();
            panel_Drag.SuspendLayout();
            SuspendLayout();
            // 
            // usuario
            // 
            usuario.Anchor = AnchorStyles.None;
            usuario.Cursor = Cursors.IBeam;
            usuario.Location = new Point(50, 115);
            usuario.Name = "usuario";
            usuario.Size = new Size(250, 24);
            usuario.TabIndex = 1;
            // 
            // senha
            // 
            senha.Anchor = AnchorStyles.None;
            senha.Cursor = Cursors.IBeam;
            senha.Location = new Point(50, 165);
            senha.Name = "senha";
            senha.Size = new Size(250, 24);
            senha.TabIndex = 2;
            senha.UseSystemPasswordChar = true;
            // 
            // stc_usuario
            // 
            stc_usuario.Anchor = AnchorStyles.None;
            stc_usuario.AutoSize = true;
            stc_usuario.ForeColor = Color.White;
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
            stc_senha.ForeColor = Color.White;
            stc_senha.Location = new Point(50, 145);
            stc_senha.Name = "stc_senha";
            stc_senha.Size = new Size(57, 19);
            stc_senha.TabIndex = 4;
            stc_senha.Text = "Senha:";
            // 
            // lbl_mensage
            // 
            lbl_mensage.Anchor = AnchorStyles.None;
            lbl_mensage.ForeColor = Color.Red;
            lbl_mensage.Location = new Point(50, 195);
            lbl_mensage.Name = "lbl_mensage";
            lbl_mensage.Size = new Size(250, 19);
            lbl_mensage.TabIndex = 6;
            lbl_mensage.Visible = false;
            // 
            // dragControl1
            // 
            dragControl1.SelectControl = panel_Drag;
            // 
            // panel_Drag
            // 
            panel_Drag.BackColor = Color.Black;
            panel_Drag.Controls.Add(btn_minimize);
            panel_Drag.Controls.Add(btn_close);
            panel_Drag.Dock = DockStyle.Top;
            panel_Drag.Location = new Point(0, 0);
            panel_Drag.Name = "panel_Drag";
            panel_Drag.Size = new Size(350, 48);
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
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 36, 36);
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
            btn_close.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 36, 36);
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
            btn_login.ForeColor = Color.DarkOrchid;
            btn_login.Location = new Point(190, 217);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(110, 36);
            btn_login.TabIndex = 9;
            btn_login.Text = "Logar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.None;
            btn_register.BackColor = Color.Transparent;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.MediumOrchid;
            btn_register.Location = new Point(50, 217);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(120, 36);
            btn_register.TabIndex = 10;
            btn_register.Text = "Criar conta";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 35);
            ClientSize = new Size(350, 310);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(panel_Drag);
            Controls.Add(lbl_mensage);
            Controls.Add(stc_senha);
            Controls.Add(stc_usuario);
            Controls.Add(senha);
            Controls.Add(usuario);
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
        private TextBox usuario;
        private TextBox senha;
        private Label stc_usuario;
        private Label stc_senha;
        private Label lbl_mensage;
        private DragControl dragControl1;
        private Panel panel_Drag;
        private Button btn_close;
        private Button btn_minimize;
        private Button btn_login;
        private Button btn_register;
    }
}
