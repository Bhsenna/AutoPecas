using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;

namespace Salomao
{
    public partial class TelaInicial : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public TelaInicial()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_Menu.Controls.Add(leftBorderBtn);
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
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon current form
                icon_Current.IconChar = currentBtn.IconChar;
                icon_Current.IconColor = color;
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtn_Produtos_Click(object sender, EventArgs e)
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

        private void ibtn_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtn_Clientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void ibtn_Veiculos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void ibtn_Servicos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void ibtn_Config_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icon_Current.IconChar = IconChar.House;
            icon_Current.IconColor = Color.White;
            lab_Title.Text = "Home";
        }
    }
}
