using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            float tal = float.Parse (textBox1.Text) ;
            float tal2 = tal / 100f;                        // delar med 100 för att få ett decimaltal
            int svar = (int)tal2 * 100;                 // gör om till int för att få bort decimaltalen och tar gånger 100 för att få ut antalet 100lappar
            lblUttag.Text = "Uttag: " + svar + " kr.";


        }


    }
}
