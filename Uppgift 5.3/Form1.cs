using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int täljare = int.Parse(textBox1.Text);
            int nämnare = int.Parse(textBox2.Text);
            int heltal = täljare / nämnare;
            int resten = täljare % nämnare;
            lblSvar.Text = täljare.ToString() + "/" + nämnare.ToString() + " blir: " + heltal.ToString() +" " + resten.ToString() + "/" + nämnare + " i blandad form";
        }
    }
}
