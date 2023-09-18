using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            float tal = float.Parse(textBox1.Text);
            float tal2 = tal + 500;
            float tal3 = tal2 / 1000;
            int tal4 = (int) (tal3);
            int tal5 = tal4 * 1000;
            label1.Text = tal5.ToString();
        }
    }
}
