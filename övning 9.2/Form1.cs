using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int räknare = 1;
            double korn = 1;
            do
            {
                räknare++;
                korn = korn * 2;
                textBox1.AppendText( "ruta " +räknare + ": " + korn + "\r\n");
            } while (räknare < 64);
        }
    }
}
