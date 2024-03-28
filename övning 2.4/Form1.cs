using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._4
{

    public partial class Form1 : Form
    {
        private List<Figur> figurer = new List<Figur>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Trangel_Click(object sender, EventArgs e)
        {
            Triangel t = new Triangel(double.Parse( tbx_bredd.Text ), double.Parse (tbx_höjd.Text));
            listBox1.Items.Add(t);
            figurer.Add(t);
        }

        private void btn_Cirkel_Click(object sender, EventArgs e)
        {
            cirkel c = new cirkel(double.Parse(tbx_bredd.Text), double.Parse(tbx_höjd.Text));
            listBox1.Items.Add(c);
            figurer.Add(c);
        }

        private void btn_Linje_Click(object sender, EventArgs e)
        {
            Linje l = new Linje(double.Parse(tbx_bredd.Text), int.Parse(tbx_höjd.Text));
            listBox1.Items.Add(l);
            figurer.Add(l);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach ( Figur figurer in figurer) 
            { 
                if (figurer is IArea)
                {
                  double area = ((IArea)figurer).BeräknaArea();
                  
                    tbx_area.Text = area + " cm2";
                }
            }
        }
    }
}
