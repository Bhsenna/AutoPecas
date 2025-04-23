namespace Salomao
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel_Drag = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            dragControl1 = new DragControl();
            stc_senha = new Label();
            stc_usuario = new Label();
            senha = new TextBox();
            usuario = new TextBox();
            label1 = new Label();
            senhaC = new TextBox();
            btn_register = new Button();
            btn_login = new Button();
            panel_Drag.SuspendLayout();
            SuspendLayout();
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
            panel_Drag.TabIndex = 9;
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
            // dragControl1
            // 
            dragControl1.SelectControl = panel_Drag;
            // 
            // stc_senha
            // 
            stc_senha.Anchor = AnchorStyles.None;
            stc_senha.AutoSize = true;
            stc_senha.ForeColor = Color.White;
            stc_senha.Location = new Point(50, 125);
            stc_senha.Name = "stc_senha";
            stc_senha.Size = new Size(57, 19);
            stc_senha.TabIndex = 13;
            stc_senha.Text = "Senha:";
            // 
            // stc_usuario
            // 
            stc_usuario.Anchor = AnchorStyles.None;
            stc_usuario.AutoSize = true;
            stc_usuario.ForeColor = Color.White;
            stc_usuario.Location = new Point(50, 75);
            stc_usuario.Name = "stc_usuario";
            stc_usuario.Size = new Size(62, 19);
            stc_usuario.TabIndex = 12;
            stc_usuario.Text = "Usuário:";
            // 
            // senha
            // 
            senha.Anchor = AnchorStyles.None;
            senha.Cursor = Cursors.IBeam;
            senha.Location = new Point(50, 145);
            senha.Name = "senha";
            senha.Size = new Size(250, 24);
            senha.TabIndex = 11;
            senha.UseSystemPasswordChar = true;
            // 
            // usuario
            // 
            usuario.Anchor = AnchorStyles.None;
            usuario.Cursor = Cursors.IBeam;
            usuario.Location = new Point(50, 95);
            usuario.Name = "usuario";
            usuario.Size = new Size(250, 24);
            usuario.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 175);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 16;
            label1.Text = "Confirmar Senha:";
            // 
            // senhaC
            // 
            senhaC.Anchor = AnchorStyles.None;
            senhaC.Cursor = Cursors.IBeam;
            senhaC.Location = new Point(50, 195);
            senhaC.Name = "senhaC";
            senhaC.Size = new Size(250, 24);
            senhaC.TabIndex = 15;
            senhaC.UseSystemPasswordChar = true;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.None;
            btn_register.BackColor = Color.Transparent;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.DarkOrchid;
            btn_register.Location = new Point(180, 247);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(120, 36);
            btn_register.TabIndex = 17;
            btn_register.Text = "Cadastrar";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.Transparent;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.MediumOrchid;
            btn_login.Location = new Point(50, 247);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(110, 36);
            btn_login.TabIndex = 18;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 35);
            ClientSize = new Size(350, 310);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(label1);
            Controls.Add(senhaC);
            Controls.Add(stc_senha);
            Controls.Add(stc_usuario);
            Controls.Add(senha);
            Controls.Add(usuario);
            Controls.Add(panel_Drag);
            Font = new Font("Century Gothic", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel_Drag.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Drag;
        private Button btn_minimize;
        private Button btn_close;
        private DragControl dragControl1;
        private Label stc_senha;
        private Label stc_usuario;
        private TextBox senha;
        private TextBox usuario;
        private Label label1;
        private TextBox senhaC;
        private Button btn_register;
        private Button btn_login;
    }
}