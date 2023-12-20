using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int Potens (int bas, int exponent)
        {
            
            int kvot;
            kvot = (int)Math.Pow( (double)bas, (double)exponent);
            return kvot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas = int.Parse(textBox1.Text);
            int exponent = int.Parse(textBox2.Text);
            int kvot;
            kvot = Potens (bas, exponent);
            label3.Text = kvot.ToString();
        }
    }
}
