using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double slag = double.Parse(textBox1.Text);
            if (slag > 190 || slag < 150)
            {
                label2.Text = " grattis du hamna inte i sjön";
            }
            else
            {
                label2.Text = "åh nej din boll hamna i sjön";
            }
            bool isEqual 
        }
    }
}
