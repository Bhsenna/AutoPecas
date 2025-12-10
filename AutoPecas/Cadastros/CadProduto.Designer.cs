namespace AutoPecas.Cadastros
{
    partial class CadProduto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            mainContainer = new Panel();
            cardGrid = new Panel();
            lbTituloGrid = new Label();
            dataGridView1 = new DataGridView();
            cardBotoes = new Panel();
            btnGravar = new Button();
            btnLimpar = new Button();
            cardProduto = new Panel();
            lbTituloProduto = new Label();
            lbNomeProd = new Label();
            tbNomeProd = new TextBox();
            lbCodigo = new Label();
            tbCodigo = new TextBox();
            lbCategoria = new Label();
            cbCategoria = new ComboBox();
            lbFornecedor = new Label();
            cbFornecedor = new ComboBox();
            lbMarca = new Label();
            tbMarca = new TextBox();
            lbCustoAquisicao = new Label();
            tbCustoAquisicao = new DecimalTextbox();
            lbDescricao = new Label();
            tbDescricao = new TextBox();
            mainContainer.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cardBotoes.SuspendLayout();
            cardProduto.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGrid);
            mainContainer.Controls.Add(cardBotoes);
            mainContainer.Controls.Add(cardProduto);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(20);
            mainContainer.Size = new Size(1200, 800);
            mainContainer.TabIndex = 0;
            // 
            // cardGrid
            // 
            cardGrid.BackColor = Color.White;
            cardGrid.Controls.Add(lbTituloGrid);
            cardGrid.Controls.Add(dataGridView1);
            cardGrid.Location = new Point(20, 420);
            cardGrid.Name = "cardGrid";
            cardGrid.Padding = new Padding(20);
            cardGrid.Size = new Size(1160, 360);
            cardGrid.TabIndex = 2;
            // 
            // lbTituloGrid
            // 
            lbTituloGrid.AutoSize = true;
            lbTituloGrid.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGrid.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGrid.Location = new Point(20, 20);
            lbTituloGrid.Name = "lbTituloGrid";
            lbTituloGrid.Size = new Size(190, 25);
            lbTituloGrid.TabIndex = 0;
            lbTituloGrid.Text = "📋 Lista de Produtos";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(20, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1120, 285);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cardBotoes
            // 
            cardBotoes.BackColor = Color.Transparent;
            cardBotoes.Controls.Add(btnGravar);
            cardBotoes.Controls.Add(btnLimpar);
            cardBotoes.Location = new Point(20, 340);
            cardBotoes.Name = "cardBotoes";
            cardBotoes.Size = new Size(1160, 60);
            cardBotoes.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.FromArgb(25, 135, 84);
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(20, 15);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(120, 40);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "💾 Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(150, 15);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 40);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "🗑️ Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // cardProduto
            // 
            cardProduto.BackColor = Color.White;
            cardProduto.Controls.Add(lbTituloProduto);
            cardProduto.Controls.Add(lbNomeProd);
            cardProduto.Controls.Add(tbNomeProd);
            cardProduto.Controls.Add(lbCodigo);
            cardProduto.Controls.Add(tbCodigo);
            cardProduto.Controls.Add(lbCategoria);
            cardProduto.Controls.Add(cbCategoria);
            cardProduto.Controls.Add(lbFornecedor);
            cardProduto.Controls.Add(cbFornecedor);
            cardProduto.Controls.Add(lbMarca);
            cardProduto.Controls.Add(tbMarca);
            cardProduto.Controls.Add(lbCustoAquisicao);
            cardProduto.Controls.Add(tbCustoAquisicao);
            cardProduto.Controls.Add(lbDescricao);
            cardProduto.Controls.Add(tbDescricao);
            cardProduto.Location = new Point(20, 20);
            cardProduto.Name = "cardProduto";
            cardProduto.Padding = new Padding(20);
            cardProduto.Size = new Size(1160, 300);
            cardProduto.TabIndex = 0;
            // 
            // lbTituloProduto
            // 
            lbTituloProduto.AutoSize = true;
            lbTituloProduto.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloProduto.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloProduto.Location = new Point(20, 20);
            lbTituloProduto.Name = "lbTituloProduto";
            lbTituloProduto.Size = new Size(204, 25);
            lbTituloProduto.TabIndex = 0;
            lbTituloProduto.Text = "📦 Dados do Produto";
            // 
            // lbNomeProd
            // 
            lbNomeProd.AutoSize = true;
            lbNomeProd.Font = new Font("Segoe UI", 10F);
            lbNomeProd.ForeColor = Color.FromArgb(73, 80, 87);
            lbNomeProd.Location = new Point(20, 60);
            lbNomeProd.Name = "lbNomeProd";
            lbNomeProd.Size = new Size(49, 19);
            lbNomeProd.TabIndex = 1;
            lbNomeProd.Text = "Nome:";
            // 
            // tbNomeProd
            // 
            tbNomeProd.Font = new Font("Segoe UI", 10F);
            tbNomeProd.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeProd.Location = new Point(20, 85);
            tbNomeProd.MaxLength = 250;
            tbNomeProd.Name = "tbNomeProd";
            tbNomeProd.Size = new Size(250, 25);
            tbNomeProd.TabIndex = 2;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Segoe UI", 10F);
            lbCodigo.ForeColor = Color.FromArgb(73, 80, 87);
            lbCodigo.Location = new Point(300, 60);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(56, 19);
            lbCodigo.TabIndex = 3;
            lbCodigo.Text = "Código:";
            // 
            // tbCodigo
            // 
            tbCodigo.Font = new Font("Segoe UI", 10F);
            tbCodigo.ForeColor = Color.FromArgb(55, 65, 81);
            tbCodigo.Location = new Point(300, 85);
            tbCodigo.MaxLength = 250;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(200, 25);
            tbCodigo.TabIndex = 4;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Segoe UI", 10F);
            lbCategoria.ForeColor = Color.FromArgb(73, 80, 87);
            lbCategoria.Location = new Point(530, 60);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(71, 19);
            lbCategoria.TabIndex = 5;
            lbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Font = new Font("Segoe UI", 10F);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(530, 85);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(200, 25);
            cbCategoria.TabIndex = 6;
            // 
            // lbFornecedor
            // 
            lbFornecedor.AutoSize = true;
            lbFornecedor.Font = new Font("Segoe UI", 10F);
            lbFornecedor.ForeColor = Color.FromArgb(73, 80, 87);
            lbFornecedor.Location = new Point(760, 60);
            lbFornecedor.Name = "lbFornecedor";
            lbFornecedor.Size = new Size(81, 19);
            lbFornecedor.TabIndex = 7;
            lbFornecedor.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            cbFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFornecedor.Font = new Font("Segoe UI", 10F);
            cbFornecedor.ForeColor = Color.FromArgb(55, 65, 81);
            cbFornecedor.Location = new Point(760, 85);
            cbFornecedor.MaxLength = 250;
            cbFornecedor.Name = "cbFornecedor";
            cbFornecedor.Size = new Size(200, 25);
            cbFornecedor.TabIndex = 8;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Segoe UI", 10F);
            lbMarca.ForeColor = Color.FromArgb(73, 80, 87);
            lbMarca.Location = new Point(20, 130);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(50, 19);
            lbMarca.TabIndex = 9;
            lbMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            tbMarca.Font = new Font("Segoe UI", 10F);
            tbMarca.ForeColor = Color.FromArgb(55, 65, 81);
            tbMarca.Location = new Point(20, 155);
            tbMarca.MaxLength = 250;
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(250, 25);
            tbMarca.TabIndex = 10;
            // 
            // lbCustoAquisicao
            // 
            lbCustoAquisicao.AutoSize = true;
            lbCustoAquisicao.Font = new Font("Segoe UI", 10F);
            lbCustoAquisicao.ForeColor = Color.FromArgb(73, 80, 87);
            lbCustoAquisicao.Location = new Point(300, 130);
            lbCustoAquisicao.Name = "lbCustoAquisicao";
            lbCustoAquisicao.Size = new Size(110, 19);
            lbCustoAquisicao.TabIndex = 11;
            lbCustoAquisicao.Text = "Custo Aquisição:";
            // 
            // tbCustoAquisicao
            // 
            tbCustoAquisicao.Font = new Font("Segoe UI", 10F);
            tbCustoAquisicao.ForeColor = Color.FromArgb(55, 65, 81);
            tbCustoAquisicao.Location = new Point(300, 155);
            tbCustoAquisicao.Name = "tbCustoAquisicao";
            tbCustoAquisicao.Size = new Size(200, 25);
            tbCustoAquisicao.TabIndex = 12;
            tbCustoAquisicao.TextAlign = HorizontalAlignment.Right;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 10F);
            lbDescricao.ForeColor = Color.FromArgb(73, 80, 87);
            lbDescricao.Location = new Point(20, 200);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(70, 19);
            lbDescricao.TabIndex = 13;
            lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            tbDescricao.Font = new Font("Segoe UI", 10F);
            tbDescricao.ForeColor = Color.FromArgb(55, 65, 81);
            tbDescricao.Location = new Point(20, 225);
            tbDescricao.MaxLength = 1000;
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.ScrollBars = ScrollBars.Vertical;
            tbDescricao.Size = new Size(940, 55);
            tbDescricao.TabIndex = 14;
            // 
            // CadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "CadProduto";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cardBotoes.ResumeLayout(false);
            cardProduto.ResumeLayout(false);
            cardProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Controles principais
        private Label lbNomeProd;
        private TextBox tbNomeProd;
        private Label lbFornecedor;
        private ComboBox cbFornecedor;
        private Label lbCategoria;
        private ComboBox cbCategoria;
        private Label lbCustoAquisicao;
        private DecimalTextbox tbCustoAquisicao;
        private Label lbMarca;
        private TextBox tbMarca;
        private Label lbCodigo;
        private TextBox tbCodigo;
        private Label lbDescricao;
        private TextBox tbDescricao;
        private Button btnGravar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
        
        // Cards modernos
        private Panel mainContainer;
        private Panel cardProduto;
        private Panel cardGrid;
        private Panel cardBotoes;
        
        // Labels de título
        private Label lbTituloProduto;
        private Label lbTituloGrid;
    }
}
