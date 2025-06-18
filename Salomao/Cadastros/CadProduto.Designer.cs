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
            cbFornecedor = new ComboBox();
            lbCategoria = new Label();
            cbCategoria = new ComboBox();
            lbCustoAquisicao = new Label();
            tbCustoAquisicao = new DecimalTextbox();
            lbMarca = new Label();
            tbMarca = new TextBox();
            lbCodigo = new Label();
            tbCodigo = new TextBox();
            lbDescricao = new Label();
            tbDescricao = new TextBox();
            btnGravar = new Button();
            btnLimpar = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNomeProd
            // 
            tbNomeProd.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeProd.Location = new Point(25, 47);
            tbNomeProd.MaxLength = 250;
            tbNomeProd.Name = "tbNomeProd";
            tbNomeProd.Size = new Size(200, 23);
            tbNomeProd.TabIndex = 0;
            // 
            // lbNomeProd
            // 
            lbNomeProd.AutoSize = true;
            lbNomeProd.BackColor = Color.White;
            lbNomeProd.Font = new Font("Segoe UI", 12F);
            lbNomeProd.ForeColor = Color.Black;
            lbNomeProd.Location = new Point(25, 19);
            lbNomeProd.Name = "lbNomeProd";
            lbNomeProd.Size = new Size(56, 21);
            lbNomeProd.TabIndex = 1;
            lbNomeProd.Text = "Nome:";
            // 
            // lbFornecedor
            // 
            lbFornecedor.AutoSize = true;
            lbFornecedor.BackColor = Color.White;
            lbFornecedor.Font = new Font("Segoe UI", 12F);
            lbFornecedor.ForeColor = Color.Black;
            lbFornecedor.Location = new Point(25, 88);
            lbFornecedor.Name = "lbFornecedor";
            lbFornecedor.Size = new Size(92, 21);
            lbFornecedor.TabIndex = 3;
            lbFornecedor.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            cbFornecedor.ForeColor = Color.FromArgb(55, 65, 81);
            cbFornecedor.Location = new Point(25, 116);
            cbFornecedor.MaxLength = 250;
            cbFornecedor.Name = "cbFornecedor";
            cbFornecedor.Size = new Size(200, 23);
            cbFornecedor.TabIndex = 3;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.BackColor = Color.White;
            lbCategoria.Font = new Font("Segoe UI", 12F);
            lbCategoria.ForeColor = Color.Black;
            lbCategoria.Location = new Point(539, 19);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(80, 21);
            lbCategoria.TabIndex = 5;
            lbCategoria.Text = "Categoria:";
            // 
            // lbCustoAquisicao
            // 
            lbCustoAquisicao.AutoSize = true;
            lbCustoAquisicao.BackColor = Color.White;
            lbCustoAquisicao.Font = new Font("Segoe UI", 12F);
            lbCustoAquisicao.ForeColor = Color.Black;
            lbCustoAquisicao.Location = new Point(539, 88);
            lbCustoAquisicao.Name = "lbCustoAquisicao";
            lbCustoAquisicao.Size = new Size(124, 21);
            lbCustoAquisicao.TabIndex = 7;
            lbCustoAquisicao.Text = "Custo Aquisição:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(983, 259);
            dataGridView1.TabIndex = 2;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.FromArgb(0, 123, 255);
            btnGravar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(871, 210);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 36);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.BackColor = Color.White;
            lbMarca.Font = new Font("Segoe UI", 12F);
            lbMarca.ForeColor = Color.Black;
            lbMarca.Location = new Point(282, 88);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(56, 21);
            lbMarca.TabIndex = 11;
            lbMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            tbMarca.ForeColor = Color.FromArgb(55, 65, 81);
            tbMarca.Location = new Point(282, 116);
            tbMarca.MaxLength = 250;
            tbMarca.Name = "tbMarca";
            tbMarca.ScrollBars = ScrollBars.Vertical;
            tbMarca.Size = new Size(200, 23);
            tbMarca.TabIndex = 4;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.BackColor = Color.White;
            lbCodigo.Font = new Font("Segoe UI", 12F);
            lbCodigo.ForeColor = Color.Black;
            lbCodigo.Location = new Point(282, 19);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(63, 21);
            lbCodigo.TabIndex = 13;
            lbCodigo.Text = "Codigo:";
            // 
            // tbCodigo
            // 
            tbCodigo.ForeColor = Color.FromArgb(55, 65, 81);
            tbCodigo.Location = new Point(282, 47);
            tbCodigo.MaxLength = 250;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(200, 23);
            tbCodigo.TabIndex = 1;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.LightGray;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(759, 210);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 36);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.BackColor = Color.White;
            lbDescricao.Font = new Font("Segoe UI", 12F);
            lbDescricao.ForeColor = Color.Black;
            lbDescricao.Location = new Point(25, 157);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(80, 21);
            lbDescricao.TabIndex = 17;
            lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            tbDescricao.ForeColor = Color.FromArgb(55, 65, 81);
            tbDescricao.Location = new Point(25, 185);
            tbDescricao.MaxLength = 1000;
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.ScrollBars = ScrollBars.Vertical;
            tbDescricao.Size = new Size(457, 56);
            tbDescricao.TabIndex = 6;
            // 
            // tbCustoAquisicao
            // 
            tbCustoAquisicao.ForeColor = Color.FromArgb(55, 65, 81);
            tbCustoAquisicao.Location = new Point(539, 116);
            tbCustoAquisicao.Name = "tbCustoAquisicao";
            tbCustoAquisicao.Size = new Size(200, 23);
            tbCustoAquisicao.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbNomeProd);
            panel1.Controls.Add(tbNomeProd);
            panel1.Controls.Add(lbCodigo);
            panel1.Controls.Add(tbCodigo);
            panel1.Controls.Add(lbCategoria);
            panel1.Controls.Add(cbCategoria);
            panel1.Controls.Add(lbFornecedor);
            panel1.Controls.Add(cbFornecedor);
            panel1.Controls.Add(lbMarca);
            panel1.Controls.Add(tbMarca);
            panel1.Controls.Add(lbCustoAquisicao);
            panel1.Controls.Add(tbCustoAquisicao);
            panel1.Controls.Add(lbDescricao);
            panel1.Controls.Add(tbDescricao);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 258);
            panel1.TabIndex = 1;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(539, 47);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(200, 23);
            cbCategoria.TabIndex = 2;
            // 
            // CadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadProduto";
            Size = new Size(983, 517);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}
