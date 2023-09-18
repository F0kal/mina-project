using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e) // här är metoden som används för att visa boxen och få medelandet
        {
            MessageBox.Show("är det kul att programera?", "medelande", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
