using BookShop_shenuLogin.referenceForm;
using BookShop_shenuLogin.referenceForm.Books;
using BookShop_shenuLogin.referenceForm.Other;
using BookShop_shenuLogin.referenceForm.Stationary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static BookShop_shenuLogin.referenceForm.cart;

namespace BookShop_shenuLogin
{
    public partial class MainMenu : Form
    {
        public static TextBox tx;
        //Fields
        private Button CurrentButton;
        private Random random;
        private int tempIndex;
        private Form currentChildForm;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
       
        public MainMenu()
        {
            InitializeComponent();
            random = new Random();
            
        }
        // methods

        //load order ID
        public void setOrderID()
        {
            con.Open();
            string searchID = "SELECT MAX(OrdersID) AS id FROM bookshop.orders";
            MySqlCommand cmd = new MySqlCommand(searchID, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"].ToString());
                    labOrderID.Text = (id + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Order !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
            dr.Close();

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColcrList.Count);
            while (tempIndex == index)
            {
              index=  random.Next(ThemeColor.ColcrList.Count);
            }
            tempIndex = index;
            String color = ThemeColor.ColcrList[index];
               return ColorTranslator.FromHtml(color);

        }
        private void ActivateButton(object btnSender)
        {

            if (btnSender != null)

            {

                if (CurrentButton != (Button)btnSender)

                {
                    DisableButton();
                    Color color = SelectThemeColor();

                    CurrentButton = (Button)btnSender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 
                }

            }
        }

        private void DisableButton()

        {

            foreach (Control previousBtn in panelMenu.Controls)

            {

                if (previousBtn.GetType() == typeof(Button))

{

                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);

                    previousBtn.ForeColor = Color.Gainsboro;

                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }

            }

        }
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main.Controls.Add(childForm);
            main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            tx = labOrderID;
            ActivateButton(sender);
            lblTitle.Text = "Books";
            openChildForm(new bookMain(tx));
        }

        private void btnStationary_Click(object sender, EventArgs e)
        {
            tx = labOrderID;
            ActivateButton(sender);
            lblTitle.Text = "Stationary";
            openChildForm(new stationaryMain(tx));
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            tx = labOrderID;
            ActivateButton(sender);
            lblTitle.Text = "Others";
            openChildForm(new otherMain(tx));
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            tx = labOrderID;
            ActivateButton(sender);
            lblTitle.Text = "Cart";
            openChildForm(new cart(tx));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                con = DBConection.ConnectDB();
                setOrderID();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }   
}
