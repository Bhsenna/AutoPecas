namespace Salomao.Cadastros
{
    partial class CadAtendimento
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.DateTimePicker dtDataPrestacao;
        private System.Windows.Forms.DateTimePicker dtPrevisaoConclusao;
        private System.Windows.Forms.TextBox tbValorSugerido;
        private System.Windows.Forms.TextBox tbValorPraticado;
        private System.Windows.Forms.TextBox tbLucroBruto;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbVeiculo;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbDataPrestacao;
        private System.Windows.Forms.Label lbPrevisaoConclusao;
        private System.Windows.Forms.Label lbValorSugerido;
        private System.Windows.Forms.Label lbValorPraticado;
        private System.Windows.Forms.Label lbLucroBruto;
        private System.Windows.Forms.Label lbObservacoes;
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            lbCliente = new Label();
            cbCliente = new ComboBox();
            lbVeiculo = new Label();
            cbVeiculo = new ComboBox();
            lbServico = new Label();
            cbServico = new ComboBox();
            lbProduto = new Label();
            cbProduto = new ComboBox();
            lbData = new Label();
            dtData = new DateTimePicker();
            lbDataPrestacao = new Label();
            dtDataPrestacao = new DateTimePicker();
            lbPrevisaoConclusao = new Label();
            dtPrevisaoConclusao = new DateTimePicker();
            lbValorSugerido = new Label();
            tbValorSugerido = new TextBox();
            lbValorPraticado = new Label();
            tbValorPraticado = new TextBox();
            lbLucroBruto = new Label();
            tbLucroBruto = new TextBox();
            lbObservacoes = new Label();
            tbObservacoes = new TextBox();
            btnGravar = new Button();
            btnLimpar = new Button();
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(983, 286);
            dataGridView1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbCliente);
            panel1.Controls.Add(cbCliente);
            panel1.Controls.Add(lbVeiculo);
            panel1.Controls.Add(cbVeiculo);
            panel1.Controls.Add(lbServico);
            panel1.Controls.Add(cbServico);
            panel1.Controls.Add(lbProduto);
            panel1.Controls.Add(cbProduto);
            panel1.Controls.Add(lbData);
            panel1.Controls.Add(dtData);
            panel1.Controls.Add(lbDataPrestacao);
            panel1.Controls.Add(dtDataPrestacao);
            panel1.Controls.Add(lbPrevisaoConclusao);
            panel1.Controls.Add(dtPrevisaoConclusao);
            panel1.Controls.Add(lbValorSugerido);
            panel1.Controls.Add(tbValorSugerido);
            panel1.Controls.Add(lbValorPraticado);
            panel1.Controls.Add(tbValorPraticado);
            panel1.Controls.Add(lbLucroBruto);
            panel1.Controls.Add(tbLucroBruto);
            panel1.Controls.Add(lbObservacoes);
            panel1.Controls.Add(tbObservacoes);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 231);
            panel1.TabIndex = 21;
            // 
            // lbCliente
            // 
            lbCliente.Location = new Point(20, 15);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(74, 23);
            lbCliente.TabIndex = 0;
            lbCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.Location = new Point(114, 15);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(180, 23);
            cbCliente.TabIndex = 1;
            // 
            // lbVeiculo
            // 
            lbVeiculo.Location = new Point(300, 18);
            lbVeiculo.Name = "lbVeiculo";
            lbVeiculo.Size = new Size(64, 23);
            lbVeiculo.TabIndex = 2;
            lbVeiculo.Text = "Veículo:";
            // 
            // cbVeiculo
            // 
            cbVeiculo.Location = new Point(401, 15);
            cbVeiculo.Name = "cbVeiculo";
            cbVeiculo.Size = new Size(173, 23);
            cbVeiculo.TabIndex = 3;
            // 
            // lbServico
            // 
            lbServico.Location = new Point(586, 15);
            lbServico.Name = "lbServico";
            lbServico.Size = new Size(64, 23);
            lbServico.TabIndex = 4;
            lbServico.Text = "Serviço:";
            // 
            // cbServico
            // 
            cbServico.Location = new Point(705, 12);
            cbServico.Name = "cbServico";
            cbServico.Size = new Size(180, 23);
            cbServico.TabIndex = 5;
            // 
            // lbProduto
            // 
            lbProduto.Location = new Point(20, 55);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(74, 23);
            lbProduto.TabIndex = 6;
            lbProduto.Text = "Produto:";
            // 
            // cbProduto
            // 
            cbProduto.Location = new Point(114, 52);
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(180, 23);
            cbProduto.TabIndex = 7;
            // 
            // lbData
            // 
            lbData.Location = new Point(300, 50);
            lbData.Name = "lbData";
            lbData.Size = new Size(64, 23);
            lbData.TabIndex = 8;
            lbData.Text = "Data:";
            // 
            // dtData
            // 
            dtData.Location = new Point(401, 50);
            dtData.Name = "dtData";
            dtData.Size = new Size(173, 23);
            dtData.TabIndex = 9;
            // 
            // lbDataPrestacao
            // 
            lbDataPrestacao.Location = new Point(586, 47);
            lbDataPrestacao.Name = "lbDataPrestacao";
            lbDataPrestacao.Size = new Size(100, 23);
            lbDataPrestacao.TabIndex = 10;
            lbDataPrestacao.Text = "Data Prestação:";
            // 
            // dtDataPrestacao
            // 
            dtDataPrestacao.Location = new Point(705, 47);
            dtDataPrestacao.Name = "dtDataPrestacao";
            dtDataPrestacao.Size = new Size(180, 23);
            dtDataPrestacao.TabIndex = 11;
            // 
            // lbPrevisaoConclusao
            // 
            lbPrevisaoConclusao.Location = new Point(586, 80);
            lbPrevisaoConclusao.Name = "lbPrevisaoConclusao";
            lbPrevisaoConclusao.Size = new Size(113, 23);
            lbPrevisaoConclusao.TabIndex = 12;
            lbPrevisaoConclusao.Text = "Previsão Conclusão:";
            // 
            // dtPrevisaoConclusao
            // 
            dtPrevisaoConclusao.Location = new Point(705, 80);
            dtPrevisaoConclusao.Name = "dtPrevisaoConclusao";
            dtPrevisaoConclusao.Size = new Size(180, 23);
            dtPrevisaoConclusao.TabIndex = 13;
            // 
            // lbValorSugerido
            // 
            lbValorSugerido.Location = new Point(20, 92);
            lbValorSugerido.Name = "lbValorSugerido";
            lbValorSugerido.Size = new Size(88, 23);
            lbValorSugerido.TabIndex = 14;
            lbValorSugerido.Text = "Valor Sugerido:";
            // 
            // tbValorSugerido
            // 
            tbValorSugerido.Location = new Point(114, 89);
            tbValorSugerido.Name = "tbValorSugerido";
            tbValorSugerido.Size = new Size(143, 23);
            tbValorSugerido.TabIndex = 15;
            // 
            // lbValorPraticado
            // 
            lbValorPraticado.Location = new Point(300, 83);
            lbValorPraticado.Name = "lbValorPraticado";
            lbValorPraticado.Size = new Size(100, 23);
            lbValorPraticado.TabIndex = 16;
            lbValorPraticado.Text = "Valor Praticado:";
            // 
            // tbValorPraticado
            // 
            tbValorPraticado.Location = new Point(401, 83);
            tbValorPraticado.Name = "tbValorPraticado";
            tbValorPraticado.Size = new Size(114, 23);
            tbValorPraticado.TabIndex = 17;
            // 
            // lbLucroBruto
            // 
            lbLucroBruto.Location = new Point(20, 135);
            lbLucroBruto.Name = "lbLucroBruto";
            lbLucroBruto.Size = new Size(74, 23);
            lbLucroBruto.TabIndex = 18;
            lbLucroBruto.Text = "Lucro Bruto:";
            // 
            // tbLucroBruto
            // 
            tbLucroBruto.Location = new Point(114, 132);
            tbLucroBruto.Name = "tbLucroBruto";
            tbLucroBruto.Size = new Size(143, 23);
            tbLucroBruto.TabIndex = 19;
            // 
            // lbObservacoes
            // 
            lbObservacoes.Location = new Point(20, 170);
            lbObservacoes.Name = "lbObservacoes";
            lbObservacoes.Size = new Size(100, 23);
            lbObservacoes.TabIndex = 20;
            lbObservacoes.Text = "Observações:";
            // 
            // tbObservacoes
            // 
            tbObservacoes.Location = new Point(20, 190);
            tbObservacoes.Name = "tbObservacoes";
            tbObservacoes.Size = new Size(624, 23);
            tbObservacoes.TabIndex = 21;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.FromArgb(16, 185, 129);
            btnGravar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(850, 181);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 36);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.LightGray;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(730, 181);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 36);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // CadAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadAtendimento";
            Size = new Size(983, 517);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        // TODO: Adicionar propriedades, eventos e layout detalhado dos controles no futuro.
    }
} 