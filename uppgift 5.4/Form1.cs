using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tid = int.Parse(textBox1.Text);
            int timmar = tid / 3600;
            int minuter = (tid / 60) - timmar * 60;
            int sekunder = tid % 60;
            lblSvar.Text = "Det är " + timmar.ToString() + " timmar och " + minuter.ToString() + " minuter och " + sekunder.ToString() + " sekunder";
        }
    }
}
