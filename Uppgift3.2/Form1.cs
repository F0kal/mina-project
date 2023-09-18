using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);             // definerar "tal" och säger att texten från textbox1 ska sparas som kod
            char svar = (char)tal;                          // definerar "svar" och säger att den ska visa det tecken som är sparat i "tal"
            string klar = svar.ToString();                  // definerar "klar" och säger att den ska vara "svar" i textformat
            lblSvar.Text = klar;                            // säger att texten i "klar" ska visas i labeln

        }
    }
}
