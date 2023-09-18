using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int ålder = int.Parse(textBox1.Text);

            if (ålder < 15 || ålder > 65) 
            {
                lblSvar.Text = "resan kostar 20 kr";
            }
            else
            {
               lblSvar.Text = "resan kostar 30kr";
            }
            


           // if (ålder < 65 && ålder > 15) { lblSvar.Text = "Resan kostar 30 kr"; }
           // else lblSvar.Text = "resan kostar 20 kr";


            
        }
    }
}
