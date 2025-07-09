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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            lbNomeClient = new Label();
            tbNomeClient = new TextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbTelefone = new Label();
            tbTelefone = new TextBox();
            btnGravar = new Button();
            btnLimpar = new Button();
            dataGridViewVeiculos = new DataGridView();
            panelVeiculo = new Panel();
            lbPlaca = new Label();
            lbMarca = new Label();
            lbModelo = new Label();
            tbPlaca = new TextBox();
            tbMarca = new TextBox();
            tbModelo = new TextBox();
            btnGravarVeiculo = new Button();
            btnLimparVeiculo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(983, 259);
            dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbNomeClient);
            panel1.Controls.Add(tbNomeClient);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lbTelefone);
            panel1.Controls.Add(tbTelefone);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 258);
            panel1.TabIndex = 21;
            // 
            // lbNomeClient
            // 
            lbNomeClient.AutoSize = true;
            lbNomeClient.BackColor = Color.White;
            lbNomeClient.Font = new Font("Segoe UI", 12F);
            lbNomeClient.ForeColor = Color.Black;
            lbNomeClient.Location = new Point(25, 19);
            lbNomeClient.Name = "lbNomeClient";
            lbNomeClient.Size = new Size(56, 21);
            lbNomeClient.TabIndex = 10;
            lbNomeClient.Text = "Nome:";
            // 
            // tbNomeClient
            // 
            tbNomeClient.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeClient.Location = new Point(25, 47);
            tbNomeClient.MaxLength = 250;
            tbNomeClient.Name = "tbNomeClient";
            tbNomeClient.Size = new Size(200, 23);
            tbNomeClient.TabIndex = 9;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.White;
            lbEmail.Font = new Font("Segoe UI", 12F);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(25, 157);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(57, 21);
            lbEmail.TabIndex = 39;
            lbEmail.Text = "E-mail:";
            // 
            // tbEmail
            // 
            tbEmail.ForeColor = Color.FromArgb(55, 65, 81);
            tbEmail.Location = new Point(25, 185);
            tbEmail.MaxLength = 250;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 23);
            tbEmail.TabIndex = 37;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.White;
            lbTelefone.Font = new Font("Segoe UI", 12F);
            lbTelefone.ForeColor = Color.Black;
            lbTelefone.Location = new Point(25, 88);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(70, 21);
            lbTelefone.TabIndex = 38;
            lbTelefone.Text = "Telefone:";
            // 
            // tbTelefone
            // 
            tbTelefone.ForeColor = Color.FromArgb(55, 65, 81);
            tbTelefone.Location = new Point(25, 116);
            tbTelefone.MaxLength = 250;
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(200, 23);
            tbTelefone.TabIndex = 36;
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
            // dataGridViewVeiculos
            // 
            dataGridViewVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVeiculos.Location = new Point(500, 258);
            dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            dataGridViewVeiculos.Size = new Size(483, 259);
            dataGridViewVeiculos.TabIndex = 21;
            // 
            // panelVeiculo
            // 
            panelVeiculo.BackColor = Color.White;
            panelVeiculo.Controls.Add(lbPlaca);
            panelVeiculo.Controls.Add(tbPlaca);
            panelVeiculo.Controls.Add(lbMarca);
            panelVeiculo.Controls.Add(tbMarca);
            panelVeiculo.Controls.Add(lbModelo);
            panelVeiculo.Controls.Add(tbModelo);
            panelVeiculo.Controls.Add(btnGravarVeiculo);
            panelVeiculo.Controls.Add(btnLimparVeiculo);
            panelVeiculo.Location = new Point(350, 0);
            panelVeiculo.Name = "panelVeiculo";
            panelVeiculo.Size = new Size(300, 258);
            panelVeiculo.TabIndex = 22;
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Font = new Font("Segoe UI", 12F);
            lbPlaca.Location = new Point(20, 19);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new Size(49, 21);
            lbPlaca.TabIndex = 0;
            lbPlaca.Text = "Placa:";
            // 
            // tbPlaca
            // 
            tbPlaca.Location = new Point(20, 47);
            tbPlaca.Name = "tbPlaca";
            tbPlaca.Size = new Size(200, 23);
            tbPlaca.TabIndex = 1;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Segoe UI", 12F);
            lbMarca.Location = new Point(20, 88);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(56, 21);
            lbMarca.TabIndex = 2;
            lbMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(20, 116);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(200, 23);
            tbMarca.TabIndex = 3;
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Font = new Font("Segoe UI", 12F);
            lbModelo.Location = new Point(20, 157);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(66, 21);
            lbModelo.TabIndex = 4;
            lbModelo.Text = "Modelo:";
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(20, 185);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(200, 23);
            tbModelo.TabIndex = 5;
            // 
            // btnGravarVeiculo
            // 
            btnGravarVeiculo.BackColor = Color.FromArgb(0, 123, 255);
            btnGravarVeiculo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGravarVeiculo.ForeColor = Color.White;
            btnGravarVeiculo.Location = new Point(180, 210);
            btnGravarVeiculo.Name = "btnGravarVeiculo";
            btnGravarVeiculo.Size = new Size(100, 36);
            btnGravarVeiculo.TabIndex = 6;
            btnGravarVeiculo.Text = "Gravar";
            btnGravarVeiculo.UseVisualStyleBackColor = false;
            btnGravarVeiculo.Click += new System.EventHandler(this.btnGravarVeiculo_Click);
            // 
            // btnLimparVeiculo
            // 
            btnLimparVeiculo.BackColor = Color.LightGray;
            btnLimparVeiculo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimparVeiculo.ForeColor = Color.Black;
            btnLimparVeiculo.Location = new Point(70, 210);
            btnLimparVeiculo.Name = "btnLimparVeiculo";
            btnLimparVeiculo.Size = new Size(100, 36);
            btnLimparVeiculo.TabIndex = 7;
            btnLimparVeiculo.Text = "Limpar";
            btnLimparVeiculo.UseVisualStyleBackColor = false;
            btnLimparVeiculo.Click += new System.EventHandler(this.btnLimparVeiculo_Click);
            // 
            // CadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(panelVeiculo);
            Controls.Add(dataGridViewVeiculos);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadCliente";
            Size = new Size(983, 517);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVeiculos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnGravar;
        private Button btnLimpar;
        private Label lbNomeClient;
        private TextBox tbNomeClient;
        private Label lbEmail;
        private Label lbTelefone;
        private TextBox tbTelefone;
        private TextBox tbEmail;
        private System.Windows.Forms.DataGridView dataGridViewVeiculos;
        private System.Windows.Forms.Panel panelVeiculo;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Button btnGravarVeiculo;
        private System.Windows.Forms.Button btnLimparVeiculo;
    }
}
