namespace Salomao
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            panel_menu = new Panel();
            btn_home = new Label();
            ibtn_logout = new FontAwesome.Sharp.IconButton();
            ibtn_config = new FontAwesome.Sharp.IconButton();
            ibtn_servicos = new FontAwesome.Sharp.IconButton();
            ibtn_veiculos = new FontAwesome.Sharp.IconButton();
            ibtn_clientes = new FontAwesome.Sharp.IconButton();
            ibtn_produtos = new FontAwesome.Sharp.IconButton();
            panel_header = new Panel();
            btn_maximize = new Button();
            btn_minimize = new Button();
            lbl_title = new Label();
            icon_current = new FontAwesome.Sharp.IconPictureBox();
            btn_close = new Button();
            dragControl1 = new DragControl();
            panel_shadow = new Panel();
            panel_desktop = new Panel();
            panel_menu.SuspendLayout();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_current).BeginInit();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.BackColor = Color.FromArgb(30, 58, 138);
            panel_menu.Controls.Add(btn_home);
            panel_menu.Controls.Add(ibtn_logout);
            panel_menu.Controls.Add(ibtn_config);
            panel_menu.Controls.Add(ibtn_servicos);
            panel_menu.Controls.Add(ibtn_veiculos);
            panel_menu.Controls.Add(ibtn_clientes);
            panel_menu.Controls.Add(ibtn_produtos);
            panel_menu.Dock = DockStyle.Left;
            panel_menu.Location = new Point(0, 0);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(222, 606);
            panel_menu.TabIndex = 0;
            // 
            // btn_home
            // 
            btn_home.AutoSize = true;
            btn_home.Cursor = Cursors.Hand;
            btn_home.Font = new Font("Condiment", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_home.ForeColor = Color.FromArgb(209, 213, 219);
            btn_home.Location = new Point(4, 7);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(212, 73);
            btn_home.TabIndex = 2;
            btn_home.Text = "Auto Peças";
            btn_home.Click += btn_home_Click;
            // 
            // ibtn_logout
            // 
            ibtn_logout.Cursor = Cursors.Hand;
            ibtn_logout.FlatAppearance.BorderSize = 0;
            ibtn_logout.FlatStyle = FlatStyle.Flat;
            ibtn_logout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_logout.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            ibtn_logout.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_logout.IconSize = 32;
            ibtn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_logout.Location = new Point(3, 487);
            ibtn_logout.Name = "ibtn_logout";
            ibtn_logout.Padding = new Padding(10, 0, 20, 0);
            ibtn_logout.Size = new Size(216, 60);
            ibtn_logout.TabIndex = 9;
            ibtn_logout.Text = "Log Out";
            ibtn_logout.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_logout.UseVisualStyleBackColor = true;
            ibtn_logout.Click += ibtn_logout_Click;
            // 
            // ibtn_config
            // 
            ibtn_config.Cursor = Cursors.Hand;
            ibtn_config.FlatAppearance.BorderSize = 0;
            ibtn_config.FlatStyle = FlatStyle.Flat;
            ibtn_config.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_config.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_config.IconChar = FontAwesome.Sharp.IconChar.Cog;
            ibtn_config.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_config.IconSize = 32;
            ibtn_config.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_config.Location = new Point(3, 424);
            ibtn_config.Name = "ibtn_config";
            ibtn_config.Padding = new Padding(10, 0, 20, 0);
            ibtn_config.Size = new Size(216, 60);
            ibtn_config.TabIndex = 8;
            ibtn_config.Text = "Configurações";
            ibtn_config.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_config.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_config.UseVisualStyleBackColor = true;
            ibtn_config.Click += ibtn_config_Click;
            // 
            // ibtn_servicos
            // 
            ibtn_servicos.Cursor = Cursors.Hand;
            ibtn_servicos.FlatAppearance.BorderSize = 0;
            ibtn_servicos.FlatStyle = FlatStyle.Flat;
            ibtn_servicos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_servicos.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_servicos.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            ibtn_servicos.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_servicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_servicos.IconSize = 32;
            ibtn_servicos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_servicos.Location = new Point(3, 361);
            ibtn_servicos.Name = "ibtn_servicos";
            ibtn_servicos.Padding = new Padding(10, 0, 20, 0);
            ibtn_servicos.Size = new Size(216, 60);
            ibtn_servicos.TabIndex = 7;
            ibtn_servicos.Text = "Categorias";
            ibtn_servicos.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_servicos.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_servicos.UseVisualStyleBackColor = true;
            ibtn_servicos.Click += ibtn_categorias_Click;
            // 
            // ibtn_veiculos
            // 
            ibtn_veiculos.Cursor = Cursors.Hand;
            ibtn_veiculos.FlatAppearance.BorderSize = 0;
            ibtn_veiculos.FlatStyle = FlatStyle.Flat;
            ibtn_veiculos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_veiculos.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_veiculos.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            ibtn_veiculos.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_veiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_veiculos.IconSize = 32;
            ibtn_veiculos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_veiculos.Location = new Point(3, 298);
            ibtn_veiculos.Name = "ibtn_veiculos";
            ibtn_veiculos.Padding = new Padding(10, 0, 20, 0);
            ibtn_veiculos.Size = new Size(216, 60);
            ibtn_veiculos.TabIndex = 6;
            ibtn_veiculos.Text = "Veículos";
            ibtn_veiculos.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_veiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_veiculos.UseVisualStyleBackColor = true;
            ibtn_veiculos.Click += ibtn_veiculos_Click;
            // 
            // ibtn_clientes
            // 
            ibtn_clientes.Cursor = Cursors.Hand;
            ibtn_clientes.FlatAppearance.BorderSize = 0;
            ibtn_clientes.FlatStyle = FlatStyle.Flat;
            ibtn_clientes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_clientes.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_clientes.IconChar = FontAwesome.Sharp.IconChar.Male;
            ibtn_clientes.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_clientes.IconSize = 32;
            ibtn_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_clientes.Location = new Point(3, 235);
            ibtn_clientes.Name = "ibtn_clientes";
            ibtn_clientes.Padding = new Padding(10, 0, 20, 0);
            ibtn_clientes.Size = new Size(216, 60);
            ibtn_clientes.TabIndex = 5;
            ibtn_clientes.Text = "Clientes";
            ibtn_clientes.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_clientes.UseVisualStyleBackColor = true;
            ibtn_clientes.Click += ibtn_clientes_Click;
            // 
            // ibtn_produtos
            // 
            ibtn_produtos.BackColor = Color.FromArgb(30, 58, 138);
            ibtn_produtos.Cursor = Cursors.Hand;
            ibtn_produtos.FlatAppearance.BorderSize = 0;
            ibtn_produtos.FlatStyle = FlatStyle.Flat;
            ibtn_produtos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_produtos.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_produtos.IconChar = FontAwesome.Sharp.IconChar.Shop;
            ibtn_produtos.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_produtos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_produtos.IconSize = 32;
            ibtn_produtos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_produtos.Location = new Point(3, 172);
            ibtn_produtos.Name = "ibtn_produtos";
            ibtn_produtos.Padding = new Padding(10, 0, 20, 0);
            ibtn_produtos.Size = new Size(216, 60);
            ibtn_produtos.TabIndex = 4;
            ibtn_produtos.Text = "Produtos";
            ibtn_produtos.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_produtos.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_produtos.UseVisualStyleBackColor = false;
            ibtn_produtos.Click += ibtn_produtos_Click;
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.FromArgb(30, 58, 138);
            panel_header.Controls.Add(btn_maximize);
            panel_header.Controls.Add(btn_minimize);
            panel_header.Controls.Add(lbl_title);
            panel_header.Controls.Add(icon_current);
            panel_header.Controls.Add(btn_close);
            panel_header.Dock = DockStyle.Top;
            panel_header.Location = new Point(222, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(983, 80);
            panel_header.TabIndex = 1;
            // 
            // btn_maximize
            // 
            btn_maximize.AccessibleName = "";
            btn_maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_maximize.BackColor = Color.Transparent;
            btn_maximize.BackgroundImage = (Image)resources.GetObject("btn_maximize.BackgroundImage");
            btn_maximize.BackgroundImageLayout = ImageLayout.Zoom;
            btn_maximize.Cursor = Cursors.Hand;
            btn_maximize.FlatAppearance.BorderSize = 0;
            btn_maximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_maximize.FlatStyle = FlatStyle.Flat;
            btn_maximize.ForeColor = Color.Transparent;
            btn_maximize.Location = new Point(926, 3);
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(24, 24);
            btn_maximize.TabIndex = 6;
            btn_maximize.UseVisualStyleBackColor = false;
            btn_maximize.Click += btn_maximize_Click;
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
            btn_minimize.ForeColor = Color.Transparent;
            btn_minimize.Location = new Point(896, 3);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(24, 24);
            btn_minimize.TabIndex = 5;
            btn_minimize.UseVisualStyleBackColor = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.ForeColor = Color.FromArgb(209, 213, 219);
            lbl_title.Location = new Point(57, 28);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(44, 16);
            lbl_title.TabIndex = 4;
            lbl_title.Text = "Home";
            // 
            // icon_current
            // 
            icon_current.BackColor = Color.FromArgb(30, 58, 138);
            icon_current.ForeColor = Color.FromArgb(209, 213, 219);
            icon_current.IconChar = FontAwesome.Sharp.IconChar.House;
            icon_current.IconColor = Color.FromArgb(209, 213, 219);
            icon_current.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_current.Location = new Point(23, 25);
            icon_current.Name = "icon_current";
            icon_current.Size = new Size(32, 32);
            icon_current.TabIndex = 3;
            icon_current.TabStop = false;
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
            btn_close.ForeColor = Color.Transparent;
            btn_close.Location = new Point(956, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(24, 24);
            btn_close.TabIndex = 2;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // dragControl1
            // 
            dragControl1.SelectControl = panel_header;
            // 
            // panel_shadow
            // 
            panel_shadow.BackColor = Color.FromArgb(10, 38, 118);
            panel_shadow.Dock = DockStyle.Top;
            panel_shadow.Location = new Point(222, 80);
            panel_shadow.Name = "panel_shadow";
            panel_shadow.Size = new Size(983, 9);
            panel_shadow.TabIndex = 2;
            // 
            // panel_desktop
            // 
            panel_desktop.BackColor = Color.White;
            panel_desktop.Dock = DockStyle.Fill;
            panel_desktop.Location = new Point(222, 89);
            panel_desktop.Name = "panel_desktop";
            panel_desktop.Size = new Size(983, 517);
            panel_desktop.TabIndex = 3;
            // 
            // TelaInicial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1205, 606);
            Controls.Add(panel_desktop);
            Controls.Add(panel_shadow);
            Controls.Add(panel_header);
            Controls.Add(panel_menu);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_menu.ResumeLayout(false);
            panel_menu.PerformLayout();
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_current).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_menu;
        private Panel panel_header;
        private Button btn_close;
        private DragControl dragControl1;
        private FontAwesome.Sharp.IconButton ibtn_produtos;
        private FontAwesome.Sharp.IconButton ibtn_logout;
        private FontAwesome.Sharp.IconButton ibtn_config;
        private FontAwesome.Sharp.IconButton ibtn_servicos;
        private FontAwesome.Sharp.IconButton ibtn_veiculos;
        private FontAwesome.Sharp.IconButton ibtn_clientes;
        private Label btn_home;
        private FontAwesome.Sharp.IconPictureBox icon_current;
        private Label lbl_title;
        private Button btn_maximize;
        private Button btn_minimize;
        private Panel panel_shadow;
        private Panel panel_desktop;
    }
}
