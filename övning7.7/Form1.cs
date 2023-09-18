using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning7._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double t1 = double.Parse (textBox1.Text);
            double t2 = double.Parse (textBox2.Text);
            if (t1 > t2)
            {
                lblSvar.Text = "det mista talet är: " + t2;
            }
            else
            {
                lblSvar.Text = "det minsta talet är: " + t1;
            }
        }
    }
}
