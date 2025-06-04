namespace Salomao.Cadastros
{
    partial class CadVeiculo
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
            btnLimpar = new Button();
            btnGravar = new Button();
            tbModelo = new TextBox();
            tbPlaca = new TextBox();
            tbMarca = new TextBox();
            lbTitular = new Label();
            lbPlaca = new Label();
            lbMarca = new Label();
            lbModelo = new Label();
            panel1 = new Panel();
            cbTitular = new ComboBox();
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
            dataGridView1.TabIndex = 2;
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
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
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
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // tbModelo
            // 
            tbModelo.ForeColor = Color.FromArgb(55, 65, 81);
            tbModelo.Location = new Point(25, 185);
            tbModelo.MaxLength = 250;
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(200, 23);
            tbModelo.TabIndex = 3;
            // 
            // tbPlaca
            // 
            tbPlaca.ForeColor = Color.FromArgb(55, 65, 81);
            tbPlaca.Location = new Point(25, 47);
            tbPlaca.MaxLength = 250;
            tbPlaca.Name = "tbPlaca";
            tbPlaca.Size = new Size(200, 23);
            tbPlaca.TabIndex = 0;
            // 
            // tbMarca
            // 
            tbMarca.ForeColor = Color.FromArgb(55, 65, 81);
            tbMarca.Location = new Point(25, 116);
            tbMarca.MaxLength = 250;
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(200, 23);
            tbMarca.TabIndex = 2;
            // 
            // lbTitular
            // 
            lbTitular.AutoSize = true;
            lbTitular.BackColor = Color.White;
            lbTitular.Font = new Font("Segoe UI", 12F);
            lbTitular.ForeColor = Color.Black;
            lbTitular.Location = new Point(282, 19);
            lbTitular.Name = "lbTitular";
            lbTitular.Size = new Size(57, 21);
            lbTitular.TabIndex = 30;
            lbTitular.Text = "Titular:";
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.BackColor = Color.White;
            lbPlaca.Font = new Font("Segoe UI", 12F);
            lbPlaca.ForeColor = Color.Black;
            lbPlaca.Location = new Point(25, 19);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new Size(49, 21);
            lbPlaca.TabIndex = 19;
            lbPlaca.Text = "Placa:";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.BackColor = Color.White;
            lbMarca.Font = new Font("Segoe UI", 12F);
            lbMarca.ForeColor = Color.Black;
            lbMarca.Location = new Point(25, 88);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(56, 21);
            lbMarca.TabIndex = 34;
            lbMarca.Text = "Marca:";
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.BackColor = Color.White;
            lbModelo.Font = new Font("Segoe UI", 12F);
            lbModelo.ForeColor = Color.Black;
            lbModelo.Location = new Point(25, 157);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(66, 21);
            lbModelo.TabIndex = 35;
            lbModelo.Text = "Modelo:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbPlaca);
            panel1.Controls.Add(tbPlaca);
            panel1.Controls.Add(lbMarca);
            panel1.Controls.Add(tbMarca);
            panel1.Controls.Add(lbModelo);
            panel1.Controls.Add(tbModelo);
            panel1.Controls.Add(lbTitular);
            panel1.Controls.Add(cbTitular);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnGravar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 258);
            panel1.TabIndex = 1;
            // 
            // cbTitular
            // 
            cbTitular.FormattingEnabled = true;
            cbTitular.Location = new Point(282, 47);
            cbTitular.Name = "cbTitular";
            cbTitular.Size = new Size(200, 23);
            cbTitular.TabIndex = 1;
            // 
            // CadVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadVeiculo";
            Size = new Size(983, 517);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button btnLimpar;
        private Label lbTitular;
        private Button btnGravar;
        private DataGridView dataGridView1;
        private TextBox tbModelo;
        private Label lbPlaca;
        private TextBox tbPlaca;
        private TextBox tbMarca;
        private Label lbMarca;
        private Label lbModelo;
        private Panel panel1;
        private ComboBox cbTitular;
    }
}
