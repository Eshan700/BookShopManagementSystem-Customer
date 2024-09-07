using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BookShop_shenuLogin
{
    public partial class formSignup : Form
    {
        public formSignup()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(160, 0, 0, 0);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
             if(txtUsername.Text=="" && txtPass.Text=="" && txtConpass.Text=="")
            {
                MessageBox.Show("Username and Password fields are empty", "Signup faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             else if (txtPass.Text==txtConpass.Text)
            {
                con.Open();
                string signup = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtPass.Text + "') ";
                cmd = new OleDbCommand(signup, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPass.Text = "";
                txtConpass.Text = "";

                MessageBox.Show("your account has been successfully created","Registration success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
             else
            {
                MessageBox.Show("Password does not match, please Re-enter","Registration Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPass.Text = "";
                txtConpass.Text = "";
                txtPass.Focus();
            }
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowpass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConpass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
                txtConpass.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtConpass.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }
    }
}
