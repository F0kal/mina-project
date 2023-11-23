using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Ärensiffra (char tecken)
        {
            bool Ärensiffra;
            int undre = 48;
            int övre = 57;
            int kod = tecken;
            if (kod >undre && kod <övre)
            {
                Ärensiffra = true;
            }
            else
            {
                Ärensiffra = false;
            }
            
             


            return Ärensiffra;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            char tecken = textBox1.Text[0];
            bool ärensiffra = Ärensiffra(tecken);

            if (ärensiffra )
            {
                textBox2.Text = " ditt tecken är en siffra";
            }
            else 
            {
                textBox2.Text = "ditt tecken är inte en siffra";
            }
        }
    }
}
