using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int höjd = int.Parse(textBox1.Text);    // definerar "höjd" med att den ska ta texten från textbox1 och göra om den till kod
            int bas = int.Parse(textBox2.Text);    // definerar "bas" med att den ska ta texten från textbox1 och göra om den till kod
            int svar = höjd * bas;                  // definerar "svar" med att det ska vara höjd gånger bas     
            string text = svar.ToString();          // definerar "text" med att göra "svar" till en text
            label3.Text = "Arean är " + text;       // säger att en label ska ha texten och variabeln text
        }
    }
}
