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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbEndereco);
            panel1.Controls.Add(tbEndereco);
            panel1.Controls.Add(lbTelefone);
            panel1.Controls.Add(tbTelefone);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lbNomeFor);
            panel1.Controls.Add(tbNomeFor);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 258);
            panel1.TabIndex = 36;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.BackColor = Color.White;
            lbEndereco.Font = new Font("Segoe UI", 12F);
            lbEndereco.ForeColor = Color.Black;
            lbEndereco.Location = new Point(282, 19);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(77, 21);
            lbEndereco.TabIndex = 30;
            lbEndereco.Text = "Endereço:";
            // 
            // tbEndereco
            // 
            tbEndereco.ForeColor = Color.FromArgb(55, 65, 81);
            tbEndereco.Location = new Point(282, 47);
            tbEndereco.MaxLength = 250;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(200, 23);
            tbEndereco.TabIndex = 25;
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
            lbTelefone.TabIndex = 26;
            lbTelefone.Text = "Telefone:";
            // 
            // tbTelefone
            // 
            tbTelefone.ForeColor = Color.FromArgb(55, 65, 81);
            tbTelefone.Location = new Point(25, 116);
            tbTelefone.MaxLength = 250;
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(200, 23);
            tbTelefone.TabIndex = 27;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.White;
            lbEmail.Font = new Font("Segoe UI", 12F);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(282, 88);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(57, 21);
            lbEmail.TabIndex = 29;
            lbEmail.Text = "E-mail:";
            // 
            // tbEmail
            // 
            tbEmail.ForeColor = Color.FromArgb(55, 65, 81);
            tbEmail.Location = new Point(282, 116);
            tbEmail.MaxLength = 250;
            tbEmail.Name = "tbEmail";
            tbEmail.ScrollBars = ScrollBars.Vertical;
            tbEmail.Size = new Size(200, 23);
            tbEmail.TabIndex = 28;
            // 
            // lbNomeFor
            // 
            lbNomeFor.AutoSize = true;
            lbNomeFor.BackColor = Color.White;
            lbNomeFor.Font = new Font("Segoe UI", 12F);
            lbNomeFor.ForeColor = Color.Black;
            lbNomeFor.Location = new Point(25, 19);
            lbNomeFor.Name = "lbNomeFor";
            lbNomeFor.Size = new Size(56, 21);
            lbNomeFor.TabIndex = 24;
            lbNomeFor.Text = "Nome:";
            // 
            // tbNomeFor
            // 
            tbNomeFor.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeFor.Location = new Point(25, 47);
            tbNomeFor.MaxLength = 250;
            tbNomeFor.Name = "tbNomeFor";
            tbNomeFor.Size = new Size(200, 23);
            tbNomeFor.TabIndex = 23;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.FromArgb(0, 123, 255);
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(871, 210);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 36);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.LightGray;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(759, 210);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 36);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(983, 259);
            dataGridView1.TabIndex = 37;
            // 
            // CadFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadFornecedor";
            Size = new Size(983, 517);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGravar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
        private Label lbNomeFor;
        private TextBox tbNomeFor;
        private Label lbEndereco;
        private TextBox tbEndereco;
        private Label lbTelefone;
        private TextBox tbTelefone;
        private Label lbEmail;
        private TextBox tbEmail;
    }
}
