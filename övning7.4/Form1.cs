using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int låtar = int.Parse(textBox1.Text);
            double pris = (double) låtar * 9.9;
            if (låtar > 10) 
            {
                pris = (pris / 100) * 90;
                lblSvar.Text = "priset är " + pris + "kr för" + låtar + " låtar";

            }
            else if  (låtar > 100) 
            {
                pris = (pris / 100) * 85;
                lblSvar.Text = "priset är " + pris + "kr för" + låtar + " låtar";

            }
            else lblSvar.Text = "kostnaden är" + pris + "kr för" + låtar + " låtar";
        }
    }
}
