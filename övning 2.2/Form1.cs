using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._2
{
    public partial class personalregister : Form
    {
        private List<Anställd> kyrkansFel = new List<Anställd>();
        public personalregister()
        {
            InitializeComponent();
        }

       

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Säljare_Click(object sender, EventArgs e)
        {
            Säljare säljare = new Säljare(tbx_Säljarenamn.Text,int.Parse (tbx_SäljareProvision.Text),int.Parse (tbx_SäljareFörsäljning.Text));
            listBox1.Items.Add(säljare);
            kyrkansFel.Add(säljare);
        }

        private void btn_Konsult_Click(object sender, EventArgs e)
        {
            Konsult konsult = new Konsult(tbx_KonsultNamn.Text, int.Parse (tbx_KonsultTimlön.Text), int.Parse(tbx_KonsultArbetadtid.Text));
            listBox1 .Items.Add(konsult);
            kyrkansFel .Add(konsult);
        }

        private void btn_Kontorist_Click(object sender, EventArgs e)
        {
            Kontorist kontorist = new Kontorist (tbx_KontoristNamn.Text, int.Parse(tbx_KontoristMånadslön.Text));
            listBox1.Items .Add(kontorist);
            kyrkansFel.Add (kontorist);
        }

        private void btnBeräknaLön_Click(object sender, EventArgs e)
        {
            double löner = 0;
           foreach(Anställd anst in kyrkansFel)
            {
                löner += anst.BeräknaLön();
                listBox2 .Items.Add(anst + " Lön: " + anst.BeräknaLön() + " kr" );
            }
            tbx_Totallön.Text = löner.ToString();
        }
    }
}
