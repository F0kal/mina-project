using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;                // definerar variabeln "name" och säger att den ska vara det som står i textboxen
            int Ålder = int.Parse(tbxfödelse.Text);     // definerar variabeln "ålder" och säger att den ska ta det som står i en textbox och göra det till kod
            int svar = Ålder + 50;                      // definerar variabeln "svar" och säger att den ska vara datan från "ålder" och plussa på 50
            string text = svar.ToString();              // definerar variabeln "text" och säger att den ska ta koden från variabeln "svar" och göra om den till text
            lblSvar.Text = text + " fyller" + " " + name +" " + "50 år";   // säger att i vald label så ska variabeln "text" stå + lite annan text som är oberoende
        }
    }
}
