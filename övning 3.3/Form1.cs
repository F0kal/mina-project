using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_3._3
{
    public partial class lbl2 : Form
    {
        public lbl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);             // denfinerar variabeln "tal" och säger med hjälp av Parse att den ska göra om texten i textbox1 till kod
            int tal2 = int.Parse(textBox2.Text);            // denfinerar variabeln "tal2" och säger med hjälp av Parse att den ska göra om texten i textbox1 till kod
            int tal3 = int.Parse(textBox3.Text);            // denfinerar variabeln "tal3" och säger med hjälp av Parse att den ska göra om texten i textbox1 till kod
            int Summa = tal + tal2 + tal3;                  // definerar variabeln summa och säger att den ska vara tal1 + tal2 + tal3
            string text = Summa.ToString();                 // definerar variabeln "text" och säger att den ska vara variabeln "summa" fast i textform
            lblSumma.Text = text;                           // säger att texten ska visas i en vald label
            double medel;                                   // definerar variabeln medel
            medel = Summa/(double)3;                        // säger att medel är samma sak som summan / 3
            string text2 = medel.ToString();                // gör en text2 med inehållet från "medel" 
            lblMedel.Text = text2;                          // visar text2 i en vald label
        }
    }
}
