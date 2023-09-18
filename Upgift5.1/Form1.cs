using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upgift5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse (textBox1.Text);
            int tal2 = tal + 1;
            int tal3 = tal2 * 2;
            int tal4 = tal3 - 6;
            int tal5 = tal4 / 2;
            int tal6 = tal5 + 3;
            int tal7 = tal6 - tal;
            lblSvar.Text = tal7.ToString();
        }
    }
}
