using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tecken = new string[3]; // skapar lagringsplatts åt dina strings
            tecken[0] = (textBox1.Text); 
            tecken[1] = (textBox2.Text);   // säger att det som står i textboxen ska tll din lagring
            tecken[2] = (textBox3.Text);

            textBox1.Text = "" + tecken[2];
            textBox2.Text = "" + tecken[0];    // byter ut ordningen som texten ska komma ut
            textBox3.Text = "" + tecken[1];
        }
    }
}
