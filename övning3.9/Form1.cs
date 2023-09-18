using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox1.Text);

            
            Point nyPosition = new Point(x, y);
            button1.Location = nyPosition;
        }
    }
}
