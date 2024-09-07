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
    public partial class formLogin : Form
    {


        public formLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void formLogin_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(160, 0, 0, 0);


        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username='" + txtUsername.Text + "' and password='" + txtPass.Text + "'  ";
            cmd=new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();

           if (dr.Read()== true)
            {
                new dashboard().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password, please Try Again","login failed",MessageBoxButtons.OK,MessageBoxIcon.Error );
                txtUsername.Text = "";
                txtPass.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
             new formSignup().Show();
            this.Hide();
        }
    }
}
