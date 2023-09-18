using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._2
{
    public partial class Form1 : Form
    {
        private string text;

        public Form1()
        {
            InitializeComponent();
        }

        private TextBox GetTbxTal2()
        {
            return tbxTal2;
        }

        private void btnKör_Click(object sender, EventArgs e )
        {
            int tal = int.Parse( tbxTal1.Text );        // definerar "tal" från textbox
            int tal2 = int.Parse( tbxTal2.Text );
            int summa = tal + tal2;                     // definerar "summa" med att det är tal + tal
            string text = summa.ToString();             // definerar "text" och säger att det är "summa" samt att den gör "summa" till en text
            lblSumma.Text = text;                       // säger att "text" ska visas i en vald label

        }
    }
}
