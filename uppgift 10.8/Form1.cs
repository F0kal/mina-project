using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       void  Tiden (int tid, out int timmar, out int minuter, out int sekunder)
        {
           

            timmar = tid / 3600;
            minuter = (tid % 3600) / 60;
            sekunder = tid - timmar * 3600 - minuter * 60;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tid = int.Parse (textBox1.Text);
            int timmar;
            int minuter;
            int sekunder;
             Tiden(tid,out timmar, out minuter,out sekunder);
            label2.Text = timmar + "h " + minuter + "m " + sekunder + "s ";


        }
    }
}
