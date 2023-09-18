using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVänster_Click(object sender, EventArgs e)
        {
            lblflytta.Left = lblflytta.Left - 10;
        }

        private void btnHöger_Click(object sender, EventArgs e)
        {
            lblflytta.Left = lblflytta.Left + 10;
        }

        private void lblflytta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("du ska klicka på knappen förstår du??","medelande",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
