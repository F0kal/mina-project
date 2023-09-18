using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double bensin = double.Parse(textBox1.Text);
            double b = 50 - bensin;
            double pris = (b * 14.5);
            if (bensin < 10) lblSvar.Text = "Tanka " + b + "Liter. Det kostar " + pris + "kr";
            else lblSvar.Text = "Kör vidare";
            
        }
    }
}
