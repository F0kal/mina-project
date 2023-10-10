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

namespace uppgift_7_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string svar1 = "kebab";
        string svar2 = "altt";
        string svar3 = "ouf";
        private void button1_Click(object sender, EventArgs e)
        {
            char fråga1 = char.Parse(textBox1.Text);
            char fråga2 = char.Parse(textBox2.Text);
            char fråga3 = char.Parse(textBox3.Text);
            if (fråga1 == '2')
            {
                 svar1 = "1. rätt";
            }


            else
            {
                 svar1 = "1. fel";
            }


            if (fråga2 == 'x')
            {
                 svar2 = "2. rätt";
                    
            }

            else
            {
                 svar2 = "2. fel";
            }

            if (fråga3 == '1')
            {
                 svar3 = "3. rätt";
            }

            else
            {
                 svar3 = "3. fel";
            }

            textBox4.Text = svar1 + svar2 + svar3;








        }
    }
}
