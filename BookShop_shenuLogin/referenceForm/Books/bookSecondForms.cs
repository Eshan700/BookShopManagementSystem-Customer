using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BookShop_shenuLogin.referenceForm.Books
{
    public partial class bookSecondForms : Form
    {
        public static TextBox box;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string catagory = "";
        MainMenu mm = new MainMenu();
        string orderID = "";
        public bookSecondForms()
        {
            InitializeComponent();

        }
       
        public bookSecondForms(string name,TextBox x)
        {
            InitializeComponent();
            catagory = name;
            orderID = x.Text;
        }

        //method to show data into dataGrid

        public void shoGrid()
        {

            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM bookshop.product where Catagory='" +catagory+"'", con);
            dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dataGridView1);

                    newRow.Cells[0].Value = dr["ProductID"].ToString(); ;
                    newRow.Cells[1].Value = dr["ProductName"].ToString();
                    newRow.Cells[2].Value = dr["Brand"].ToString();
                    newRow.Cells[3].Value = dr["Author"].ToString();
                    newRow.Cells[4].Value = dr["Price"].ToString();
                    newRow.Cells[5].Value = dr["Image"];
                    

                    dataGridView1.Rows.Add(newRow);
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                }


                con.Close();
            }


        }

        private void bookSecondForms_Load(object sender, EventArgs e)
        {
            con = DBConection.ConnectDB();
            shoGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[6] as DataGridViewCheckBoxCell;
                    if (cell.Value != null)
                    {

                        if (cell.Value.Equals(true))
                        {
                            int product_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                            
                            int order_id = Convert.ToInt32(orderID);


                            string insertData = "INSERT INTO bookshop.cart(ProductID,OrderID)VALUES('" + product_id + "','" + order_id + "')";
                            MySqlCommand command = new MySqlCommand(insertData, con);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully Added Your Card", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Please Check Your Order !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    {

                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check Your Order !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
