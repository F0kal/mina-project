using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            float tal = float.Parse(textBox1.Text);         // definerar "tal" och ger den värdet som står i textbox1
            float omvandling = (0.5f + tal);                // definerar "omvandling" och säger att det ska vara "tal" + 0,5
            int intValue = (int)omvandling;                 // definerar "intValue" och säger att den ska vara "omvandling" fast i kod format
            lblSvar.Text = intValue.ToString();             // säger att "intValue" ska visas som text i vald label





        }
    }
}
