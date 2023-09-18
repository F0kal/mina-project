using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bokstav = textBox1.Text;         // definerar "bokstav" och säger att den ska vara det som står i textbox1
            char stor = bokstav[0];                 // derfinerar "stor" och säger att det ska vara den första bokstaven i variabeln "bokstav"
            int lösning = (int)stor;                // derinerar "lösning" och säger att den är "stor" fast i kod form
            int svar = stor + 32;                   // definerar "svar" med att säga att det är "stor" + 32
            char kebab = (char)svar;                // definerar "kebab" med att göra om ´koden från svar till ett tecken
            kebab.ToString();                       // gör om "kebab" till text 
            label2.Text = kebab.ToString();         // säger att texten "kebab" ska visas i en vald label

        }
    }
}
