using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string orden = tbxEngelska.Text + " betyder " + tbxSvenska.Text + " på svenska";    // definerar variabeln "orden" och säger att det är det som står i textboxarna + lite vanlig text
            string text =orden.ToString();          // definerar variabeln "text" med att det ska vara det som är i variabeln "orden" och säger att den ska göra det till text
            lblSvar.Text = text;                // säger att variabeln "text" ska visas i en vald label

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
