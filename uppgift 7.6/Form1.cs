using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            char kön = char.Parse(textBox1.Text);
            if (kön == 'm')
            {
                textBox2.Text = "Du är en man";
            }
            
             else if  (kön== 'k')
             {
                textBox2.Text = "Du är en kvinna";
             }


            else
            {
                textBox2.Text = "fel inmatning";
            }
        }
    }
}
