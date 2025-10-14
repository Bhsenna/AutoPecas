namespace Salomao.Cadastros
{
    partial class CadServicos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainContainer = new Panel();
            cardGrid = new Panel();
            tbPesquisa = new TextBox();
            label1 = new Label();
            lbTituloGrid = new Label();
            dataGridView1 = new DataGridView();
            cardBotoes = new Panel();
            btnGravar = new Button();
            btnLimpar = new Button();
            cardProdutos = new Panel();
            lbTituloProdutos = new Label();
            lbProdutos = new Label();
            cbProdutoServico = new ComboBox();
            btnAdicionarProduto = new Button();
            btnRemoverProduto = new Button();
            dataGridProdutos = new DataGridView();
            cardServico = new Panel();
            lbTituloServico = new Label();
            lbNomeServico = new Label();
            tbNomeServico = new TextBox();
            lbDescricao = new Label();
            tbDescricao = new TextBox();
            lbMargem = new Label();
            tbMargem = new DecimalTextbox();
            lbCustoServico = new Label();
            tbCustoServico = new DecimalTextbox();
            mainContainer.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cardBotoes.SuspendLayout();
            cardProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            cardServico.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGrid);
            mainContainer.Controls.Add(cardBotoes);
            mainContainer.Controls.Add(cardProdutos);
            mainContainer.Controls.Add(cardServico);
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
            cardGrid.Controls.Add(tbPesquisa);
            cardGrid.Controls.Add(label1);
            cardGrid.Controls.Add(lbTituloGrid);
            cardGrid.Controls.Add(dataGridView1);
            cardGrid.Location = new Point(20, 560);
            cardGrid.Name = "cardGrid";
            cardGrid.Padding = new Padding(20);
            cardGrid.Size = new Size(1160, 365);
            cardGrid.TabIndex = 3;
            // 
            // tbPesquisa
            // 
            tbPesquisa.Location = new Point(446, 25);
            tbPesquisa.Name = "tbPesquisa";
            tbPesquisa.Size = new Size(275, 23);
            tbPesquisa.TabIndex = 3;
            tbPesquisa.TextChanged += tbPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 2;
            label1.Text = "Pesquisa";
            // 
            // lbTituloGrid
            // 
            lbTituloGrid.AutoSize = true;
            lbTituloGrid.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGrid.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGrid.Location = new Point(20, 20);
            lbTituloGrid.Name = "lbTituloGrid";
            lbTituloGrid.Size = new Size(181, 25);
            lbTituloGrid.TabIndex = 0;
            lbTituloGrid.Text = "📋 Lista de Serviços";
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
            dataGridView1.Size = new Size(1120, 290);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cardBotoes
            // 
            cardBotoes.BackColor = Color.Transparent;
            cardBotoes.Controls.Add(btnGravar);
            cardBotoes.Controls.Add(btnLimpar);
            cardBotoes.Location = new Point(620, 240);
            cardBotoes.Name = "cardBotoes";
            cardBotoes.Size = new Size(560, 60);
            cardBotoes.TabIndex = 2;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.FromArgb(25, 135, 84);
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(15, 15);
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
            btnLimpar.Location = new Point(145, 15);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 40);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "🗑️ Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // cardProdutos
            // 
            cardProdutos.BackColor = Color.White;
            cardProdutos.Controls.Add(lbTituloProdutos);
            cardProdutos.Controls.Add(lbProdutos);
            cardProdutos.Controls.Add(cbProdutoServico);
            cardProdutos.Controls.Add(btnAdicionarProduto);
            cardProdutos.Controls.Add(btnRemoverProduto);
            cardProdutos.Controls.Add(dataGridProdutos);
            cardProdutos.Location = new Point(20, 240);
            cardProdutos.Name = "cardProdutos";
            cardProdutos.Padding = new Padding(20);
            cardProdutos.Size = new Size(580, 300);
            cardProdutos.TabIndex = 1;
            // 
            // lbTituloProdutos
            // 
            lbTituloProdutos.AutoSize = true;
            lbTituloProdutos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloProdutos.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloProdutos.Location = new Point(20, 20);
            lbTituloProdutos.Name = "lbTituloProdutos";
            lbTituloProdutos.Size = new Size(222, 25);
            lbTituloProdutos.TabIndex = 0;
            lbTituloProdutos.Text = "📦 Produtos do Serviço";
            // 
            // lbProdutos
            // 
            lbProdutos.AutoSize = true;
            lbProdutos.Font = new Font("Segoe UI", 10F);
            lbProdutos.ForeColor = Color.FromArgb(73, 80, 87);
            lbProdutos.Location = new Point(20, 60);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(135, 19);
            lbProdutos.TabIndex = 1;
            lbProdutos.Text = "Produtos do Serviço:";
            // 
            // cbProdutoServico
            // 
            cbProdutoServico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProdutoServico.Font = new Font("Segoe UI", 10F);
            cbProdutoServico.Location = new Point(20, 85);
            cbProdutoServico.Name = "cbProdutoServico";
            cbProdutoServico.Size = new Size(250, 25);
            cbProdutoServico.TabIndex = 2;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.BackColor = Color.FromArgb(13, 110, 253);
            btnAdicionarProduto.FlatAppearance.BorderSize = 0;
            btnAdicionarProduto.FlatStyle = FlatStyle.Flat;
            btnAdicionarProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionarProduto.ForeColor = Color.White;
            btnAdicionarProduto.Location = new Point(290, 83);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(120, 30);
            btnAdicionarProduto.TabIndex = 3;
            btnAdicionarProduto.Text = "➕ Adicionar";
            btnAdicionarProduto.UseVisualStyleBackColor = false;
            // 
            // btnRemoverProduto
            // 
            btnRemoverProduto.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoverProduto.FlatAppearance.BorderSize = 0;
            btnRemoverProduto.FlatStyle = FlatStyle.Flat;
            btnRemoverProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoverProduto.ForeColor = Color.White;
            btnRemoverProduto.Location = new Point(420, 83);
            btnRemoverProduto.Name = "btnRemoverProduto";
            btnRemoverProduto.Size = new Size(120, 30);
            btnRemoverProduto.TabIndex = 4;
            btnRemoverProduto.Text = "➖ Remover";
            btnRemoverProduto.UseVisualStyleBackColor = false;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProdutos.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridProdutos.BorderStyle = BorderStyle.None;
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Font = new Font("Segoe UI", 9F);
            dataGridProdutos.Location = new Point(20, 125);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.Size = new Size(540, 155);
            dataGridProdutos.TabIndex = 5;
            // 
            // cardServico
            // 
            cardServico.BackColor = Color.White;
            cardServico.Controls.Add(lbTituloServico);
            cardServico.Controls.Add(lbNomeServico);
            cardServico.Controls.Add(tbNomeServico);
            cardServico.Controls.Add(lbDescricao);
            cardServico.Controls.Add(tbDescricao);
            cardServico.Controls.Add(lbMargem);
            cardServico.Controls.Add(tbMargem);
            cardServico.Controls.Add(lbCustoServico);
            cardServico.Controls.Add(tbCustoServico);
            cardServico.Location = new Point(20, 20);
            cardServico.Name = "cardServico";
            cardServico.Padding = new Padding(20);
            cardServico.Size = new Size(1160, 200);
            cardServico.TabIndex = 0;
            // 
            // lbTituloServico
            // 
            lbTituloServico.AutoSize = true;
            lbTituloServico.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloServico.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloServico.Location = new Point(20, 20);
            lbTituloServico.Name = "lbTituloServico";
            lbTituloServico.Size = new Size(195, 25);
            lbTituloServico.TabIndex = 0;
            lbTituloServico.Text = "🔧 Dados do Serviço";
            // 
            // lbNomeServico
            // 
            lbNomeServico.AutoSize = true;
            lbNomeServico.Font = new Font("Segoe UI", 10F);
            lbNomeServico.ForeColor = Color.FromArgb(73, 80, 87);
            lbNomeServico.Location = new Point(20, 60);
            lbNomeServico.Name = "lbNomeServico";
            lbNomeServico.Size = new Size(96, 19);
            lbNomeServico.TabIndex = 1;
            lbNomeServico.Text = "Nome Serviço:";
            // 
            // tbNomeServico
            // 
            tbNomeServico.Font = new Font("Segoe UI", 10F);
            tbNomeServico.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeServico.Location = new Point(20, 85);
            tbNomeServico.MaxLength = 250;
            tbNomeServico.Name = "tbNomeServico";
            tbNomeServico.Size = new Size(250, 25);
            tbNomeServico.TabIndex = 2;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 10F);
            lbDescricao.ForeColor = Color.FromArgb(73, 80, 87);
            lbDescricao.Location = new Point(386, 60);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(70, 19);
            lbDescricao.TabIndex = 3;
            lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            tbDescricao.Font = new Font("Segoe UI", 10F);
            tbDescricao.ForeColor = Color.FromArgb(55, 65, 81);
            tbDescricao.Location = new Point(386, 85);
            tbDescricao.MaxLength = 500;
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.ScrollBars = ScrollBars.Vertical;
            tbDescricao.Size = new Size(300, 95);
            tbDescricao.TabIndex = 4;
            // 
            // lbMargem
            // 
            lbMargem.AutoSize = true;
            lbMargem.Font = new Font("Segoe UI", 10F);
            lbMargem.ForeColor = Color.FromArgb(73, 80, 87);
            lbMargem.Location = new Point(20, 130);
            lbMargem.Name = "lbMargem";
            lbMargem.Size = new Size(144, 19);
            lbMargem.TabIndex = 5;
            lbMargem.Text = "Margem de Lucro (%):";
            // 
            // tbMargem
            // 
            tbMargem.Font = new Font("Segoe UI", 10F);
            tbMargem.ForeColor = Color.FromArgb(55, 65, 81);
            tbMargem.Location = new Point(20, 155);
            tbMargem.Name = "tbMargem";
            tbMargem.Size = new Size(150, 25);
            tbMargem.TabIndex = 6;
            tbMargem.TextAlign = HorizontalAlignment.Right;
            // 
            // lbCustoServico
            // 
            lbCustoServico.AutoSize = true;
            lbCustoServico.Font = new Font("Segoe UI", 10F);
            lbCustoServico.ForeColor = Color.FromArgb(73, 80, 87);
            lbCustoServico.Location = new Point(200, 130);
            lbCustoServico.Name = "lbCustoServico";
            lbCustoServico.Size = new Size(115, 19);
            lbCustoServico.TabIndex = 7;
            lbCustoServico.Text = "Custo do Serviço:";
            // 
            // tbCustoServico
            // 
            tbCustoServico.Font = new Font("Segoe UI", 10F);
            tbCustoServico.Location = new Point(200, 155);
            tbCustoServico.Name = "tbCustoServico";
            tbCustoServico.ReadOnly = true;
            tbCustoServico.Size = new Size(150, 25);
            tbCustoServico.TabIndex = 8;
            tbCustoServico.TextAlign = HorizontalAlignment.Right;
            // 
            // CadServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "CadServicos";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cardBotoes.ResumeLayout(false);
            cardProdutos.ResumeLayout(false);
            cardProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            cardServico.ResumeLayout(false);
            cardServico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Controles do serviço
        private Label lbNomeServico;
        private TextBox tbNomeServico;
        private Label lbDescricao;
        private TextBox tbDescricao;
        private Label lbMargem;
        private DecimalTextbox tbMargem;
        private Label lbCustoServico;
        private DecimalTextbox tbCustoServico;
        
        // Controles de produtos
        private Button btnRemoverProduto;
        private Button btnAdicionarProduto;
        private ComboBox cbProdutoServico;
        private Label lbProdutos;
        private DataGridView dataGridProdutos;
        
        // Controles principais
        private Button btnGravar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
        
        // Cards modernos
        private Panel mainContainer;
        private Panel cardServico;
        private Panel cardProdutos;
        private Panel cardGrid;
        private Panel cardBotoes;
        
        // Labels de título
        private Label lbTituloServico;
        private Label lbTituloProdutos;
        private Label lbTituloGrid;
        private Label label1;
        private TextBox tbPesquisa;
    }
}
