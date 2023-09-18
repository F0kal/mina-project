using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            if (tal > 0) { lblSvar.Text = " ditt tal är större än 0"; }
            else { lblSvar.Text = "ditt tal är mindre än 0"; }
           
        }
    }
}
