using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int talA = int.Parse(textBox1.Text);
            int talB = int.Parse(textBox2.Text);
            int talC = int.Parse(textBox3.Text);

            int talA2 = talA * 2;
            int talB2 = talB * 3;
            int talC2 = talC * 4;
            int svar = talA2 + talB2 + talC2;
            lblSvar.Text = svar.ToString();
        }
    }
}
