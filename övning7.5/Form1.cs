using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            int v = int.Parse(t);
            switch (v)
            {
                case 1:
                    tbxSvar.Text = "Måndag"; break;

                case 2:
                    tbxSvar.Text = "Tisdag"; break;

                case 3:
                    tbxSvar.Text = "Onsdag"; break;

                case 4:
                    tbxSvar.Text = "Torsdag"; break;

                case 5:
                    tbxSvar.Text = "Fredag"; break;

                case 6:
                    tbxSvar.Text = "Lördag"; break;

                case 7:
                    tbxSvar.Text = "Söndag"; break;
            }
            }
        }
    }
