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
            panel1 = new Panel();
            btnRemoverProduto = new Button();
            btnAdicionarProduto = new Button();
            cbProdutoServico = new ComboBox();
            lbNomeServico = new Label();
            tbNomeServico = new TextBox();
            lbDescricao = new Label();
            tbDescricao = new TextBox();
            lbMargem = new Label();
            tbMargem = new DecimalTextbox();
            btnGravar = new Button();
            btnLimpar = new Button();
            lbProdutos = new Label();
            lbCustoServico = new Label();
            tbCustoServico = new DecimalTextbox();
            lbObservacao = new Label();
            tbObservacao = new TextBox();
            dataGridProdutos = new DataGridView();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRemoverProduto);
            panel1.Controls.Add(btnAdicionarProduto);
            panel1.Controls.Add(cbProdutoServico);
            panel1.Controls.Add(lbNomeServico);
            panel1.Controls.Add(tbNomeServico);
            panel1.Controls.Add(lbDescricao);
            panel1.Controls.Add(tbDescricao);
            panel1.Controls.Add(lbMargem);
            panel1.Controls.Add(tbMargem);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(lbProdutos);
            panel1.Controls.Add(lbCustoServico);
            panel1.Controls.Add(tbCustoServico);
            panel1.Controls.Add(lbObservacao);
            panel1.Controls.Add(tbObservacao);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 282);
            panel1.TabIndex = 2;
            // 
            // btnRemoverProduto
            // 
            btnRemoverProduto.Location = new Point(421, 234);
            btnRemoverProduto.Name = "btnRemoverProduto";
            btnRemoverProduto.Size = new Size(130, 23);
            btnRemoverProduto.TabIndex = 21;
            btnRemoverProduto.Text = "Remover Produto";
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(285, 234);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(130, 23);
            btnAdicionarProduto.TabIndex = 20;
            btnAdicionarProduto.Text = "Adicionar Produto";
            // 
            // cbProdutoServico
            // 
            cbProdutoServico.Location = new Point(20, 234);
            cbProdutoServico.Name = "cbProdutoServico";
            cbProdutoServico.Size = new Size(250, 23);
            cbProdutoServico.TabIndex = 19;
            // 
            // lbNomeServico
            // 
            lbNomeServico.AutoSize = true;
            lbNomeServico.BackColor = Color.White;
            lbNomeServico.Font = new Font("Segoe UI", 12F);
            lbNomeServico.ForeColor = Color.Black;
            lbNomeServico.Location = new Point(25, 19);
            lbNomeServico.Name = "lbNomeServico";
            lbNomeServico.Size = new Size(120, 21);
            lbNomeServico.TabIndex = 1;
            lbNomeServico.Text = "Nome Serviço:";
            // 
            // tbNomeServico
            // 
            tbNomeServico.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeServico.Location = new Point(25, 47);
            tbNomeServico.MaxLength = 250;
            tbNomeServico.Name = "tbNomeServico";
            tbNomeServico.Size = new Size(200, 23);
            tbNomeServico.TabIndex = 2;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.BackColor = Color.White;
            lbDescricao.Font = new Font("Segoe UI", 12F);
            lbDescricao.ForeColor = Color.Black;
            lbDescricao.Location = new Point(250, 19);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(80, 21);
            lbDescricao.TabIndex = 24;
            lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            tbDescricao.ForeColor = Color.FromArgb(55, 65, 81);
            tbDescricao.Location = new Point(250, 47);
            tbDescricao.MaxLength = 500;
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(250, 60);
            tbDescricao.TabIndex = 25;
            // 
            // lbMargem
            // 
            lbMargem.AutoSize = true;
            lbMargem.BackColor = Color.White;
            lbMargem.Font = new Font("Segoe UI", 12F);
            lbMargem.ForeColor = Color.Black;
            lbMargem.Location = new Point(25, 120);
            lbMargem.Name = "lbMargem";
            lbMargem.Size = new Size(163, 21);
            lbMargem.TabIndex = 3;
            lbMargem.Text = "Margem de Lucro (%):";
            // 
            // tbMargem
            // 
            tbMargem.ForeColor = Color.FromArgb(55, 65, 81);
            tbMargem.Location = new Point(25, 148);
            tbMargem.Name = "tbMargem";
            tbMargem.Size = new Size(200, 23);
            tbMargem.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.FromArgb(0, 123, 255);
            btnGravar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(1016, 234);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 36);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.LightGray;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(901, 234);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 36);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbProdutos
            // 
            lbProdutos.AutoSize = true;
            lbProdutos.Font = new Font("Segoe UI", 12F);
            lbProdutos.Location = new Point(20, 203);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(153, 21);
            lbProdutos.TabIndex = 10;
            lbProdutos.Text = "Produtos do Serviço:";
            // 
            // lbCustoServico
            // 
            lbCustoServico.AutoSize = true;
            lbCustoServico.Font = new Font("Segoe UI", 12F);
            lbCustoServico.Location = new Point(265, 19);
            lbCustoServico.Name = "lbCustoServico";
            lbCustoServico.Size = new Size(130, 21);
            lbCustoServico.TabIndex = 12;
            lbCustoServico.Text = "Custo do Serviço:";
            // 
            // tbCustoServico
            // 
            tbCustoServico.Location = new Point(265, 47);
            tbCustoServico.Name = "tbCustoServico";
            tbCustoServico.ReadOnly = true;
            tbCustoServico.Size = new Size(150, 23);
            tbCustoServico.TabIndex = 13;
            // 
            // lbObservacao
            // 
            lbObservacao.AutoSize = true;
            lbObservacao.Font = new Font("Segoe UI", 12F);
            lbObservacao.Location = new Point(25, 153);
            lbObservacao.Name = "lbObservacao";
            lbObservacao.Size = new Size(95, 21);
            lbObservacao.TabIndex = 14;
            lbObservacao.Text = "Observação:";
            // 
            // tbObservacao
            // 
            tbObservacao.Location = new Point(25, 177);
            tbObservacao.Name = "tbObservacao";
            tbObservacao.Size = new Size(250, 23);
            tbObservacao.TabIndex = 15;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(544, 282);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.Size = new Size(582, 338);
            dataGridProdutos.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1129, 338);
            dataGridView1.TabIndex = 3;
            // 
            // CadServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadServicos";
            Size = new Size(1129, 620);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbNomeServico;
        private TextBox tbNomeServico;
        private Label lbDescricao;
        private TextBox tbDescricao;
        private Label lbMargem;
        private DecimalTextbox tbMargem;
        private Button btnGravar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.Label lbProdutos;
        private System.Windows.Forms.Label lbCustoServico;
        private Salomao.DecimalTextbox tbCustoServico;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.ComboBox cbProdutoServico;
    }
}
