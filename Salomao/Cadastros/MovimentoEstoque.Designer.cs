namespace Salomao.Cadastros
{
    partial class MovimentoEstoque
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
            lbTituloGrid = new Label();
            dataGridView1 = new DataGridView();
            cardBotoes = new Panel();
            btnGravar = new Button();
            btnLimpar = new Button();
            cardFiltros = new Panel();
            lbTituloFiltros = new Label();
            btnLimparFiltros = new Button();
            btnFiltrar = new Button();
            cbProdutoFiltro = new ComboBox();
            label7 = new Label();
            dtDataFim = new DateTimePicker();
            label6 = new Label();
            dtDataInicio = new DateTimePicker();
            label1 = new Label();
            cardMovimento = new Panel();
            lbTituloMovimento = new Label();
            lblSaldoAtual = new Label();
            tbObservacao = new TextBox();
            label5 = new Label();
            tbQuantidade = new TextBox();
            label4 = new Label();
            rbSaida = new RadioButton();
            rbEntrada = new RadioButton();
            label3 = new Label();
            cbProduto = new ComboBox();
            label2 = new Label();
            mainContainer.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cardBotoes.SuspendLayout();
            cardFiltros.SuspendLayout();
            cardMovimento.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGrid);
            mainContainer.Controls.Add(cardBotoes);
            mainContainer.Controls.Add(cardFiltros);
            mainContainer.Controls.Add(cardMovimento);
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
            cardGrid.TabIndex = 3;
            // 
            // lbTituloGrid
            // 
            lbTituloGrid.AutoSize = true;
            lbTituloGrid.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGrid.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGrid.Location = new Point(20, 20);
            lbTituloGrid.Name = "lbTituloGrid";
            lbTituloGrid.Size = new Size(262, 25);
            lbTituloGrid.TabIndex = 0;
            lbTituloGrid.Text = "📊 Histórico de Movimentos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(20, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1120, 285);
            dataGridView1.TabIndex = 1;
            // 
            // cardBotoes
            // 
            cardBotoes.BackColor = Color.Transparent;
            cardBotoes.Controls.Add(btnGravar);
            cardBotoes.Controls.Add(btnLimpar);
            cardBotoes.Location = new Point(20, 340);
            cardBotoes.Name = "cardBotoes";
            cardBotoes.Size = new Size(1160, 60);
            cardBotoes.TabIndex = 2;
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
            // cardFiltros
            // 
            cardFiltros.BackColor = Color.White;
            cardFiltros.Controls.Add(lbTituloFiltros);
            cardFiltros.Controls.Add(btnLimparFiltros);
            cardFiltros.Controls.Add(btnFiltrar);
            cardFiltros.Controls.Add(cbProdutoFiltro);
            cardFiltros.Controls.Add(label7);
            cardFiltros.Controls.Add(dtDataFim);
            cardFiltros.Controls.Add(label6);
            cardFiltros.Controls.Add(dtDataInicio);
            cardFiltros.Controls.Add(label1);
            cardFiltros.Location = new Point(620, 20);
            cardFiltros.Name = "cardFiltros";
            cardFiltros.Padding = new Padding(20);
            cardFiltros.Size = new Size(560, 300);
            cardFiltros.TabIndex = 1;
            // 
            // lbTituloFiltros
            // 
            lbTituloFiltros.AutoSize = true;
            lbTituloFiltros.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloFiltros.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloFiltros.Location = new Point(20, 20);
            lbTituloFiltros.Name = "lbTituloFiltros";
            lbTituloFiltros.Size = new Size(94, 25);
            lbTituloFiltros.TabIndex = 0;
            lbTituloFiltros.Text = "🔍 Filtros";
            // 
            // btnLimparFiltros
            // 
            btnLimparFiltros.BackColor = Color.FromArgb(108, 117, 125);
            btnLimparFiltros.FlatAppearance.BorderSize = 0;
            btnLimparFiltros.FlatStyle = FlatStyle.Flat;
            btnLimparFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimparFiltros.ForeColor = Color.White;
            btnLimparFiltros.Location = new Point(130, 200);
            btnLimparFiltros.Name = "btnLimparFiltros";
            btnLimparFiltros.Size = new Size(120, 35);
            btnLimparFiltros.TabIndex = 8;
            btnLimparFiltros.Text = "🗑️ Limpar Filtros";
            btnLimparFiltros.UseVisualStyleBackColor = false;
            btnLimparFiltros.Click += btnLimparFiltros_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(13, 110, 253);
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(20, 200);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(100, 35);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "🔍 Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cbProdutoFiltro
            // 
            cbProdutoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProdutoFiltro.Font = new Font("Segoe UI", 10F);
            cbProdutoFiltro.FormattingEnabled = true;
            cbProdutoFiltro.Location = new Point(20, 155);
            cbProdutoFiltro.Name = "cbProdutoFiltro";
            cbProdutoFiltro.Size = new Size(250, 25);
            cbProdutoFiltro.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(73, 80, 87);
            label7.Location = new Point(20, 130);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 5;
            label7.Text = "Produto:";
            // 
            // dtDataFim
            // 
            dtDataFim.Font = new Font("Segoe UI", 10F);
            dtDataFim.Format = DateTimePickerFormat.Short;
            dtDataFim.Location = new Point(200, 85);
            dtDataFim.Name = "dtDataFim";
            dtDataFim.Size = new Size(150, 25);
            dtDataFim.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(73, 80, 87);
            label6.Location = new Point(200, 60);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 3;
            label6.Text = "Data Fim:";
            // 
            // dtDataInicio
            // 
            dtDataInicio.Font = new Font("Segoe UI", 10F);
            dtDataInicio.Format = DateTimePickerFormat.Short;
            dtDataInicio.Location = new Point(20, 85);
            dtDataInicio.Name = "dtDataInicio";
            dtDataInicio.Size = new Size(150, 25);
            dtDataInicio.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(73, 80, 87);
            label1.Location = new Point(20, 60);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 1;
            label1.Text = "Data Início:";
            // 
            // cardMovimento
            // 
            cardMovimento.BackColor = Color.White;
            cardMovimento.Controls.Add(lbTituloMovimento);
            cardMovimento.Controls.Add(lblSaldoAtual);
            cardMovimento.Controls.Add(tbObservacao);
            cardMovimento.Controls.Add(label5);
            cardMovimento.Controls.Add(tbQuantidade);
            cardMovimento.Controls.Add(label4);
            cardMovimento.Controls.Add(rbSaida);
            cardMovimento.Controls.Add(rbEntrada);
            cardMovimento.Controls.Add(label3);
            cardMovimento.Controls.Add(cbProduto);
            cardMovimento.Controls.Add(label2);
            cardMovimento.Location = new Point(20, 20);
            cardMovimento.Name = "cardMovimento";
            cardMovimento.Padding = new Padding(20);
            cardMovimento.Size = new Size(580, 300);
            cardMovimento.TabIndex = 0;
            // 
            // lbTituloMovimento
            // 
            lbTituloMovimento.AutoSize = true;
            lbTituloMovimento.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloMovimento.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloMovimento.Location = new Point(20, 20);
            lbTituloMovimento.Name = "lbTituloMovimento";
            lbTituloMovimento.Size = new Size(196, 25);
            lbTituloMovimento.TabIndex = 0;
            lbTituloMovimento.Text = "📦 Novo Movimento";
            // 
            // lblSaldoAtual
            // 
            lblSaldoAtual.AutoSize = true;
            lblSaldoAtual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSaldoAtual.ForeColor = Color.FromArgb(25, 135, 84);
            lblSaldoAtual.Location = new Point(300, 88);
            lblSaldoAtual.Name = "lblSaldoAtual";
            lblSaldoAtual.Size = new Size(102, 19);
            lblSaldoAtual.TabIndex = 3;
            lblSaldoAtual.Text = "Saldo Atual: 0";
            // 
            // tbObservacao
            // 
            tbObservacao.Font = new Font("Segoe UI", 10F);
            tbObservacao.Location = new Point(200, 215);
            tbObservacao.Multiline = true;
            tbObservacao.Name = "tbObservacao";
            tbObservacao.ScrollBars = ScrollBars.Vertical;
            tbObservacao.Size = new Size(350, 60);
            tbObservacao.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(73, 80, 87);
            label5.Location = new Point(200, 190);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 9;
            label5.Text = "Observação:";
            // 
            // tbQuantidade
            // 
            tbQuantidade.Font = new Font("Segoe UI", 10F);
            tbQuantidade.Location = new Point(20, 215);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(150, 25);
            tbQuantidade.TabIndex = 8;
            tbQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(73, 80, 87);
            label4.Location = new Point(20, 190);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 7;
            label4.Text = "Quantidade:";
            // 
            // rbSaida
            // 
            rbSaida.AutoSize = true;
            rbSaida.Font = new Font("Segoe UI", 10F);
            rbSaida.ForeColor = Color.FromArgb(73, 80, 87);
            rbSaida.Location = new Point(100, 155);
            rbSaida.Name = "rbSaida";
            rbSaida.Size = new Size(59, 23);
            rbSaida.TabIndex = 6;
            rbSaida.Text = "Saída";
            rbSaida.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            rbEntrada.AutoSize = true;
            rbEntrada.Checked = true;
            rbEntrada.Font = new Font("Segoe UI", 10F);
            rbEntrada.ForeColor = Color.FromArgb(73, 80, 87);
            rbEntrada.Location = new Point(20, 155);
            rbEntrada.Name = "rbEntrada";
            rbEntrada.Size = new Size(74, 23);
            rbEntrada.TabIndex = 5;
            rbEntrada.TabStop = true;
            rbEntrada.Text = "Entrada";
            rbEntrada.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(73, 80, 87);
            label3.Location = new Point(20, 130);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 4;
            label3.Text = "Tipo:";
            // 
            // cbProduto
            // 
            cbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProduto.Font = new Font("Segoe UI", 10F);
            cbProduto.FormattingEnabled = true;
            cbProduto.Location = new Point(20, 85);
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(250, 25);
            cbProduto.TabIndex = 2;
            cbProduto.SelectedIndexChanged += cbProduto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(73, 80, 87);
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 1;
            label2.Text = "Produto:";
            // 
            // MovimentoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "MovimentoEstoque";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cardBotoes.ResumeLayout(false);
            cardFiltros.ResumeLayout(false);
            cardFiltros.PerformLayout();
            cardMovimento.ResumeLayout(false);
            cardMovimento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Controles do movimento
        private Label lblSaldoAtual;
        private TextBox tbObservacao;
        private Label label5;
        private TextBox tbQuantidade;
        private Label label4;
        private RadioButton rbSaida;
        private RadioButton rbEntrada;
        private Label label3;
        private ComboBox cbProduto;
        private Label label2;
        
        // Controles dos filtros
        private Button btnLimparFiltros;
        private Button btnFiltrar;
        private ComboBox cbProdutoFiltro;
        private Label label7;
        private DateTimePicker dtDataFim;
        private Label label6;
        private DateTimePicker dtDataInicio;
        private Label label1;
        
        // Controles principais
        private Button btnLimpar;
        private Button btnGravar;
        private DataGridView dataGridView1;
        
        // Cards modernos
        private Panel mainContainer;
        private Panel cardMovimento;
        private Panel cardFiltros;
        private Panel cardGrid;
        private Panel cardBotoes;
        
        // Labels de título
        private Label lbTituloMovimento;
        private Label lbTituloFiltros;
        private Label lbTituloGrid;
    }
} 