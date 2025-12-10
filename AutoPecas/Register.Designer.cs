namespace AutoPecas
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
            txt_senha = new TextBox();
            txt_usuario = new TextBox();
            stc_confirma = new Label();
            txt_confirma = new TextBox();
            btn_register = new Button();
            stc_title = new Label();
            panel_Drag.SuspendLayout();
            SuspendLayout();
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
            // dragControl1
            // 
            dragControl1.SelectControl = panel_Drag;
            // 
            // stc_senha
            // 
            stc_senha.Anchor = AnchorStyles.None;
            stc_senha.AutoSize = true;
            stc_senha.ForeColor = Color.Black;
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
            stc_usuario.ForeColor = Color.Black;
            stc_usuario.Location = new Point(50, 75);
            stc_usuario.Name = "stc_usuario";
            stc_usuario.Size = new Size(62, 19);
            stc_usuario.TabIndex = 12;
            stc_usuario.Text = "Usuário:";
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.None;
            txt_senha.Cursor = Cursors.IBeam;
            txt_senha.ForeColor = Color.FromArgb(55, 65, 81);
            txt_senha.Location = new Point(50, 145);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(250, 24);
            txt_senha.TabIndex = 11;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.KeyDown += txt_senha_KeyDown;
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.None;
            txt_usuario.Cursor = Cursors.IBeam;
            txt_usuario.ForeColor = Color.FromArgb(55, 65, 81);
            txt_usuario.Location = new Point(50, 95);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(250, 24);
            txt_usuario.TabIndex = 10;
            txt_usuario.KeyDown += txt_usuario_KeyDown;
            // 
            // stc_confirma
            // 
            stc_confirma.Anchor = AnchorStyles.None;
            stc_confirma.AutoSize = true;
            stc_confirma.ForeColor = Color.Black;
            stc_confirma.Location = new Point(50, 175);
            stc_confirma.Name = "stc_confirma";
            stc_confirma.Size = new Size(128, 19);
            stc_confirma.TabIndex = 16;
            stc_confirma.Text = "Confirmar Senha:";
            // 
            // txt_confirma
            // 
            txt_confirma.Anchor = AnchorStyles.None;
            txt_confirma.Cursor = Cursors.IBeam;
            txt_confirma.ForeColor = Color.FromArgb(55, 65, 81);
            txt_confirma.Location = new Point(50, 195);
            txt_confirma.Name = "txt_confirma";
            txt_confirma.Size = new Size(250, 24);
            txt_confirma.TabIndex = 15;
            txt_confirma.UseSystemPasswordChar = true;
            txt_confirma.KeyDown += txt_confirma_KeyDown;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.None;
            btn_register.BackColor = Color.Transparent;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.FromArgb(16, 185, 129);
            btn_register.Location = new Point(50, 247);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(250, 36);
            btn_register.TabIndex = 17;
            btn_register.Text = "Cadastrar";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // stc_title
            // 
            stc_title.AutoSize = true;
            stc_title.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stc_title.ForeColor = Color.FromArgb(17, 24, 39);
            stc_title.Location = new Point(35, 45);
            stc_title.Name = "stc_title";
            stc_title.Size = new Size(280, 30);
            stc_title.TabIndex = 19;
            stc_title.Text = "Altere Usuário e Senha";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 310);
            Controls.Add(stc_title);
            Controls.Add(btn_register);
            Controls.Add(stc_confirma);
            Controls.Add(txt_confirma);
            Controls.Add(stc_senha);
            Controls.Add(stc_usuario);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
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
        private TextBox txt_senha;
        private TextBox txt_usuario;
        private Label stc_confirma;
        private TextBox txt_confirma;
        private Button btn_register;
        private Button btn_login;
        private Label stc_title;
    }
}