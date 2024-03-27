using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._3
{
    public partial class Form1 : Form
    {
        Bank bank = new Bank();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_registrera_Click(object sender, EventArgs e)
        {
            if (tbx_Kredit.Text == string.Empty )
            {
                SparKonto s = new SparKonto(tbx_PersonNr.Text, 0 ,double.Parse (tbx_Ränta.Text));
                listBox1.Items.Add(s);
                bank.Konton.Add(s);
            }
            else
            {
                Lånekonto l = new Lånekonto(tbx_PersonNr.Text, 0, double.Parse(tbx_Ränta.Text), double.Parse (tbx_Kredit.Text));
                listBox1.Items.Add(l);
                bank.Konton.Add(l);
            }
        }

        private void btn_Insättning_Click(object sender, EventArgs e)
        {
           bank.Konton [listBox1.SelectedIndex].Insättning (double.Parse(tbx_belopp.Text)); 
            listBox1.Items.Clear();
            foreach (BankKonto konto in bank.Konton) 
            {
                listBox1.Items.Add(konto);
            }

        }

        private void btn_Uttag_Click(object sender, EventArgs e)
        {
            
            bool okej = bank.Konton[listBox1.SelectedIndex].Uttag(double.Parse(tbx_belopp.Text));

            if (okej == true)
            {
                MessageBox.Show(" uttag godkänt");
            }
            else
            {
                MessageBox.Show("uttag ej godkännt kolla att du inte uppnått kreditgräns");
                return;
            }

            listBox1.Items.Clear();
            foreach (BankKonto konto in bank.Konton)
            { 
                listBox1.Items.Add(konto);
            }
        }

        private void btn_Uppdatera_Click(object sender, EventArgs e)
        {
            foreach ( BankKonto konto in bank.Konton)
            {
              konto.Behållning +=  konto.BeräknaRänta() ;
            }
            listBox1.Items.Clear();
            foreach (BankKonto konto in bank.Konton)
            {
                listBox1.Items.Add(konto);
            }
        }

    }
}
