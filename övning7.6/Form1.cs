using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string namn = textBox1.Text;
            string namn2 = textBox2.Text;
            if (namn.CompareTo (namn2) >0)
                lblSvar.Text = namn2 + " " + namn;
            else lblSvar.Text = namn + " " + namn2;
        }
    }
}
