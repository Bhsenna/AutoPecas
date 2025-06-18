namespace Salomao.Cadastros
{
    partial class CadCategoria
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
            btnLimpar = new Button();
            btnGravar = new Button();
            dataGridView1 = new DataGridView();
            lbNomeCat = new Label();
            tbNomeCat = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(983, 259);
            dataGridView1.TabIndex = 3;
            // 
            // lbNomeCat
            // 
            lbNomeCat.AutoSize = true;
            lbNomeCat.BackColor = Color.White;
            lbNomeCat.Font = new Font("Segoe UI", 12F);
            lbNomeCat.ForeColor = Color.Black;
            lbNomeCat.Location = new Point(25, 19);
            lbNomeCat.Name = "lbNomeCat";
            lbNomeCat.Size = new Size(56, 21);
            lbNomeCat.TabIndex = 22;
            lbNomeCat.Text = "Nome:";
            // 
            // tbNomeCat
            // 
            tbNomeCat.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeCat.Location = new Point(25, 47);
            tbNomeCat.MaxLength = 250;
            tbNomeCat.Name = "tbNomeCat";
            tbNomeCat.Size = new Size(200, 23);
            tbNomeCat.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(lbNomeCat);
            panel1.Controls.Add(tbNomeCat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 258);
            panel1.TabIndex = 35;
            // 
            // CadCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CadCategoria";
            Size = new Size(983, 517);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button       btnLimpar;
        private Button       btnGravar;
        private DataGridView dataGridView1;
        private Label        lbNomeCat;
        private TextBox      tbNomeCat;
        private Panel        panel1;
    }
}
