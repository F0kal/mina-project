using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnräkna_Click(object sender, EventArgs e)
        {
            string tabell = "";
            int nivå = int.Parse(textBox2.Text);
            int tabellvärde = 0;
            for (int i = 1; i <= nivå; i++)
            {


                for (int j = 1; j <= 10; j++)
                {
                    tabell = tabell + (i * j) + "\t";
                }
                tabell = tabell + "\r\n";
                
            }
            textBox1.Text = tabell;
        }
    }
}
