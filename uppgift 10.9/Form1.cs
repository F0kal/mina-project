using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._9
{
    public partial class Form1 : Form
    {
        Random Slump = new Random();
        int[] tärningar = new int[5];    // flyttade definitionen av antal och tärningar hit för att slippa skriva om antal och tärningar för ligger dem här så kan resten av ditt program hämta dem här ifrån.
        int antal = 5;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            KastaTärningar();
            VisaTärningar();

        }

        void KastaTärningar()
        {
            for (int i = 0; i < antal; i++)
            {
                int antalprickar = Slump.Next(1, 7);
                tärningar[i] = antalprickar;
            }
        }

        void VisaTärningar()
        {
            textBox1.Text = "";

            int summa = Räknatärningar();
            for (int i = 0; i < antal; i++)
            {
                textBox1.AppendText("Tärning " + (i + 1) + ":     " +
                                            tärningar[i] + "\r\n");
             
               
            }
            textBox1.AppendText (" antal prickar     " + summa + "\r\n");
        }
        int  Räknatärningar()
            {
             int summa = 0;

            foreach(int slag in tärningar)
            {
                summa += slag;
            }
            return summa;
            }
        

    }
}                                                    