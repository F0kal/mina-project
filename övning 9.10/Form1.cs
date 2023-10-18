using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_9._10
{
    public partial class Rollspel : Form
    {
        Random generator = new Random();
        int[] tal;
        public Rollspel()
        {
            InitializeComponent();
            lbxmeny.SelectedIndex = 0;
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            int antaltal = 6;
            tal = new int[antaltal];
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = generator.Next(1, 21);
                textBox1.AppendText(tal[i] + "\r\n");

            }
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = generator.Next(1, 21);
                textBox2.AppendText(tal[i] + "\r\n");
            }
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = generator.Next(1, 21);
                textBox3.AppendText(tal[i] + "\r\n");
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           // if (lbxmeny.SelectedIndex == 0) tbxval = "" + textBox1.Text;
        }
    }
}
