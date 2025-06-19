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
            lbVeiculo = new Label();
            lbMargem = new Label();
            cbVeiculo = new ComboBox();
            tbMargem = new DecimalTextbox();
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
            panel1.Controls.Add(lbVeiculo);
            panel1.Controls.Add(lbMargem);
            panel1.Controls.Add(cbVeiculo);
            panel1.Controls.Add(tbMargem);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 258);
            panel1.TabIndex = 2;
            // 
            // lbVeiculo
            // 
            lbVeiculo.AutoSize = true;
            lbVeiculo.BackColor = Color.White;
            lbVeiculo.Font = new Font("Segoe UI", 12F);
            lbVeiculo.ForeColor = Color.Black;
            lbVeiculo.Location = new Point(25, 19);
            lbVeiculo.Name = "lbVeiculo";
            lbVeiculo.Size = new Size(63, 21);
            lbVeiculo.TabIndex = 1;
            lbVeiculo.Text = "Veiculo:";
            // 
            // lbMargem
            // 
            lbMargem.AutoSize = true;
            lbMargem.BackColor = Color.White;
            lbMargem.Font = new Font("Segoe UI", 12F);
            lbMargem.ForeColor = Color.Black;
            lbMargem.Location = new Point(25, 88);
            lbMargem.Name = "lbMargem";
            lbMargem.Size = new Size(163, 21);
            lbMargem.TabIndex = 3;
            lbMargem.Text = "Margem de Lucro (%):";
            // 
            // cbVeiculo
            // 
            cbVeiculo.ForeColor = Color.FromArgb(55, 65, 81);
            cbVeiculo.Location = new Point(25, 47);
            cbVeiculo.MaxLength = 250;
            cbVeiculo.Name = "cbVeiculo";
            cbVeiculo.Size = new Size(200, 23);
            cbVeiculo.TabIndex = 3;
            // 
            // tbMargem
            // 
            tbMargem.ForeColor = Color.FromArgb(55, 65, 81);
            tbMargem.Location = new Point(25, 116);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(983, 259);
            dataGridView1.TabIndex = 3;
            // 
            // CadServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadServicos";
            Size = new Size(983, 517);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbVeiculo;
        private ComboBox cbVeiculo;
        private Label lbMargem;
        private DecimalTextbox tbMargem;
        private Button btnGravar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
    }
}
