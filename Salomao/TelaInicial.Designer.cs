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
            panel_Menu = new Panel();
            btn_Home = new Label();
            ibtn_Logout = new FontAwesome.Sharp.IconButton();
            ibtn_Config = new FontAwesome.Sharp.IconButton();
            ibtn_Servicos = new FontAwesome.Sharp.IconButton();
            ibtn_Veiculos = new FontAwesome.Sharp.IconButton();
            ibtn_Clientes = new FontAwesome.Sharp.IconButton();
            ibtn_Produtos = new FontAwesome.Sharp.IconButton();
            panel_Header = new Panel();
            btn_close = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            dragControl1 = new DragControl();
            panel_Menu.SuspendLayout();
            panel_Header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = Color.Black;
            panel_Menu.Controls.Add(btn_Home);
            panel_Menu.Controls.Add(ibtn_Logout);
            panel_Menu.Controls.Add(ibtn_Config);
            panel_Menu.Controls.Add(ibtn_Servicos);
            panel_Menu.Controls.Add(ibtn_Veiculos);
            panel_Menu.Controls.Add(ibtn_Clientes);
            panel_Menu.Controls.Add(ibtn_Produtos);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(222, 606);
            panel_Menu.TabIndex = 0;
            // 
            // btn_Home
            // 
            btn_Home.AutoSize = true;
            btn_Home.Cursor = Cursors.Hand;
            btn_Home.Font = new Font("Condiment", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Home.ForeColor = Color.White;
            btn_Home.Location = new Point(4, 7);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(212, 73);
            btn_Home.TabIndex = 2;
            btn_Home.Text = "Auto Peças";
            btn_Home.Click += btn_Home_Click;
            // 
            // ibtn_Logout
            // 
            ibtn_Logout.Cursor = Cursors.Hand;
            ibtn_Logout.FlatAppearance.BorderSize = 0;
            ibtn_Logout.FlatStyle = FlatStyle.Flat;
            ibtn_Logout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_Logout.ForeColor = Color.White;
            ibtn_Logout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            ibtn_Logout.IconColor = Color.White;
            ibtn_Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Logout.IconSize = 32;
            ibtn_Logout.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_Logout.Location = new Point(3, 487);
            ibtn_Logout.Name = "ibtn_Logout";
            ibtn_Logout.Padding = new Padding(10, 0, 20, 0);
            ibtn_Logout.Size = new Size(216, 60);
            ibtn_Logout.TabIndex = 9;
            ibtn_Logout.Text = "Log Out";
            ibtn_Logout.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_Logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Logout.UseVisualStyleBackColor = true;
            ibtn_Logout.Click += ibtn_Logout_Click;
            // 
            // ibtn_Config
            // 
            ibtn_Config.Cursor = Cursors.Hand;
            ibtn_Config.FlatAppearance.BorderSize = 0;
            ibtn_Config.FlatStyle = FlatStyle.Flat;
            ibtn_Config.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_Config.ForeColor = Color.White;
            ibtn_Config.IconChar = FontAwesome.Sharp.IconChar.Cog;
            ibtn_Config.IconColor = Color.White;
            ibtn_Config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Config.IconSize = 32;
            ibtn_Config.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_Config.Location = new Point(3, 424);
            ibtn_Config.Name = "ibtn_Config";
            ibtn_Config.Padding = new Padding(10, 0, 20, 0);
            ibtn_Config.Size = new Size(216, 60);
            ibtn_Config.TabIndex = 8;
            ibtn_Config.Text = "Configurações";
            ibtn_Config.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_Config.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Config.UseVisualStyleBackColor = true;
            ibtn_Config.Click += ibtn_Config_Click;
            // 
            // ibtn_Servicos
            // 
            ibtn_Servicos.Cursor = Cursors.Hand;
            ibtn_Servicos.FlatAppearance.BorderSize = 0;
            ibtn_Servicos.FlatStyle = FlatStyle.Flat;
            ibtn_Servicos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_Servicos.ForeColor = Color.White;
            ibtn_Servicos.IconChar = FontAwesome.Sharp.IconChar.Tv;
            ibtn_Servicos.IconColor = Color.White;
            ibtn_Servicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Servicos.IconSize = 32;
            ibtn_Servicos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_Servicos.Location = new Point(3, 361);
            ibtn_Servicos.Name = "ibtn_Servicos";
            ibtn_Servicos.Padding = new Padding(10, 0, 20, 0);
            ibtn_Servicos.Size = new Size(216, 60);
            ibtn_Servicos.TabIndex = 7;
            ibtn_Servicos.Text = "Serviços";
            ibtn_Servicos.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_Servicos.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Servicos.UseVisualStyleBackColor = true;
            ibtn_Servicos.Click += ibtn_Servicos_Click;
            // 
            // ibtn_Veiculos
            // 
            ibtn_Veiculos.Cursor = Cursors.Hand;
            ibtn_Veiculos.FlatAppearance.BorderSize = 0;
            ibtn_Veiculos.FlatStyle = FlatStyle.Flat;
            ibtn_Veiculos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_Veiculos.ForeColor = Color.White;
            ibtn_Veiculos.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            ibtn_Veiculos.IconColor = Color.White;
            ibtn_Veiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Veiculos.IconSize = 32;
            ibtn_Veiculos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_Veiculos.Location = new Point(3, 298);
            ibtn_Veiculos.Name = "ibtn_Veiculos";
            ibtn_Veiculos.Padding = new Padding(10, 0, 20, 0);
            ibtn_Veiculos.Size = new Size(216, 60);
            ibtn_Veiculos.TabIndex = 6;
            ibtn_Veiculos.Text = "Veículos";
            ibtn_Veiculos.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_Veiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Veiculos.UseVisualStyleBackColor = true;
            ibtn_Veiculos.Click += ibtn_Veiculos_Click;
            // 
            // ibtn_Clientes
            // 
            ibtn_Clientes.Cursor = Cursors.Hand;
            ibtn_Clientes.FlatAppearance.BorderSize = 0;
            ibtn_Clientes.FlatStyle = FlatStyle.Flat;
            ibtn_Clientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_Clientes.ForeColor = Color.White;
            ibtn_Clientes.IconChar = FontAwesome.Sharp.IconChar.Male;
            ibtn_Clientes.IconColor = Color.White;
            ibtn_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Clientes.IconSize = 32;
            ibtn_Clientes.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_Clientes.Location = new Point(3, 235);
            ibtn_Clientes.Name = "ibtn_Clientes";
            ibtn_Clientes.Padding = new Padding(10, 0, 20, 0);
            ibtn_Clientes.Size = new Size(216, 60);
            ibtn_Clientes.TabIndex = 5;
            ibtn_Clientes.Text = "Clientes";
            ibtn_Clientes.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_Clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Clientes.UseVisualStyleBackColor = true;
            ibtn_Clientes.Click += ibtn_Clientes_Click;
            // 
            // ibtn_Produtos
            // 
            ibtn_Produtos.BackColor = Color.Black;
            ibtn_Produtos.Cursor = Cursors.Hand;
            ibtn_Produtos.FlatAppearance.BorderSize = 0;
            ibtn_Produtos.FlatStyle = FlatStyle.Flat;
            ibtn_Produtos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtn_Produtos.ForeColor = Color.White;
            ibtn_Produtos.IconChar = FontAwesome.Sharp.IconChar.Shop;
            ibtn_Produtos.IconColor = Color.White;
            ibtn_Produtos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Produtos.IconSize = 32;
            ibtn_Produtos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtn_Produtos.Location = new Point(3, 172);
            ibtn_Produtos.Name = "ibtn_Produtos";
            ibtn_Produtos.Padding = new Padding(10, 0, 20, 0);
            ibtn_Produtos.Size = new Size(216, 60);
            ibtn_Produtos.TabIndex = 4;
            ibtn_Produtos.Text = "Produtos";
            ibtn_Produtos.TextAlign = ContentAlignment.MiddleLeft;
            ibtn_Produtos.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Produtos.UseVisualStyleBackColor = false;
            ibtn_Produtos.Click += ibtn_Produtos_Click;
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.Black;
            panel_Header.Controls.Add(btn_close);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(222, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(983, 80);
            panel_Header.TabIndex = 1;
            // 
            // btn_close
            // 
            btn_close.AccessibleName = "";
            btn_close.BackColor = SystemColors.Control;
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Cursor = Cursors.Hand;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Location = new Point(947, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(36, 36);
            btn_close.TabIndex = 2;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // dragControl1
            // 
            dragControl1.SelectControl = panel_Header;
            // 
            // TelaInicial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1205, 606);
            Controls.Add(panel_Header);
            Controls.Add(panel_Menu);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_Menu.ResumeLayout(false);
            panel_Menu.PerformLayout();
            panel_Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Menu;
        private Panel panel_Header;
        private Button btn_close;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DragControl dragControl1;
        private FontAwesome.Sharp.IconButton ibtn_Produtos;
        private FontAwesome.Sharp.IconButton ibtn_Logout;
        private FontAwesome.Sharp.IconButton ibtn_Config;
        private FontAwesome.Sharp.IconButton ibtn_Servicos;
        private FontAwesome.Sharp.IconButton ibtn_Veiculos;
        private FontAwesome.Sharp.IconButton ibtn_Clientes;
        private Label btn_Home;
    }
}
