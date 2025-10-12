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
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.Button btnRemoverServico;
        private System.Windows.Forms.DataGridView dataGridServicos;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.DateTimePicker dtDataPrestacao;
        private System.Windows.Forms.DateTimePicker dtPrevisaoConclusao;
        private Salomao.DecimalTextbox tbValorSugerido;
        private Salomao.DecimalTextbox tbValorPraticado;
        private Salomao.DecimalTextbox tbLucroBruto;
        private System.Windows.Forms.TextBox tbObservacoes;
        
        // Novos controles para design moderno
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel cardInformacoesBasicas;
        private System.Windows.Forms.Panel cardServicos;
        private System.Windows.Forms.Panel cardValores;
        private System.Windows.Forms.Panel cardObservacoes;
        private System.Windows.Forms.Panel cardBotoes;
        private System.Windows.Forms.Panel cardGrid;
        
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbVeiculo;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbDataPrestacao;
        private System.Windows.Forms.Label lbPrevisaoConclusao;
        private System.Windows.Forms.Label lbValorSugerido;
        private System.Windows.Forms.Label lbValorPraticado;
        private System.Windows.Forms.Label lbLucroBruto;
        private System.Windows.Forms.Label lbObservacoes;
        
        // Labels de título dos cards
        private System.Windows.Forms.Label lbTituloInformacoesBasicas;
        private System.Windows.Forms.Label lbTituloServicos;
        private System.Windows.Forms.Label lbTituloValores;
        private System.Windows.Forms.Label lbTituloObservacoes;
        private System.Windows.Forms.Label lbTituloGrid;

        private void InitializeComponent()
        {
            mainContainer = new Panel();
            cardGrid = new Panel();
            lbTituloGrid = new Label();
            dataGridView1 = new DataGridView();
            cardBotoes = new Panel();
            btnGravar = new Button();
            btnLimpar = new Button();
            cardObservacoes = new Panel();
            lbTituloObservacoes = new Label();
            lbObservacoes = new Label();
            tbObservacoes = new TextBox();
            cardValores = new Panel();
            lbTituloValores = new Label();
            lbValorSugerido = new Label();
            tbValorSugerido = new DecimalTextbox();
            lbValorPraticado = new Label();
            tbValorPraticado = new DecimalTextbox();
            lbLucroBruto = new Label();
            tbLucroBruto = new DecimalTextbox();
            cardServicos = new Panel();
            lbTituloServicos = new Label();
            lbServico = new Label();
            cbServico = new ComboBox();
            btnAdicionarServico = new Button();
            btnRemoverServico = new Button();
            dataGridServicos = new DataGridView();
            cardInformacoesBasicas = new Panel();
            lbTituloInformacoesBasicas = new Label();
            lbCliente = new Label();
            cbCliente = new ComboBox();
            lbVeiculo = new Label();
            cbVeiculo = new ComboBox();
            lbData = new Label();
            dtData = new DateTimePicker();
            lbDataPrestacao = new Label();
            dtDataPrestacao = new DateTimePicker();
            lbPrevisaoConclusao = new Label();
            dtPrevisaoConclusao = new DateTimePicker();
            mainContainer.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cardBotoes.SuspendLayout();
            cardObservacoes.SuspendLayout();
            cardValores.SuspendLayout();
            cardServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridServicos).BeginInit();
            cardInformacoesBasicas.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGrid);
            mainContainer.Controls.Add(cardBotoes);
            mainContainer.Controls.Add(cardObservacoes);
            mainContainer.Controls.Add(cardValores);
            mainContainer.Controls.Add(cardServicos);
            mainContainer.Controls.Add(cardInformacoesBasicas);
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
            cardGrid.Location = new Point(20, 600);
            cardGrid.Name = "cardGrid";
            cardGrid.Padding = new Padding(20);
            cardGrid.Size = new Size(1160, 365);
            cardGrid.TabIndex = 5;
            // 
            // lbTituloGrid
            // 
            lbTituloGrid.AutoSize = true;
            lbTituloGrid.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGrid.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGrid.Location = new Point(20, 20);
            lbTituloGrid.Name = "lbTituloGrid";
            lbTituloGrid.Size = new Size(276, 25);
            lbTituloGrid.TabIndex = 0;
            lbTituloGrid.Text = "📊 Histórico de Atendimentos";
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
            cardBotoes.Location = new Point(20, 520);
            cardBotoes.Name = "cardBotoes";
            cardBotoes.Size = new Size(1160, 60);
            cardBotoes.TabIndex = 4;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            // cardObservacoes
            // 
            cardObservacoes.BackColor = Color.White;
            cardObservacoes.Controls.Add(lbTituloObservacoes);
            cardObservacoes.Controls.Add(lbObservacoes);
            cardObservacoes.Controls.Add(tbObservacoes);
            cardObservacoes.Location = new Point(620, 380);
            cardObservacoes.Name = "cardObservacoes";
            cardObservacoes.Padding = new Padding(20);
            cardObservacoes.Size = new Size(560, 120);
            cardObservacoes.TabIndex = 3;
            // 
            // lbTituloObservacoes
            // 
            lbTituloObservacoes.AutoSize = true;
            lbTituloObservacoes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloObservacoes.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloObservacoes.Location = new Point(20, 20);
            lbTituloObservacoes.Name = "lbTituloObservacoes";
            lbTituloObservacoes.Size = new Size(151, 25);
            lbTituloObservacoes.TabIndex = 0;
            lbTituloObservacoes.Text = "📝 Observações";
            // 
            // lbObservacoes
            // 
            lbObservacoes.AutoSize = true;
            lbObservacoes.Font = new Font("Segoe UI", 10F);
            lbObservacoes.ForeColor = Color.FromArgb(73, 80, 87);
            lbObservacoes.Location = new Point(20, 60);
            lbObservacoes.Name = "lbObservacoes";
            lbObservacoes.Size = new Size(90, 19);
            lbObservacoes.TabIndex = 1;
            lbObservacoes.Text = "Observações:";
            // 
            // tbObservacoes
            // 
            tbObservacoes.Font = new Font("Segoe UI", 10F);
            tbObservacoes.Location = new Point(20, 85);
            tbObservacoes.Multiline = true;
            tbObservacoes.Name = "tbObservacoes";
            tbObservacoes.ScrollBars = ScrollBars.Vertical;
            tbObservacoes.Size = new Size(520, 25);
            tbObservacoes.TabIndex = 2;
            // 
            // cardValores
            // 
            cardValores.BackColor = Color.White;
            cardValores.Controls.Add(lbTituloValores);
            cardValores.Controls.Add(lbValorSugerido);
            cardValores.Controls.Add(tbValorSugerido);
            cardValores.Controls.Add(lbValorPraticado);
            cardValores.Controls.Add(tbValorPraticado);
            cardValores.Controls.Add(lbLucroBruto);
            cardValores.Controls.Add(tbLucroBruto);
            cardValores.Location = new Point(20, 380);
            cardValores.Name = "cardValores";
            cardValores.Padding = new Padding(20);
            cardValores.Size = new Size(580, 120);
            cardValores.TabIndex = 2;
            // 
            // lbTituloValores
            // 
            lbTituloValores.AutoSize = true;
            lbTituloValores.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloValores.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloValores.Location = new Point(20, 20);
            lbTituloValores.Name = "lbTituloValores";
            lbTituloValores.Size = new Size(100, 25);
            lbTituloValores.TabIndex = 0;
            lbTituloValores.Text = "💰 Valores";
            // 
            // lbValorSugerido
            // 
            lbValorSugerido.AutoSize = true;
            lbValorSugerido.Font = new Font("Segoe UI", 10F);
            lbValorSugerido.ForeColor = Color.FromArgb(73, 80, 87);
            lbValorSugerido.Location = new Point(20, 60);
            lbValorSugerido.Name = "lbValorSugerido";
            lbValorSugerido.Size = new Size(101, 19);
            lbValorSugerido.TabIndex = 1;
            lbValorSugerido.Text = "Valor Sugerido:";
            // 
            // tbValorSugerido
            // 
            tbValorSugerido.Font = new Font("Segoe UI", 10F);
            tbValorSugerido.Location = new Point(125, 57);
            tbValorSugerido.Name = "tbValorSugerido";
            tbValorSugerido.Size = new Size(150, 25);
            tbValorSugerido.TabIndex = 2;
            tbValorSugerido.TextAlign = HorizontalAlignment.Right;
            // 
            // lbValorPraticado
            // 
            lbValorPraticado.AutoSize = true;
            lbValorPraticado.Font = new Font("Segoe UI", 10F);
            lbValorPraticado.ForeColor = Color.FromArgb(73, 80, 87);
            lbValorPraticado.Location = new Point(300, 60);
            lbValorPraticado.Name = "lbValorPraticado";
            lbValorPraticado.Size = new Size(104, 19);
            lbValorPraticado.TabIndex = 3;
            lbValorPraticado.Text = "Valor Praticado:";
            // 
            // tbValorPraticado
            // 
            tbValorPraticado.Font = new Font("Segoe UI", 10F);
            tbValorPraticado.Location = new Point(410, 57);
            tbValorPraticado.Name = "tbValorPraticado";
            tbValorPraticado.Size = new Size(150, 25);
            tbValorPraticado.TabIndex = 4;
            tbValorPraticado.TextAlign = HorizontalAlignment.Right;
            // 
            // lbLucroBruto
            // 
            lbLucroBruto.AutoSize = true;
            lbLucroBruto.Font = new Font("Segoe UI", 10F);
            lbLucroBruto.ForeColor = Color.FromArgb(73, 80, 87);
            lbLucroBruto.Location = new Point(20, 95);
            lbLucroBruto.Name = "lbLucroBruto";
            lbLucroBruto.Size = new Size(84, 19);
            lbLucroBruto.TabIndex = 5;
            lbLucroBruto.Text = "Lucro Bruto:";
            // 
            // tbLucroBruto
            // 
            tbLucroBruto.Font = new Font("Segoe UI", 10F);
            tbLucroBruto.Location = new Point(125, 92);
            tbLucroBruto.Name = "tbLucroBruto";
            tbLucroBruto.Size = new Size(150, 25);
            tbLucroBruto.TabIndex = 6;
            tbLucroBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // cardServicos
            // 
            cardServicos.BackColor = Color.White;
            cardServicos.Controls.Add(lbTituloServicos);
            cardServicos.Controls.Add(lbServico);
            cardServicos.Controls.Add(cbServico);
            cardServicos.Controls.Add(btnAdicionarServico);
            cardServicos.Controls.Add(btnRemoverServico);
            cardServicos.Controls.Add(dataGridServicos);
            cardServicos.Location = new Point(20, 160);
            cardServicos.Name = "cardServicos";
            cardServicos.Padding = new Padding(20);
            cardServicos.Size = new Size(1160, 200);
            cardServicos.TabIndex = 1;
            // 
            // lbTituloServicos
            // 
            lbTituloServicos.AutoSize = true;
            lbTituloServicos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloServicos.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloServicos.Location = new Point(20, 20);
            lbTituloServicos.Name = "lbTituloServicos";
            lbTituloServicos.Size = new Size(113, 25);
            lbTituloServicos.TabIndex = 0;
            lbTituloServicos.Text = "🔧 Serviços";
            // 
            // lbServico
            // 
            lbServico.AutoSize = true;
            lbServico.Font = new Font("Segoe UI", 10F);
            lbServico.ForeColor = Color.FromArgb(73, 80, 87);
            lbServico.Location = new Point(20, 60);
            lbServico.Name = "lbServico";
            lbServico.Size = new Size(55, 19);
            lbServico.TabIndex = 1;
            lbServico.Text = "Serviço:";
            // 
            // cbServico
            // 
            cbServico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServico.Font = new Font("Segoe UI", 10F);
            cbServico.Location = new Point(85, 57);
            cbServico.Name = "cbServico";
            cbServico.Size = new Size(250, 25);
            cbServico.TabIndex = 2;
            // 
            // btnAdicionarServico
            // 
            btnAdicionarServico.BackColor = Color.FromArgb(13, 110, 253);
            btnAdicionarServico.FlatAppearance.BorderSize = 0;
            btnAdicionarServico.FlatStyle = FlatStyle.Flat;
            btnAdicionarServico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionarServico.ForeColor = Color.White;
            btnAdicionarServico.Location = new Point(350, 55);
            btnAdicionarServico.Name = "btnAdicionarServico";
            btnAdicionarServico.Size = new Size(100, 30);
            btnAdicionarServico.TabIndex = 3;
            btnAdicionarServico.Text = "➕ Adicionar";
            btnAdicionarServico.UseVisualStyleBackColor = false;
            // 
            // btnRemoverServico
            // 
            btnRemoverServico.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoverServico.FlatAppearance.BorderSize = 0;
            btnRemoverServico.FlatStyle = FlatStyle.Flat;
            btnRemoverServico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoverServico.ForeColor = Color.White;
            btnRemoverServico.Location = new Point(460, 55);
            btnRemoverServico.Name = "btnRemoverServico";
            btnRemoverServico.Size = new Size(100, 30);
            btnRemoverServico.TabIndex = 4;
            btnRemoverServico.Text = "➖ Remover";
            btnRemoverServico.UseVisualStyleBackColor = false;
            // 
            // dataGridServicos
            // 
            dataGridServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridServicos.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridServicos.BorderStyle = BorderStyle.None;
            dataGridServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridServicos.Font = new Font("Segoe UI", 9F);
            dataGridServicos.Location = new Point(20, 100);
            dataGridServicos.Name = "dataGridServicos";
            dataGridServicos.Size = new Size(1120, 80);
            dataGridServicos.TabIndex = 5;
            // 
            // cardInformacoesBasicas
            // 
            cardInformacoesBasicas.BackColor = Color.White;
            cardInformacoesBasicas.Controls.Add(lbTituloInformacoesBasicas);
            cardInformacoesBasicas.Controls.Add(lbCliente);
            cardInformacoesBasicas.Controls.Add(cbCliente);
            cardInformacoesBasicas.Controls.Add(lbVeiculo);
            cardInformacoesBasicas.Controls.Add(cbVeiculo);
            cardInformacoesBasicas.Controls.Add(lbData);
            cardInformacoesBasicas.Controls.Add(dtData);
            cardInformacoesBasicas.Controls.Add(lbDataPrestacao);
            cardInformacoesBasicas.Controls.Add(dtDataPrestacao);
            cardInformacoesBasicas.Controls.Add(lbPrevisaoConclusao);
            cardInformacoesBasicas.Controls.Add(dtPrevisaoConclusao);
            cardInformacoesBasicas.Location = new Point(20, 20);
            cardInformacoesBasicas.Name = "cardInformacoesBasicas";
            cardInformacoesBasicas.Padding = new Padding(20);
            cardInformacoesBasicas.Size = new Size(1160, 120);
            cardInformacoesBasicas.TabIndex = 0;
            // 
            // lbTituloInformacoesBasicas
            // 
            lbTituloInformacoesBasicas.AutoSize = true;
            lbTituloInformacoesBasicas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloInformacoesBasicas.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloInformacoesBasicas.Location = new Point(20, 20);
            lbTituloInformacoesBasicas.Name = "lbTituloInformacoesBasicas";
            lbTituloInformacoesBasicas.Size = new Size(213, 25);
            lbTituloInformacoesBasicas.TabIndex = 0;
            lbTituloInformacoesBasicas.Text = "📋 Informações Básicas";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Font = new Font("Segoe UI", 10F);
            lbCliente.ForeColor = Color.FromArgb(73, 80, 87);
            lbCliente.Location = new Point(20, 60);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(54, 19);
            lbCliente.TabIndex = 1;
            lbCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.Font = new Font("Segoe UI", 10F);
            cbCliente.Location = new Point(80, 57);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(200, 25);
            cbCliente.TabIndex = 2;
            // 
            // lbVeiculo
            // 
            lbVeiculo.AutoSize = true;
            lbVeiculo.Font = new Font("Segoe UI", 10F);
            lbVeiculo.ForeColor = Color.FromArgb(73, 80, 87);
            lbVeiculo.Location = new Point(300, 60);
            lbVeiculo.Name = "lbVeiculo";
            lbVeiculo.Size = new Size(55, 19);
            lbVeiculo.TabIndex = 3;
            lbVeiculo.Text = "Veículo:";
            // 
            // cbVeiculo
            // 
            cbVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVeiculo.Font = new Font("Segoe UI", 10F);
            cbVeiculo.Location = new Point(365, 57);
            cbVeiculo.Name = "cbVeiculo";
            cbVeiculo.Size = new Size(200, 25);
            cbVeiculo.TabIndex = 4;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI", 10F);
            lbData.ForeColor = Color.FromArgb(73, 80, 87);
            lbData.Location = new Point(580, 60);
            lbData.Name = "lbData";
            lbData.Size = new Size(41, 19);
            lbData.TabIndex = 5;
            lbData.Text = "Data:";
            // 
            // dtData
            // 
            dtData.Font = new Font("Segoe UI", 10F);
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(630, 57);
            dtData.Name = "dtData";
            dtData.Size = new Size(150, 25);
            dtData.TabIndex = 6;
            // 
            // lbDataPrestacao
            // 
            lbDataPrestacao.AutoSize = true;
            lbDataPrestacao.Font = new Font("Segoe UI", 10F);
            lbDataPrestacao.ForeColor = Color.FromArgb(73, 80, 87);
            lbDataPrestacao.Location = new Point(800, 60);
            lbDataPrestacao.Name = "lbDataPrestacao";
            lbDataPrestacao.Size = new Size(104, 19);
            lbDataPrestacao.TabIndex = 7;
            lbDataPrestacao.Text = "Data Prestação:";
            // 
            // dtDataPrestacao
            // 
            dtDataPrestacao.Font = new Font("Segoe UI", 10F);
            dtDataPrestacao.Format = DateTimePickerFormat.Short;
            dtDataPrestacao.Location = new Point(910, 57);
            dtDataPrestacao.Name = "dtDataPrestacao";
            dtDataPrestacao.Size = new Size(150, 25);
            dtDataPrestacao.TabIndex = 8;
            // 
            // lbPrevisaoConclusao
            // 
            lbPrevisaoConclusao.AutoSize = true;
            lbPrevisaoConclusao.Font = new Font("Segoe UI", 10F);
            lbPrevisaoConclusao.ForeColor = Color.FromArgb(73, 80, 87);
            lbPrevisaoConclusao.Location = new Point(20, 95);
            lbPrevisaoConclusao.Name = "lbPrevisaoConclusao";
            lbPrevisaoConclusao.Size = new Size(130, 19);
            lbPrevisaoConclusao.TabIndex = 9;
            lbPrevisaoConclusao.Text = "Previsão Conclusão:";
            // 
            // dtPrevisaoConclusao
            // 
            dtPrevisaoConclusao.Font = new Font("Segoe UI", 10F);
            dtPrevisaoConclusao.Format = DateTimePickerFormat.Short;
            dtPrevisaoConclusao.Location = new Point(160, 92);
            dtPrevisaoConclusao.Name = "dtPrevisaoConclusao";
            dtPrevisaoConclusao.Size = new Size(150, 25);
            dtPrevisaoConclusao.TabIndex = 10;
            // 
            // CadAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "CadAtendimento";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cardBotoes.ResumeLayout(false);
            cardObservacoes.ResumeLayout(false);
            cardObservacoes.PerformLayout();
            cardValores.ResumeLayout(false);
            cardValores.PerformLayout();
            cardServicos.ResumeLayout(false);
            cardServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridServicos).EndInit();
            cardInformacoesBasicas.ResumeLayout(false);
            cardInformacoesBasicas.PerformLayout();
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
    }
} 