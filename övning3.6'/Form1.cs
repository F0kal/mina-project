using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            char tecken;                        // definerar variabeln "tecken" och säger att det ska va ett tecken
            string name = textBox1.Text;        // definerar variabeln "name" och säger att den ska vara det som står i textbox1
            string lastname = textBox2.Text;    // definerar variabeln "lastname" och säger att den ska vara det som står i textbox2
            char initial = name[0];             // definerar variabeln "initial" och säger att den ska vara första teckenet i variabeln "name"
            char initiallast = lastname[0];     // definerar variabeln "initiallast" och säger att den ska vara första teckenet i variabeln "lastname"
            string svar = name + lastname + " har initialerna " + initial + "." + initiallast; // definerar variabeln "svar" och säger att den ska vara "name + lastname + lite text + initial + lastinitial
            lblSvar.Text = svar;                // säger att variabeln "svar" ska visas i en vald label

        }
    }
}
