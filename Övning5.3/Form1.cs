using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double varanspris = double.Parse (textBox1.Text);
            double minapengar = double.Parse (textBox2.Text);
            bool kebab = varanspris >= (minapengar);
            lblSvar.Text = " Jag har råd: " + kebab.ToString();
        }
    }
}
