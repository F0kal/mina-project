using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_8._1
{
    public partial class Form1 : Form
    {

        int datornstal;
        int antalgissningar;
        public Form1()
        {
            InitializeComponent();
            lbxstörstatalet.Items.Add(10);
            lbxstörstatalet.Items.Add(20);
            lbxstörstatalet.Items.Add(50);
            lbxstörstatalet.SelectedItem = lbxstörstatalet.Items[0];

            

        }

        private void btnstartaspelet_Click(object sender, EventArgs e)
        {
            string störstatal = lbxstörstatalet.SelectedItem.ToString();
            int störst = int.Parse(störstatal);
            Random slump = new Random();
            datornstal = slump.Next(1, störst);


            btnstartaspelet.Enabled = false;
            gbxspeldata.Enabled = false;
            gbxspelet.Enabled = true;

            lbldatornstal.Text = "??";
            antalgissningar = 0;
        }

        private void btngissa_Click(object sender, EventArgs e)
        {
            antalgissningar++;
            string gissa = tbxgissa.Text;
            int gisstal = int.Parse(gissa);

            if (gisstal == datornstal)
            {
                lblresultat.Text = "korrekt efter " + antalgissningar + " försök. ";
                gbxspelet.Enabled = false;
                btnspelaigen.Enabled = true;

                lbldatornstal.Text = datornstal.ToString();
                tbxminaresultat.AppendText(antalgissningar + " försök\r\n");
            }
            else if (gisstal < datornstal)
            {
                lblresultat.Text = "för lågt. gissa igen.";
            }
            else
            {
                lblresultat.Text = "för högt. gissa igen.";
            }
        }

        private void btnspelaigen_Click(object sender, EventArgs e)
        {
            gbxspelet.Enabled = true;
            btnspelaigen.Enabled = false;
            string störstatalet = lbxstörstatalet.SelectedItem.ToString();
            int störst = int.Parse(störstatalet);
            Random slump = new Random();
            datornstal = slump.Next(1, störst + 1);
            tbxgissa.Text = " ";
            lblresultat.Text = " ";
            lbldatornstal.Text = "??";
            antalgissningar = 0;
        }
    }
}
