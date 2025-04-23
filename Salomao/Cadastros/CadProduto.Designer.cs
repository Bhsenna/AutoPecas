namespace Salomao.Cadastros
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
            tbNomeProd = new TextBox();
            lbNomeProd = new Label();
            lbFornecedor = new Label();
            tbFornecedor = new TextBox();
            lbCategoria = new Label();
            tbCategoria = new TextBox();
            lbCustoAquisicao = new Label();
            dataGridView1 = new DataGridView();
            btnGravar = new Button();
            lbMarca = new Label();
            tbMarca = new TextBox();
            lbCodigo = new Label();
            tbCodigo = new TextBox();
            btnLimpar = new Button();
            lbDescricao = new Label();
            tbDescricao = new TextBox();
            tbCustoAquisicao = new DecimalTextbox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbNomeProd
            // 
            tbNomeProd.Location = new Point(25, 47);
            tbNomeProd.MaxLength = 250;
            tbNomeProd.Name = "tbNomeProd";
            tbNomeProd.Size = new Size(200, 23);
            tbNomeProd.TabIndex = 0;
            // 
            // lbNomeProd
            // 
            lbNomeProd.AutoSize = true;
            lbNomeProd.Font = new Font("Segoe UI", 12F);
            lbNomeProd.Location = new Point(25, 19);
            lbNomeProd.Name = "lbNomeProd";
            lbNomeProd.Size = new Size(56, 21);
            lbNomeProd.TabIndex = 1;
            lbNomeProd.Text = "Nome:";
            // 
            // lbFornecedor
            // 
            lbFornecedor.AutoSize = true;
            lbFornecedor.Font = new Font("Segoe UI", 12F);
            lbFornecedor.Location = new Point(25, 88);
            lbFornecedor.Name = "lbFornecedor";
            lbFornecedor.Size = new Size(92, 21);
            lbFornecedor.TabIndex = 3;
            lbFornecedor.Text = "Fornecedor:";
            // 
            // tbFornecedor
            // 
            tbFornecedor.Location = new Point(25, 112);
            tbFornecedor.MaxLength = 250;
            tbFornecedor.Name = "tbFornecedor";
            tbFornecedor.Size = new Size(200, 23);
            tbFornecedor.TabIndex = 2;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Segoe UI", 12F);
            lbCategoria.Location = new Point(25, 147);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(80, 21);
            lbCategoria.TabIndex = 5;
            lbCategoria.Text = "Categoria:";
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(25, 171);
            tbCategoria.MaxLength = 250;
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(200, 23);
            tbCategoria.TabIndex = 3;
            // 
            // lbCustoAquisicao
            // 
            lbCustoAquisicao.AutoSize = true;
            lbCustoAquisicao.Font = new Font("Segoe UI", 12F);
            lbCustoAquisicao.Location = new Point(25, 206);
            lbCustoAquisicao.Name = "lbCustoAquisicao";
            lbCustoAquisicao.Size = new Size(124, 21);
            lbCustoAquisicao.TabIndex = 7;
            lbCustoAquisicao.Text = "Custo Aquisição:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(594, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 517);
            dataGridView1.TabIndex = 9;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGravar.BackColor = Color.FromArgb(0, 123, 255);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(481, 470);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Segoe UI", 12F);
            lbMarca.Location = new Point(25, 272);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(56, 21);
            lbMarca.TabIndex = 11;
            lbMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(25, 296);
            tbMarca.MaxLength = 250;
            tbMarca.Name = "tbMarca";
            tbMarca.ScrollBars = ScrollBars.Vertical;
            tbMarca.Size = new Size(200, 23);
            tbMarca.TabIndex = 5;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Segoe UI", 12F);
            lbCodigo.Location = new Point(282, 19);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(63, 21);
            lbCodigo.TabIndex = 13;
            lbCodigo.Text = "Codigo:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(282, 47);
            tbCodigo.MaxLength = 250;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(200, 23);
            tbCodigo.TabIndex = 1;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpar.BackColor = Color.LightGray;
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(400, 470);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 12F);
            lbDescricao.Location = new Point(25, 331);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(80, 21);
            lbDescricao.TabIndex = 17;
            lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(25, 355);
            tbDescricao.MaxLength = 1000;
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.ScrollBars = ScrollBars.Vertical;
            tbDescricao.Size = new Size(457, 56);
            tbDescricao.TabIndex = 6;
            // 
            // tbCustoAquisicao
            // 
            tbCustoAquisicao.Location = new Point(25, 230);
            tbCustoAquisicao.Name = "tbCustoAquisicao";
            tbCustoAquisicao.Size = new Size(200, 23);
            tbCustoAquisicao.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 517);
            panel1.TabIndex = 19;
            // 
            // CadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(tbCustoAquisicao);
            Controls.Add(lbDescricao);
            Controls.Add(tbDescricao);
            Controls.Add(btnLimpar);
            Controls.Add(lbCodigo);
            Controls.Add(tbCodigo);
            Controls.Add(lbMarca);
            Controls.Add(tbMarca);
            Controls.Add(btnGravar);
            Controls.Add(dataGridView1);
            Controls.Add(lbCustoAquisicao);
            Controls.Add(lbCategoria);
            Controls.Add(tbCategoria);
            Controls.Add(lbFornecedor);
            Controls.Add(tbFornecedor);
            Controls.Add(lbNomeProd);
            Controls.Add(tbNomeProd);
            Controls.Add(panel1);
            Name = "CadProduto";
            Size = new Size(983, 517);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNomeProd;
        private Label lbNomeProd;
        private Label lbFornecedor;
        private TextBox tbFornecedor;
        private Label lbCategoria;
        private TextBox tbCategoria;
        private Label lbCustoAquisicao;
        private DecimalTextbox tbCustoAquisicao;
        private DataGridView dataGridView1;
        private Button btnGravar;
        private Label lbMarca;
        private TextBox tbMarca;
        private Label lbCodigo;
        private TextBox tbCodigo;
        private Button btnLimpar;
        private Label lbDescricao;
        private TextBox tbDescricao;
        private Panel panel1;
    }
}
