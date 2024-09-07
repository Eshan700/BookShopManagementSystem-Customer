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

namespace BookShop_shenuLogin.referenceForm
{
    public partial class cart : Form
    {
        public static TextBox box;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
              
        //int orderID = Convert.ToInt32(mm.labOrderID.Text);
        public cart()
        {
            InitializeComponent();
        }
        public cart(TextBox x)
        {
            InitializeComponent();
            box = x;
            
        }

        //method
        public void Clear()
        {
            int number = Convert.ToInt32(box.Text)+1;
            dataGridView1.Rows.Clear();
            box.Text = number.ToString();
            

        }
        public void shoGrid()
        {
            try
            {
                dataGridView1.Rows.Clear();
                con.Open();
                cmd = new MySqlCommand("SELECT cart.ProductID,product.ProductName,product.Price,product.Image FROM bookshop.cart inner join product ON cart.ProductID = product.ProductID where cart.OrderID='" + Convert.ToInt32(box.Text) + "'", con);
                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        DataGridViewRow newRow = new DataGridViewRow();

                        newRow.CreateCells(dataGridView1);

                        newRow.Cells[0].Value = dr["ProductID"].ToString(); ;
                        newRow.Cells[1].Value = dr["ProductName"].ToString();
                        newRow.Cells[2].Value = dr["Price"].ToString();
                        newRow.Cells[3].Value = 1;

                        newRow.Cells[4].Value = dr["Image"];


                        dataGridView1.Rows.Add(newRow);
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }


                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Add Product", "Information !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void cart_Load(object sender, EventArgs e)
        {
            try
            {
                con = DBConection.ConnectDB();
                shoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {

                    dataGridView1.CurrentRow.Cells[3].Value = numericUpDown1.Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please Select FullRow In Display", "System Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double product_price = 0.00;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[5] as DataGridViewCheckBoxCell;
                    if (cell.Value != null)
                    {

                        if (cell.Value.Equals(true))
                        {
                            int qty = Convert.ToInt32(row.Cells[3].Value.ToString());
                            product_price = product_price + (Convert.ToDouble(row.Cells[2].Value.ToString()) * qty);
                        }
                    }
                }
                labTotPrice.Text = product_price.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Clear();
            MessageBox.Show("Successfully Cleared Your Card", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labTotPrice.Text != "")
                {
                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DataGridViewCheckBoxCell cell = row.Cells[5] as DataGridViewCheckBoxCell;
                        if (cell.Value != null)
                        {

                            if (cell.Value.Equals(true))
                            {
                                int product_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                                string Prodcuct_Name = row.Cells[1].Value.ToString();
                                int order_id = Convert.ToInt32(box.Text);
                                double price = Convert.ToDouble(row.Cells[2].Value.ToString());
                                int quantity = Convert.ToInt32(row.Cells[3].Value.ToString());

                                con.Open();
                                string insertData = "INSERT INTO bookshop.checkout(OrderID,ProductID,Quantity,Price,OrderMonth,pay)VALUES('" + order_id + "','" + product_id + "','" + quantity + "','" + (price * quantity) + "','" + month + "','Pending')";
                                MySqlCommand command = new MySqlCommand(insertData, con);
                                command.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }
                
                    con.Open();
                    string InsertOrder = "INSERT INTO bookshop.orders(OrdersID,TotalPrice,month,year)VALUES('" + Convert.ToInt32(box.Text) + "','" + Convert.ToDouble(labTotPrice.Text) + "','"+month+"','"+year.ToString()+"')";
                    MySqlCommand cmdOrder = new MySqlCommand(InsertOrder, con);
                    cmdOrder.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    labTotPrice.Text = "";
                    MessageBox.Show("Successfully Placed Your Order !!", "Information !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            else
            {
                MessageBox.Show("Please Calculate The Total Price", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have already placed your order please clear your card ", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
