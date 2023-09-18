using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t1 = double.Parse(textBox1.Text);
            if (t1 > 0)
            {
                label2.Text = "talet är positivt";
            }

            else
            {
                label2.Text = "talet är negativt";
            }
        }
    }
}
