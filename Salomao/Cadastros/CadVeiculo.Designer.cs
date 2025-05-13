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
            tbTitular = new TextBox();
            tbModelo = new TextBox();
            tbPlaca = new TextBox();
            tbMarca = new TextBox();
            lbTitular = new Label();
            lbPlaca = new Label();
            lbMarca = new Label();
            lbModelo = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(594, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(606, 700);
            dataGridView1.TabIndex = 26;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpar.BackColor = Color.LightGray;
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(385, 646);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 32;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGravar.BackColor = Color.FromArgb(0, 123, 255);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(466, 646);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 31;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // tbTitular
            // 
            tbTitular.Location = new Point(270, 47);
            tbTitular.MaxLength = 250;
            tbTitular.Name = "tbTitular";
            tbTitular.Size = new Size(200, 23);
            tbTitular.TabIndex = 29;
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(13, 171);
            tbModelo.MaxLength = 250;
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(200, 23);
            tbModelo.TabIndex = 22;
            // 
            // tbPlaca
            // 
            tbPlaca.Location = new Point(13, 47);
            tbPlaca.MaxLength = 250;
            tbPlaca.Name = "tbPlaca";
            tbPlaca.Size = new Size(200, 23);
            tbPlaca.TabIndex = 18;
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(13, 112);
            tbMarca.MaxLength = 250;
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(200, 23);
            tbMarca.TabIndex = 33;
            // 
            // lbTitular
            // 
            lbTitular.AutoSize = true;
            lbTitular.Font = new Font("Segoe UI", 12F);
            lbTitular.Location = new Point(270, 19);
            lbTitular.Name = "lbTitular";
            lbTitular.Size = new Size(57, 21);
            lbTitular.TabIndex = 30;
            lbTitular.Text = "Titular:";
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Font = new Font("Segoe UI", 12F);
            lbPlaca.Location = new Point(13, 19);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new Size(49, 21);
            lbPlaca.TabIndex = 19;
            lbPlaca.Text = "Placa:";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Segoe UI", 12F);
            lbMarca.Location = new Point(13, 88);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(56, 21);
            lbMarca.TabIndex = 34;
            lbMarca.Text = "Marca:";
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Font = new Font("Segoe UI", 12F);
            lbModelo.Location = new Point(13, 147);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(66, 21);
            lbModelo.TabIndex = 35;
            lbModelo.Text = "Modelo:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 700);
            panel1.TabIndex = 36;
            // 
            // CadVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbModelo);
            Controls.Add(lbMarca);
            Controls.Add(tbMarca);
            Controls.Add(btnLimpar);
            Controls.Add(lbTitular);
            Controls.Add(tbTitular);
            Controls.Add(btnGravar);
            Controls.Add(dataGridView1);
            Controls.Add(tbModelo);
            Controls.Add(lbPlaca);
            Controls.Add(tbPlaca);
            Controls.Add(panel1);
            Name = "CadVeiculo";
            Size = new Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnLimpar;
        private Label lbTitular;
        private TextBox tbTitular;
        private Button btnGravar;
        private DataGridView dataGridView1;
        private TextBox tbModelo;
        private Label lbPlaca;
        private TextBox tbPlaca;
        private TextBox tbMarca;
        private Label lbMarca;
        private Label lbModelo;
        private Panel panel1;
    }
}
