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
            panel_header = new Panel();
            btn_home = new PictureBox();
            btn_maximize = new Button();
            btn_minimize = new Button();
            lbl_title = new Label();
            icon_current = new FontAwesome.Sharp.IconPictureBox();
            btn_close = new Button();
            panel_menu = new Panel();
            ibtn_produtos = new FontAwesome.Sharp.IconButton();
            ibtn_fornecedor = new FontAwesome.Sharp.IconButton();
            ibtn_clientes = new FontAwesome.Sharp.IconButton();
            ibtn_categorias = new FontAwesome.Sharp.IconButton();
            ibtn_servico = new FontAwesome.Sharp.IconButton();
            ibtn_atendimentos = new FontAwesome.Sharp.IconButton();
            ibtn_movEstoque = new FontAwesome.Sharp.IconButton();
            ibtn_saldoEstoque = new FontAwesome.Sharp.IconButton();
            ibtn_calendario = new FontAwesome.Sharp.IconButton();
            ibtn_config = new FontAwesome.Sharp.IconButton();
            ibtn_logout = new FontAwesome.Sharp.IconButton();
            dragControl1 = new DragControl();
            panel_desktop = new Panel();
            button1 = new Button();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_current).BeginInit();
            panel_menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.FromArgb(30, 58, 138);
            panel_header.Controls.Add(button1);
            panel_header.Controls.Add(btn_home);
            panel_header.Controls.Add(btn_maximize);
            panel_header.Controls.Add(btn_minimize);
            panel_header.Controls.Add(lbl_title);
            panel_header.Controls.Add(icon_current);
            panel_header.Controls.Add(btn_close);
            panel_header.Dock = DockStyle.Top;
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1264, 80);
            panel_header.TabIndex = 1;
            // 
            // btn_home
            // 
            btn_home.Image = (Image)resources.GetObject("btn_home.Image");
            btn_home.Location = new Point(12, 12);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(207, 62);
            btn_home.TabIndex = 7;
            btn_home.TabStop = false;
            btn_home.Click += btn_home_Click;
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
            btn_maximize.Location = new Point(1207, 3);
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
            btn_minimize.Location = new Point(1177, 3);
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
            lbl_title.Location = new Point(296, 28);
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
            icon_current.Location = new Point(262, 25);
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
            btn_close.Location = new Point(1237, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(24, 24);
            btn_close.TabIndex = 2;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // panel_menu
            // 
            panel_menu.AutoScroll = true;
            panel_menu.BackColor = Color.FromArgb(30, 58, 138);
            panel_menu.Controls.Add(ibtn_produtos);
            panel_menu.Controls.Add(ibtn_fornecedor);
            panel_menu.Controls.Add(ibtn_clientes);
            panel_menu.Controls.Add(ibtn_categorias);
            panel_menu.Controls.Add(ibtn_servico);
            panel_menu.Controls.Add(ibtn_atendimentos);
            panel_menu.Controls.Add(ibtn_movEstoque);
            panel_menu.Controls.Add(ibtn_saldoEstoque);
            panel_menu.Controls.Add(ibtn_calendario);
            panel_menu.Controls.Add(ibtn_config);
            panel_menu.Controls.Add(ibtn_logout);
            panel_menu.Dock = DockStyle.Left;
            panel_menu.Location = new Point(0, 80);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(239, 601);
            panel_menu.TabIndex = 0;
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
            ibtn_produtos.Location = new Point(4, 0);
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
            // ibtn_fornecedor
            // 
            ibtn_fornecedor.Cursor = Cursors.Hand;
            ibtn_fornecedor.FlatAppearance.BorderSize = 0;
            ibtn_fornecedor.FlatStyle = FlatStyle.Flat;
            ibtn_fornecedor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_fornecedor.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_fornecedor.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            ibtn_fornecedor.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_fornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_fornecedor.IconSize = 32;
            ibtn_fornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_fornecedor.Location = new Point(4, 189);
            ibtn_fornecedor.Name = "ibtn_fornecedor";
            ibtn_fornecedor.Padding = new Padding(10, 0, 20, 0);
            ibtn_fornecedor.Size = new Size(216, 60);
            ibtn_fornecedor.TabIndex = 8;
            ibtn_fornecedor.Text = "Fornecedores";
            ibtn_fornecedor.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_fornecedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_fornecedor.UseVisualStyleBackColor = true;
            ibtn_fornecedor.Click += ibtn_fornecedor_Click;
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
            ibtn_clientes.Location = new Point(4, 63);
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
            // ibtn_categorias
            // 
            ibtn_categorias.Cursor = Cursors.Hand;
            ibtn_categorias.FlatAppearance.BorderSize = 0;
            ibtn_categorias.FlatStyle = FlatStyle.Flat;
            ibtn_categorias.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_categorias.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_categorias.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            ibtn_categorias.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_categorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_categorias.IconSize = 32;
            ibtn_categorias.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_categorias.Location = new Point(4, 126);
            ibtn_categorias.Name = "ibtn_categorias";
            ibtn_categorias.Padding = new Padding(10, 0, 20, 0);
            ibtn_categorias.Size = new Size(216, 60);
            ibtn_categorias.TabIndex = 7;
            ibtn_categorias.Text = "Categorias";
            ibtn_categorias.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_categorias.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_categorias.UseVisualStyleBackColor = true;
            ibtn_categorias.Click += ibtn_categorias_Click;
            // 
            // ibtn_servico
            // 
            ibtn_servico.Cursor = Cursors.Hand;
            ibtn_servico.FlatAppearance.BorderSize = 0;
            ibtn_servico.FlatStyle = FlatStyle.Flat;
            ibtn_servico.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_servico.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_servico.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            ibtn_servico.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_servico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_servico.IconSize = 32;
            ibtn_servico.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_servico.Location = new Point(4, 252);
            ibtn_servico.Name = "ibtn_servico";
            ibtn_servico.Padding = new Padding(10, 0, 20, 0);
            ibtn_servico.Size = new Size(216, 60);
            ibtn_servico.TabIndex = 11;
            ibtn_servico.Text = "Serviços";
            ibtn_servico.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_servico.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_servico.UseVisualStyleBackColor = true;
            ibtn_servico.Click += ibtn_servico_Click;
            // 
            // ibtn_atendimentos
            // 
            ibtn_atendimentos.Cursor = Cursors.Hand;
            ibtn_atendimentos.FlatAppearance.BorderSize = 0;
            ibtn_atendimentos.FlatStyle = FlatStyle.Flat;
            ibtn_atendimentos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_atendimentos.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_atendimentos.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            ibtn_atendimentos.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_atendimentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_atendimentos.IconSize = 32;
            ibtn_atendimentos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_atendimentos.Location = new Point(4, 315);
            ibtn_atendimentos.Name = "ibtn_atendimentos";
            ibtn_atendimentos.Padding = new Padding(10, 0, 20, 0);
            ibtn_atendimentos.Size = new Size(216, 60);
            ibtn_atendimentos.TabIndex = 12;
            ibtn_atendimentos.Text = "Atendimentos";
            ibtn_atendimentos.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_atendimentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_atendimentos.UseVisualStyleBackColor = true;
            ibtn_atendimentos.Click += ibtn_atendimentos_Click;
            // 
            // ibtn_movEstoque
            // 
            ibtn_movEstoque.Cursor = Cursors.Hand;
            ibtn_movEstoque.FlatAppearance.BorderSize = 0;
            ibtn_movEstoque.FlatStyle = FlatStyle.Flat;
            ibtn_movEstoque.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_movEstoque.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_movEstoque.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            ibtn_movEstoque.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_movEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_movEstoque.IconSize = 32;
            ibtn_movEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_movEstoque.Location = new Point(4, 378);
            ibtn_movEstoque.Name = "ibtn_movEstoque";
            ibtn_movEstoque.Padding = new Padding(10, 0, 20, 0);
            ibtn_movEstoque.Size = new Size(216, 60);
            ibtn_movEstoque.TabIndex = 13;
            ibtn_movEstoque.Text = "Mov. Estoque";
            ibtn_movEstoque.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_movEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_movEstoque.UseVisualStyleBackColor = true;
            ibtn_movEstoque.Click += ibtn_movEstoque_Click;
            // 
            // ibtn_saldoEstoque
            // 
            ibtn_saldoEstoque.Cursor = Cursors.Hand;
            ibtn_saldoEstoque.FlatAppearance.BorderSize = 0;
            ibtn_saldoEstoque.FlatStyle = FlatStyle.Flat;
            ibtn_saldoEstoque.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_saldoEstoque.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_saldoEstoque.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            ibtn_saldoEstoque.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_saldoEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_saldoEstoque.IconSize = 32;
            ibtn_saldoEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_saldoEstoque.Location = new Point(4, 441);
            ibtn_saldoEstoque.Name = "ibtn_saldoEstoque";
            ibtn_saldoEstoque.Padding = new Padding(10, 0, 20, 0);
            ibtn_saldoEstoque.Size = new Size(216, 60);
            ibtn_saldoEstoque.TabIndex = 14;
            ibtn_saldoEstoque.Text = "Saldo Estoque";
            ibtn_saldoEstoque.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_saldoEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_saldoEstoque.UseVisualStyleBackColor = true;
            ibtn_saldoEstoque.Click += ibtn_saldoEstoque_Click;
            // 
            // ibtn_calendario
            // 
            ibtn_calendario.FlatAppearance.BorderSize = 0;
            ibtn_calendario.FlatStyle = FlatStyle.Flat;
            ibtn_calendario.Font = new Font("Segoe UI", 11.25F);
            ibtn_calendario.ForeColor = Color.FromArgb(209, 213, 219);
            ibtn_calendario.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            ibtn_calendario.IconColor = Color.FromArgb(209, 213, 219);
            ibtn_calendario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_calendario.IconSize = 32;
            ibtn_calendario.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_calendario.Location = new Point(4, 567);
            ibtn_calendario.Name = "ibtn_calendario";
            ibtn_calendario.Padding = new Padding(10, 0, 20, 0);
            ibtn_calendario.Size = new Size(216, 60);
            ibtn_calendario.TabIndex = 15;
            ibtn_calendario.Text = "Calendário";
            ibtn_calendario.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_calendario.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_calendario.UseVisualStyleBackColor = true;
            ibtn_calendario.Click += ibtn_calendario_Click;
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
            ibtn_config.Location = new Point(4, 504);
            ibtn_config.Name = "ibtn_config";
            ibtn_config.Padding = new Padding(10, 0, 20, 0);
            ibtn_config.Size = new Size(216, 60);
            ibtn_config.TabIndex = 15;
            ibtn_config.Text = "Configurações";
            ibtn_config.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_config.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_config.UseVisualStyleBackColor = true;
            ibtn_config.Click += ibtn_config_Click;
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
            ibtn_logout.Location = new Point(3, 630);
            ibtn_logout.Name = "ibtn_logout";
            ibtn_logout.Padding = new Padding(10, 0, 20, 0);
            ibtn_logout.Size = new Size(216, 60);
            ibtn_logout.TabIndex = 16;
            ibtn_logout.Text = "Log Out";
            ibtn_logout.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_logout.UseVisualStyleBackColor = true;
            ibtn_logout.Click += ibtn_logout_Click;
            // 
            // dragControl1
            // 
            dragControl1.SelectControl = panel_header;
            // 
            // panel_desktop
            // 
            panel_desktop.BackColor = Color.White;
            panel_desktop.Dock = DockStyle.Fill;
            panel_desktop.Location = new Point(239, 80);
            panel_desktop.Name = "panel_desktop";
            panel_desktop.Size = new Size(1025, 601);
            panel_desktop.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(540, 28);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 8;
            button1.Text = "Gerar Relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGerarRelatorio_Click;
            // 
            // TelaInicial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel_desktop);
            Controls.Add(panel_menu);
            Controls.Add(panel_header);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1280, 720);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Resize += TelaInicial_Resize;
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_current).EndInit();
            panel_menu.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton ibtn_categorias;
        private FontAwesome.Sharp.IconButton ibtn_clientes;
        private FontAwesome.Sharp.IconPictureBox icon_current;
        private Label lbl_title;
        private Button btn_maximize;
        private Button btn_minimize;
        private Panel panel_desktop;
        private FontAwesome.Sharp.IconButton ibtn_fornecedor;
        private FontAwesome.Sharp.IconButton ibtn_servico;
        private FontAwesome.Sharp.IconButton ibtn_atendimentos;
        private FontAwesome.Sharp.IconButton ibtn_movEstoque;
        private FontAwesome.Sharp.IconButton ibtn_saldoEstoque;
        private FontAwesome.Sharp.IconButton ibtn_calendario;
        private PictureBox btn_home;
        private Button button1;
    }
}
