using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;                         // definerar "name" med att säga att den ska vara det som står i textbox1
            char Alpha = name[0];                               // definerar "Alpha" med att säga att det ska va första tecknet i "name"
            int kod = (int)Alpha;                              // definerar "kod" och säger att det ska vara "Alpha" fast i kod format
            string tecken =Alpha.ToString();                   // definerar "tecken" och säger att den ska vara kod fast i textform
            string unicode = kod.ToString();                   // definerar "unicode" samt säger att den ska vara "kod" fast i textformat
            label2.Text = tecken + " har koden " + unicode;     // säger att den ska visa "tecken" och lite text samt "unicode" i en vald label
        }
    }
}
