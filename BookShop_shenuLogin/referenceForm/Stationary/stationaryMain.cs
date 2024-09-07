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

namespace BookShop_shenuLogin.referenceForm.Stationary
{
    public partial class stationaryMain : Form
    {
        public static TextBox box;
        public stationaryMain()
        {
            InitializeComponent();

        }
        public stationaryMain(TextBox x)
        {
            InitializeComponent();
            box = x;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Pens", box);
            bsf.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Markers", box);
            bsf.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Paper", box);
            bsf.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Tape", box);
            bsf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bookSecondForms bsf = new bookSecondForms("Pencil", box);
            bsf.Show();
        }
    }
}
