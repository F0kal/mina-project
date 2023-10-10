using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Area(double radie)
        {

            double area = Math.PI * radie * radie;
            


            return area;
        }

        

        private void btnräkna_Click(object sender, EventArgs e)
        {
            double A = Area( double.Parse(textBox1.Text));
            tbxradie.Text = A.ToString();

        }
    }
}
