using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using Salomao.Forms;

namespace Salomao
{
    public partial class TelaInicial : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public TelaInicial()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_menu.Controls.Add(leftBorderBtn);

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(36, 36, 36);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon current form
                icon_current.IconChar = currentBtn.IconChar;
                icon_current.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                // Button
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void openChildForm(Form childForm)
        {
            // Open child form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(childForm);
            panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lbl_title.Text = childForm.Text;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ibtn_produtos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);

            //string connectionString = "Server=localhost\\SQLEXPRESS;Database=AutoPecasDB;Trusted_Connection=True;TrustServerCertificate=True";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        MessageBox.Show("Conexão bem-sucedida");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Erro ao conectar: {ex.Message}");
            //    }
            //}
        }

        private void ibtn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtn_clientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void ibtn_veiculos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void ibtn_servicos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void ibtn_config_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icon_current.IconChar = IconChar.House;
            icon_current.IconColor = Color.White;
            lbl_title.Text = "Home";
        }
    }
}
