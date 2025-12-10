namespace AutoPecas.Cadastros
{
    partial class SaldoEstoque
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
            cardHeader = new Panel();
            lbTituloHeader = new Label();
            btnExportar = new Button();
            btnAtualizar = new Button();
            label1 = new Label();
            mainContainer.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cardHeader.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Controls.Add(cardGrid);
            mainContainer.Controls.Add(cardHeader);
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
            cardGrid.Location = new Point(20, 140);
            cardGrid.Name = "cardGrid";
            cardGrid.Padding = new Padding(20);
            cardGrid.Size = new Size(1160, 640);
            cardGrid.TabIndex = 1;
            // 
            // lbTituloGrid
            // 
            lbTituloGrid.AutoSize = true;
            lbTituloGrid.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGrid.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloGrid.Location = new Point(20, 20);
            lbTituloGrid.Name = "lbTituloGrid";
            lbTituloGrid.Size = new Size(190, 25);
            lbTituloGrid.TabIndex = 0;
            lbTituloGrid.Text = "📋 Lista de Produtos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(20, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1120, 565);
            dataGridView1.TabIndex = 1;
            // 
            // cardHeader
            // 
            cardHeader.BackColor = Color.White;
            cardHeader.Controls.Add(lbTituloHeader);
            cardHeader.Controls.Add(btnExportar);
            cardHeader.Controls.Add(btnAtualizar);
            cardHeader.Location = new Point(20, 20);
            cardHeader.Name = "cardHeader";
            cardHeader.Padding = new Padding(20);
            cardHeader.Size = new Size(1160, 100);
            cardHeader.TabIndex = 0;
            // 
            // lbTituloHeader
            // 
            lbTituloHeader.AutoSize = true;
            lbTituloHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloHeader.ForeColor = Color.FromArgb(33, 37, 41);
            lbTituloHeader.Location = new Point(20, 20);
            lbTituloHeader.Name = "lbTituloHeader";
            lbTituloHeader.Size = new Size(191, 25);
            lbTituloHeader.TabIndex = 0;
            lbTituloHeader.Text = "📊 Saldo de Estoque";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(25, 135, 84);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(870, 20);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 40);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "📄 Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(13, 110, 253);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(1000, 20);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(120, 40);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "🔄 Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // SaldoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "SaldoEstoque";
            Size = new Size(1200, 800);
            mainContainer.ResumeLayout(false);
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cardHeader.ResumeLayout(false);
            cardHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Controles principais
        private DataGridView dataGridView1;
        private Button btnExportar;
        private Button btnAtualizar;
        private Label label1;
        
        // Cards modernos
        private Panel mainContainer;
        private Panel cardHeader;
        private Panel cardGrid;
        
        // Labels de título
        private Label lbTituloHeader;
        private Label lbTituloGrid;
    }
} 