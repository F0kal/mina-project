using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tid = int.Parse (textBox1.Text);
            int år = tid / 12;
            int månader = tid % 12;
            lblSvar.Text = år + " år och " + månader + " månader";
        }
    }
}
