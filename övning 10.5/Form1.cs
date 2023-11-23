using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_10._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            byt (ref tal1, ref tal2);

            textBox3.Text = tal1.ToString();
            textBox4.Text = tal2.ToString();
        }
        void byt (ref int a, ref int b)// om du tar bort feferenserna så har den ingen data att referera till så det kommer inte att bytas på din skärm


        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void textBox1_Textchagned(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void textBox2_Textchagned(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
