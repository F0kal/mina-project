using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = 0;                            // ger en definition till "tal"
            try {                                   // försöker med alla beräkningar även om det inte skulle gå
            tal = int.Parse(tbxTal.Text);           // gör om texten i textboxen till siffror så man kan använda int
            }
            catch {                                 // fångar fel
                MessageBox.Show("För stort tal");   // gör en box som visar att det vart fel
            }

            int kvadrat = tal * tal;                // säger att kvadrat är lika med tal gånger tal
            string text = kvadrat.ToString();       // gör en text av variablen kvadrat
            tbxTal.Text = text;                     // skickar texten till textboxen
        }
    }
}
