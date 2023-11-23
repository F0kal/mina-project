using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char BestämTäcken (double tal)
        {
            char resultat = ' ';

            if (tal > 0)
            {
               resultat = '+';
            }

            else
            {
                resultat = '-';
            }

            return resultat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          char resultat = BestämTäcken(double.Parse(textBox1.Text));
            textBox2.Text = resultat.ToString();
        }
    }
}