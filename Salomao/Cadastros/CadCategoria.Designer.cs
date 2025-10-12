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
            mainContainer = new Panel();
            cardGrid = new Panel();
            lbTituloGrid = new Label();
            dataGridView1 = new DataGridView();
            cardBotoes = new Panel();
            btnGravar = new Button();
            btnLimpar = new Button();
            cardCategoria = new Panel();
            lbTituloCategoria = new Label();
            lbNomeCat = new Label();
            tbNomeCat = new TextBox();
            mainContainer.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cardBotoes.SuspendLayout();
            cardCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGrid);
            mainContainer.Controls.Add(cardBotoes);
            mainContainer.Controls.Add(cardCategoria);
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
            cardGrid.Location = new Point(20, 270);
            cardGrid.Name = "cardGrid";
            cardGrid.Padding = new Padding(20);
            cardGrid.Size = new Size(1160, 510);
            cardGrid.TabIndex = 2;
            // 
            // lbTituloGrid
            // 
            lbTituloGrid.AutoSize = true;
            lbTituloGrid.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGrid.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGrid.Location = new Point(20, 20);
            lbTituloGrid.Name = "lbTituloGrid";
            lbTituloGrid.Size = new Size(201, 25);
            lbTituloGrid.TabIndex = 0;
            lbTituloGrid.Text = "📋 Lista de Categorias";
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
            dataGridView1.Size = new Size(1120, 435);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cardBotoes
            // 
            cardBotoes.BackColor = Color.Transparent;
            cardBotoes.Controls.Add(btnGravar);
            cardBotoes.Controls.Add(btnLimpar);
            cardBotoes.Location = new Point(20, 190);
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
            // cardCategoria
            // 
            cardCategoria.BackColor = Color.White;
            cardCategoria.Controls.Add(lbTituloCategoria);
            cardCategoria.Controls.Add(lbNomeCat);
            cardCategoria.Controls.Add(tbNomeCat);
            cardCategoria.Location = new Point(20, 20);
            cardCategoria.Name = "cardCategoria";
            cardCategoria.Padding = new Padding(20);
            cardCategoria.Size = new Size(1160, 150);
            cardCategoria.TabIndex = 0;
            // 
            // lbTituloCategoria
            // 
            lbTituloCategoria.AutoSize = true;
            lbTituloCategoria.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloCategoria.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloCategoria.Location = new Point(20, 20);
            lbTituloCategoria.Name = "lbTituloCategoria";
            lbTituloCategoria.Size = new Size(213, 25);
            lbTituloCategoria.TabIndex = 0;
            lbTituloCategoria.Text = "🏷️ Dados da Categoria";
            // 
            // lbNomeCat
            // 
            lbNomeCat.AutoSize = true;
            lbNomeCat.Font = new Font("Segoe UI", 10F);
            lbNomeCat.ForeColor = Color.FromArgb(73, 80, 87);
            lbNomeCat.Location = new Point(20, 60);
            lbNomeCat.Name = "lbNomeCat";
            lbNomeCat.Size = new Size(49, 19);
            lbNomeCat.TabIndex = 1;
            lbNomeCat.Text = "Nome:";
            // 
            // tbNomeCat
            // 
            tbNomeCat.Font = new Font("Segoe UI", 10F);
            tbNomeCat.ForeColor = Color.FromArgb(55, 65, 81);
            tbNomeCat.Location = new Point(20, 85);
            tbNomeCat.MaxLength = 250;
            tbNomeCat.Name = "tbNomeCat";
            tbNomeCat.Size = new Size(400, 25);
            tbNomeCat.TabIndex = 2;
            // 
            // CadCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "CadCategoria";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cardBotoes.ResumeLayout(false);
            cardCategoria.ResumeLayout(false);
            cardCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Controles principais
        private Button btnLimpar;
        private Button btnGravar;
        private DataGridView dataGridView1;
        private Label lbNomeCat;
        private TextBox tbNomeCat;
        
        // Cards modernos
        private Panel mainContainer;
        private Panel cardCategoria;
        private Panel cardGrid;
        private Panel cardBotoes;
        
        // Labels de título
        private Label lbTituloCategoria;
        private Label lbTituloGrid;
    }
}
