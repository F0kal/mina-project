using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            Random tärning = new Random();
            int resultat = tärning.Next(1,7);
            textBox1.Text = resultat.ToString();
            bool wow = resultat == 6;
            if (wow == true)
    
            {
                MessageBox.Show (" grattis", "medelande");
            }
        }
    }
}
