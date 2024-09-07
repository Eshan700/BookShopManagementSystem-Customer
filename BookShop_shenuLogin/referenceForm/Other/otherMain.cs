using BookShop_shenuLogin.referenceForm.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_shenuLogin.referenceForm.Other
{
    public partial class otherMain : Form
    {
        public static TextBox box;
        public otherMain()
        {
            InitializeComponent();
        }
     
        public otherMain(TextBox x)
        {
            InitializeComponent();
            box = x;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            bookSecondForms bsf = new bookSecondForms("Educational games", box);
            bsf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Fantasy", box);
            bsf.Show();
        }

        private void otherMain_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bookSecondForms bsf = new bookSecondForms("Educational games", box);
            bsf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Educational games", box);
            bsf.Show(); 
        }
    }
}
