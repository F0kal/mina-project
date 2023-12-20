using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        bool Visatal (int tal)
        {
            
            bool primtal = true;

            for (
                int i = 2; i < tal; i++)
            {
                double kvot = tal/ i;
                double kvot2 = tal/(double) i;
                if (kvot == kvot2)
                 
                 primtal = false;
            }

            
            
           


            return primtal;
        
        }





        private void button1_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            bool primtal = true;
            primtal = Visatal(tal);


            label2.Text = primtal.ToString();
        }
    }
}
