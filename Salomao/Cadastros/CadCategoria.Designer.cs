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
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpar.BackColor = Color.LightGray;
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(387, 405);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 28;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGravar.BackColor = Color.FromArgb(0, 123, 255);
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(478, 405);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 30;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(594, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(466, 463);
            dataGridView1.TabIndex = 31;
            // 
            // lbNomeCat
            // 
            lbNomeCat.AutoSize = true;
            lbNomeCat.Font = new Font("Segoe UI", 12F);
            lbNomeCat.Location = new Point(25, 19);
            lbNomeCat.Name = "lbNomeCat";
            lbNomeCat.Size = new Size(56, 21);
            lbNomeCat.TabIndex = 22;
            lbNomeCat.Text = "Nome:";
            // 
            // tbNomeCat
            // 
            tbNomeCat.Location = new Point(25, 47);
            tbNomeCat.MaxLength = 250;
            tbNomeCat.Name = "tbNomeCat";
            tbNomeCat.Size = new Size(200, 23);
            tbNomeCat.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnLimpar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 463);
            panel1.TabIndex = 35;
            // 
            // CadCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(lbNomeCat);
            Controls.Add(tbNomeCat);
            Controls.Add(panel1);
            Name = "CadCategoria";
            Size = new Size(1060, 463);
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
