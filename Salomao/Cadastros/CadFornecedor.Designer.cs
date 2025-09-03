namespace Salomao.Cadastros
{
    partial class CadFornecedor
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
            // Inicialização dos controles
            mainContainer = new Panel();
            cardFornecedor = new Panel();
            cardGrid = new Panel();
            cardBotoes = new Panel();
            
            lbEndereco = new Label();
            tbEndereco = new TextBox();
            lbTelefone = new Label();
            tbTelefone = new TextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbNomeFor = new Label();
            tbNomeFor = new TextBox();
            btnGravar = new Button();
            btnLimpar = new Button();
            dataGridView1 = new DataGridView();
            
            // Labels de título
            lbTituloFornecedor = new Label();
            lbTituloGrid = new Label();
            
            // Eventos
            btnGravar.Click += btnGravar_Click;
            btnLimpar.Click += btnLimpar_Click;
            
            mainContainer.SuspendLayout();
            cardFornecedor.SuspendLayout();
            cardGrid.SuspendLayout();
            cardBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGrid);
            mainContainer.Controls.Add(cardBotoes);
            mainContainer.Controls.Add(cardFornecedor);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(20);
            mainContainer.Size = new Size(1200, 800);
            mainContainer.TabIndex = 0;
            
            // 
            // cardFornecedor
            // 
            cardFornecedor.BackColor = Color.White;
            cardFornecedor.Controls.Add(lbTituloFornecedor);
            cardFornecedor.Controls.Add(lbNomeFor);
            cardFornecedor.Controls.Add(tbNomeFor);
            cardFornecedor.Controls.Add(lbEndereco);
            cardFornecedor.Controls.Add(tbEndereco);
            cardFornecedor.Controls.Add(lbTelefone);
            cardFornecedor.Controls.Add(tbTelefone);
            cardFornecedor.Controls.Add(lbEmail);
            cardFornecedor.Controls.Add(tbEmail);
            cardFornecedor.Location = new Point(20, 20);
            cardFornecedor.Name = "cardFornecedor";
            cardFornecedor.Padding = new Padding(20);
            cardFornecedor.Size = new Size(1160, 200);
            cardFornecedor.TabIndex = 0;
            
            // 
            // lbTituloFornecedor
            // 
            lbTituloFornecedor.AutoSize = true;
            lbTituloFornecedor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloFornecedor.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloFornecedor.Location = new Point(20, 20);
            lbTituloFornecedor.Name = "lbTituloFornecedor";
            lbTituloFornecedor.Size = new Size(150, 25);
            lbTituloFornecedor.TabIndex = 0;
            lbTituloFornecedor.Text = "🏢 Dados do Fornecedor";
            
            // 
            // lbNomeFor
            // 
            lbNomeFor.AutoSize = true;
            lbNomeFor.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbNomeFor.ForeColor = Color.FromArgb(73, 80, 87);
            lbNomeFor.Location = new Point(20, 60);
            lbNomeFor.Name = "lbNomeFor";
            lbNomeFor.Size = new Size(50, 19);
            lbNomeFor.TabIndex = 1;
            lbNomeFor.Text = "Nome:";
            
            // 
            // tbNomeFor
            // 
            tbNomeFor.Font = new Font("Segoe UI", 10F);
            tbNomeFor.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeFor.Location = new Point(20, 85);
            tbNomeFor.MaxLength = 250;
            tbNomeFor.Name = "tbNomeFor";
            tbNomeFor.Size = new Size(250, 25);
            tbNomeFor.TabIndex = 2;
            
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbEndereco.ForeColor = Color.FromArgb(73, 80, 87);
            lbEndereco.Location = new Point(300, 60);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(70, 19);
            lbEndereco.TabIndex = 3;
            lbEndereco.Text = "Endereço:";
            
            // 
            // tbEndereco
            // 
            tbEndereco.Font = new Font("Segoe UI", 10F);
            tbEndereco.ForeColor = Color.FromArgb(55, 65, 81);
            tbEndereco.Location = new Point(300, 85);
            tbEndereco.MaxLength = 250;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(300, 25);
            tbEndereco.TabIndex = 4;
            
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbTelefone.ForeColor = Color.FromArgb(73, 80, 87);
            lbTelefone.Location = new Point(20, 130);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(65, 19);
            lbTelefone.TabIndex = 5;
            lbTelefone.Text = "Telefone:";
            
            // 
            // tbTelefone
            // 
            tbTelefone.Font = new Font("Segoe UI", 10F);
            tbTelefone.ForeColor = Color.FromArgb(55, 65, 81);
            tbTelefone.Location = new Point(20, 155);
            tbTelefone.MaxLength = 250;
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(200, 25);
            tbTelefone.TabIndex = 6;
            
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbEmail.ForeColor = Color.FromArgb(73, 80, 87);
            lbEmail.Location = new Point(250, 130);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(50, 19);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "E-mail:";
            
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10F);
            tbEmail.ForeColor = Color.FromArgb(55, 65, 81);
            tbEmail.Location = new Point(250, 155);
            tbEmail.MaxLength = 250;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(350, 25);
            tbEmail.TabIndex = 8;
            
            // 
            // cardBotoes
            // 
            cardBotoes.BackColor = Color.Transparent;
            cardBotoes.Controls.Add(btnGravar);
            cardBotoes.Controls.Add(btnLimpar);
            cardBotoes.Location = new Point(20, 240);
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
            btnGravar.Location = new Point(1050, 15);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(120, 40);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "💾 Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(920, 15);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 40);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "🗑️ Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            
            // 
            // cardGrid
            // 
            cardGrid.BackColor = Color.White;
            cardGrid.Controls.Add(lbTituloGrid);
            cardGrid.Controls.Add(dataGridView1);
            cardGrid.Location = new Point(20, 320);
            cardGrid.Name = "cardGrid";
            cardGrid.Padding = new Padding(20);
            cardGrid.Size = new Size(1160, 460);
            cardGrid.TabIndex = 2;
            
            // 
            // lbTituloGrid
            // 
            lbTituloGrid.AutoSize = true;
            lbTituloGrid.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGrid.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGrid.Location = new Point(20, 20);
            lbTituloGrid.Name = "lbTituloGrid";
            lbTituloGrid.Size = new Size(200, 25);
            lbTituloGrid.TabIndex = 0;
            lbTituloGrid.Text = "📋 Lista de Fornecedores";
            
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(20, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1120, 385);
            dataGridView1.TabIndex = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // 
            // CadFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "CadFornecedor";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardFornecedor.ResumeLayout(false);
            cardFornecedor.PerformLayout();
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            cardBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Controles principais
        private Label lbEndereco;
        private TextBox tbEndereco;
        private Label lbTelefone;
        private TextBox tbTelefone;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbNomeFor;
        private TextBox tbNomeFor;
        private Button btnGravar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
        
        // Cards modernos
        private Panel mainContainer;
        private Panel cardFornecedor;
        private Panel cardGrid;
        private Panel cardBotoes;
        
        // Labels de título
        private Label lbTituloFornecedor;
        private Label lbTituloGrid;
    }
}
