﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //med denna metod så blir bakgruden röd
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e) // med denna metod blir bakgrunden blå
        {
            BackColor = Color.Blue;
        }
    }
}
