namespace Salomao.Cadastros
{
    partial class CadCliente
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
            cardGridVeiculos = new Panel();
            lbTituloGridVeiculos = new Label();
            dataGridViewVeiculos = new DataGridView();
            cardGridClientes = new Panel();
            lbTituloGridClientes = new Label();
            dataGridView1 = new DataGridView();
            cardBotoes = new Panel();
            btnGravar = new Button();
            btnLimpar = new Button();
            btnGravarVeiculo = new Button();
            btnLimparVeiculo = new Button();
            cardVeiculo = new Panel();
            lbTituloVeiculo = new Label();
            lbPlaca = new Label();
            tbPlaca = new TextBox();
            lbMarca = new Label();
            tbMarca = new TextBox();
            lbModelo = new Label();
            tbModelo = new TextBox();
            cardCliente = new Panel();
            lbTituloCliente = new Label();
            lbNomeClient = new Label();
            tbNomeClient = new TextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbTelefone = new Label();
            tbTelefone = new TextBox();
            mainContainer.SuspendLayout();
            cardGridVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVeiculos).BeginInit();
            cardGridClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cardBotoes.SuspendLayout();
            cardVeiculo.SuspendLayout();
            cardCliente.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGridVeiculos);
            mainContainer.Controls.Add(cardGridClientes);
            mainContainer.Controls.Add(cardBotoes);
            mainContainer.Controls.Add(cardVeiculo);
            mainContainer.Controls.Add(cardCliente);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(20);
            mainContainer.Size = new Size(1200, 800);
            mainContainer.TabIndex = 0;
            // 
            // cardGridVeiculos
            // 
            cardGridVeiculos.BackColor = Color.White;
            cardGridVeiculos.Controls.Add(lbTituloGridVeiculos);
            cardGridVeiculos.Controls.Add(dataGridViewVeiculos);
            cardGridVeiculos.Location = new Point(620, 320);
            cardGridVeiculos.Name = "cardGridVeiculos";
            cardGridVeiculos.Padding = new Padding(20);
            cardGridVeiculos.Size = new Size(560, 220);
            cardGridVeiculos.TabIndex = 4;
            // 
            // lbTituloGridVeiculos
            // 
            lbTituloGridVeiculos.AutoSize = true;
            lbTituloGridVeiculos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGridVeiculos.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGridVeiculos.Location = new Point(20, 20);
            lbTituloGridVeiculos.Name = "lbTituloGridVeiculos";
            lbTituloGridVeiculos.Size = new Size(184, 25);
            lbTituloGridVeiculos.TabIndex = 0;
            lbTituloGridVeiculos.Text = "🚗 Lista de Veículos";
            // 
            // dataGridViewVeiculos
            // 
            dataGridViewVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVeiculos.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridViewVeiculos.BorderStyle = BorderStyle.None;
            dataGridViewVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVeiculos.Font = new Font("Segoe UI", 9F);
            dataGridViewVeiculos.Location = new Point(20, 55);
            dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            dataGridViewVeiculos.Size = new Size(520, 145);
            dataGridViewVeiculos.TabIndex = 1;
            // 
            // cardGridClientes
            // 
            cardGridClientes.BackColor = Color.White;
            cardGridClientes.Controls.Add(lbTituloGridClientes);
            cardGridClientes.Controls.Add(dataGridView1);
            cardGridClientes.Location = new Point(20, 320);
            cardGridClientes.Name = "cardGridClientes";
            cardGridClientes.Padding = new Padding(20);
            cardGridClientes.Size = new Size(580, 220);
            cardGridClientes.TabIndex = 3;
            // 
            // lbTituloGridClientes
            // 
            lbTituloGridClientes.AutoSize = true;
            lbTituloGridClientes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGridClientes.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGridClientes.Location = new Point(20, 20);
            lbTituloGridClientes.Name = "lbTituloGridClientes";
            lbTituloGridClientes.Size = new Size(176, 25);
            lbTituloGridClientes.TabIndex = 0;
            lbTituloGridClientes.Text = "📋 Lista de Clientes";
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
            dataGridView1.Size = new Size(540, 145);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cardBotoes
            // 
            cardBotoes.BackColor = Color.Transparent;
            cardBotoes.Controls.Add(btnGravar);
            cardBotoes.Controls.Add(btnLimpar);
            cardBotoes.Controls.Add(btnGravarVeiculo);
            cardBotoes.Controls.Add(btnLimparVeiculo);
            cardBotoes.Location = new Point(20, 240);
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
            btnGravar.Text = "💾 Gravar Cliente";
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
            btnLimpar.Text = "🗑️ Limpar Cliente";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnGravarVeiculo
            // 
            btnGravarVeiculo.BackColor = Color.FromArgb(13, 110, 253);
            btnGravarVeiculo.FlatAppearance.BorderSize = 0;
            btnGravarVeiculo.FlatStyle = FlatStyle.Flat;
            btnGravarVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGravarVeiculo.ForeColor = Color.White;
            btnGravarVeiculo.Location = new Point(620, 15);
            btnGravarVeiculo.Name = "btnGravarVeiculo";
            btnGravarVeiculo.Size = new Size(120, 40);
            btnGravarVeiculo.TabIndex = 2;
            btnGravarVeiculo.Text = "🚗 Gravar Veículo";
            btnGravarVeiculo.UseVisualStyleBackColor = false;
            btnGravarVeiculo.Click += btnGravarVeiculo_Click;
            // 
            // btnLimparVeiculo
            // 
            btnLimparVeiculo.BackColor = Color.FromArgb(220, 53, 69);
            btnLimparVeiculo.FlatAppearance.BorderSize = 0;
            btnLimparVeiculo.FlatStyle = FlatStyle.Flat;
            btnLimparVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimparVeiculo.ForeColor = Color.White;
            btnLimparVeiculo.Location = new Point(750, 15);
            btnLimparVeiculo.Name = "btnLimparVeiculo";
            btnLimparVeiculo.Size = new Size(120, 40);
            btnLimparVeiculo.TabIndex = 3;
            btnLimparVeiculo.Text = "🗑️ Limpar Veículo";
            btnLimparVeiculo.UseVisualStyleBackColor = false;
            btnLimparVeiculo.Click += btnLimparVeiculo_Click;
            // 
            // cardVeiculo
            // 
            cardVeiculo.BackColor = Color.White;
            cardVeiculo.Controls.Add(lbTituloVeiculo);
            cardVeiculo.Controls.Add(lbPlaca);
            cardVeiculo.Controls.Add(tbPlaca);
            cardVeiculo.Controls.Add(lbMarca);
            cardVeiculo.Controls.Add(tbMarca);
            cardVeiculo.Controls.Add(lbModelo);
            cardVeiculo.Controls.Add(tbModelo);
            cardVeiculo.Location = new Point(620, 20);
            cardVeiculo.Name = "cardVeiculo";
            cardVeiculo.Padding = new Padding(20);
            cardVeiculo.Size = new Size(560, 200);
            cardVeiculo.TabIndex = 1;
            // 
            // lbTituloVeiculo
            // 
            lbTituloVeiculo.AutoSize = true;
            lbTituloVeiculo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloVeiculo.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloVeiculo.Location = new Point(20, 20);
            lbTituloVeiculo.Name = "lbTituloVeiculo";
            lbTituloVeiculo.Size = new Size(194, 25);
            lbTituloVeiculo.TabIndex = 0;
            lbTituloVeiculo.Text = "🚗 Dados do Veículo";
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Font = new Font("Segoe UI", 10F);
            lbPlaca.ForeColor = Color.FromArgb(73, 80, 87);
            lbPlaca.Location = new Point(20, 60);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new Size(43, 19);
            lbPlaca.TabIndex = 1;
            lbPlaca.Text = "Placa:";
            // 
            // tbPlaca
            // 
            tbPlaca.Font = new Font("Segoe UI", 10F);
            tbPlaca.Location = new Point(20, 85);
            tbPlaca.Name = "tbPlaca";
            tbPlaca.Size = new Size(150, 25);
            tbPlaca.TabIndex = 2;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Segoe UI", 10F);
            lbMarca.ForeColor = Color.FromArgb(73, 80, 87);
            lbMarca.Location = new Point(200, 60);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(50, 19);
            lbMarca.TabIndex = 3;
            lbMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            tbMarca.Font = new Font("Segoe UI", 10F);
            tbMarca.Location = new Point(200, 85);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(150, 25);
            tbMarca.TabIndex = 4;
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Font = new Font("Segoe UI", 10F);
            lbModelo.ForeColor = Color.FromArgb(73, 80, 87);
            lbModelo.Location = new Point(380, 60);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(59, 19);
            lbModelo.TabIndex = 5;
            lbModelo.Text = "Modelo:";
            // 
            // tbModelo
            // 
            tbModelo.Font = new Font("Segoe UI", 10F);
            tbModelo.Location = new Point(380, 85);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(170, 25);
            tbModelo.TabIndex = 6;
            // 
            // cardCliente
            // 
            cardCliente.BackColor = Color.White;
            cardCliente.Controls.Add(lbTituloCliente);
            cardCliente.Controls.Add(lbNomeClient);
            cardCliente.Controls.Add(tbNomeClient);
            cardCliente.Controls.Add(lbEmail);
            cardCliente.Controls.Add(tbEmail);
            cardCliente.Controls.Add(lbTelefone);
            cardCliente.Controls.Add(tbTelefone);
            cardCliente.Location = new Point(20, 20);
            cardCliente.Name = "cardCliente";
            cardCliente.Padding = new Padding(20);
            cardCliente.Size = new Size(580, 200);
            cardCliente.TabIndex = 0;
            // 
            // lbTituloCliente
            // 
            lbTituloCliente.AutoSize = true;
            lbTituloCliente.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloCliente.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloCliente.Location = new Point(20, 20);
            lbTituloCliente.Name = "lbTituloCliente";
            lbTituloCliente.Size = new Size(186, 25);
            lbTituloCliente.TabIndex = 0;
            lbTituloCliente.Text = "👤 Dados do Cliente";
            // 
            // lbNomeClient
            // 
            lbNomeClient.AutoSize = true;
            lbNomeClient.Font = new Font("Segoe UI", 10F);
            lbNomeClient.ForeColor = Color.FromArgb(73, 80, 87);
            lbNomeClient.Location = new Point(20, 60);
            lbNomeClient.Name = "lbNomeClient";
            lbNomeClient.Size = new Size(49, 19);
            lbNomeClient.TabIndex = 1;
            lbNomeClient.Text = "Nome:";
            // 
            // tbNomeClient
            // 
            tbNomeClient.Font = new Font("Segoe UI", 10F);
            tbNomeClient.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeClient.Location = new Point(20, 85);
            tbNomeClient.MaxLength = 250;
            tbNomeClient.Name = "tbNomeClient";
            tbNomeClient.Size = new Size(250, 25);
            tbNomeClient.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 10F);
            lbEmail.ForeColor = Color.FromArgb(73, 80, 87);
            lbEmail.Location = new Point(20, 130);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(50, 19);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "E-mail:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10F);
            tbEmail.ForeColor = Color.FromArgb(55, 65, 81);
            tbEmail.Location = new Point(20, 155);
            tbEmail.MaxLength = 250;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(530, 25);
            tbEmail.TabIndex = 6;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Segoe UI", 10F);
            lbTelefone.ForeColor = Color.FromArgb(73, 80, 87);
            lbTelefone.Location = new Point(300, 60);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(62, 19);
            lbTelefone.TabIndex = 3;
            lbTelefone.Text = "Telefone:";
            // 
            // tbTelefone
            // 
            tbTelefone.Font = new Font("Segoe UI", 10F);
            tbTelefone.ForeColor = Color.FromArgb(55, 65, 81);
            tbTelefone.Location = new Point(300, 85);
            tbTelefone.MaxLength = 250;
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(250, 25);
            tbTelefone.TabIndex = 4;
            // 
            // CadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "CadCliente";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardGridVeiculos.ResumeLayout(false);
            cardGridVeiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVeiculos).EndInit();
            cardGridClientes.ResumeLayout(false);
            cardGridClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cardBotoes.ResumeLayout(false);
            cardVeiculo.ResumeLayout(false);
            cardVeiculo.PerformLayout();
            cardCliente.ResumeLayout(false);
            cardCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Controles principais
        private DataGridView dataGridView1;
        private DataGridView dataGridViewVeiculos;
        private Button btnGravar;
        private Button btnLimpar;
        private Button btnGravarVeiculo;
        private Button btnLimparVeiculo;
        
        // Campos do cliente
        private Label lbNomeClient;
        private TextBox tbNomeClient;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbTelefone;
        private TextBox tbTelefone;
        
        // Campos do veículo
        private Label lbPlaca;
        private TextBox tbPlaca;
        private Label lbMarca;
        private TextBox tbMarca;
        private Label lbModelo;
        private TextBox tbModelo;
        
        // Cards modernos
        private Panel mainContainer;
        private Panel cardCliente;
        private Panel cardVeiculo;
        private Panel cardGridClientes;
        private Panel cardGridVeiculos;
        private Panel cardBotoes;
        
        // Labels de título
        private Label lbTituloCliente;
        private Label lbTituloVeiculo;
        private Label lbTituloGridClientes;
        private Label lbTituloGridVeiculos;
    }
}
