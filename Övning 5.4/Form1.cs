using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._4
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

            bool svar = (talC == talB + 1 && talB == talA + 1) || (talC == talB - 1 && talB == talA - 1); // den jämnför talen för att se om dem ligger i ordning

            if (svar) { lblSvar.Text = " talen är i ordningsföljd"; } 

            else { lblSvar.Text = " talen är inte i ordningsföljd"; }
           



        }

    }

        }
