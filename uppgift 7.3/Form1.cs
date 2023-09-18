using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double längd = double.Parse (textBox1.Text);
            double vind = double.Parse (textBox2.Text);

            if ((längd > 7.92) && (vind < 2.0))
            {
                lblSvar.Text = "Grattis, nytt rekord";
            }

            else
            {
                lblSvar.Text = "Tyvärr, inget nytt rekord";
            }
                
            }
        }
    }
