using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_8._2
{
    public partial class Form1 : Form
    {
        private string figur = "rektangel";
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);
            if (figur.Equals("rektangel"))
            {
                g.FillRectangle(brush, 50, 50, 100, 80);
            }
            else if (figur.Equals("ellipse"))
                
            {
                brush.Color = Color.Blue;
                g.FillEllipse(brush, 50, 50, 100, 80);
            }

            Color color = Color.FromArgb(0, 0, 0);
            Pen pen = new Pen(color);
            g.DrawRectangle(pen, 50, 50, 100, 80);


        }

        private void btnRektangel_Click(object sender, EventArgs e)
        {
            figur = "rektangel";
            Invalidate();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            figur = "ellipse";
            Invalidate();
        }
    }
}
