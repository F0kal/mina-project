using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = int.Parse(tbxstart.Text);
            int slut = int.Parse(tbxslut.Text);
            int steg = int.Parse(tbxsteg.Text);
            do
            {
                tbxvisa.AppendText(start + " ");
                start = start + steg;
                

            }


            while (start <= slut);

            
        }
    }
}
