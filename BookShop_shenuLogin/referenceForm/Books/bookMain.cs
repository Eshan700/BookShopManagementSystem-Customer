using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_shenuLogin.referenceForm.Books
{
    public partial class bookMain : Form
    {
        public static TextBox box;
        public bookMain()
        {
            InitializeComponent();
        }
        public bookMain(TextBox x)
        {
            InitializeComponent();
            box = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Fantasy",box);
            bsf.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Horror", box);
            bsf.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Health", box);
            bsf.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Romance", box);
            bsf.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Novela", box);
            bsf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Adventure", box);
            bsf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            bookSecondForms bsf = new bookSecondForms("Romance", box);
            bsf.Show(); 
        }
    }
}
