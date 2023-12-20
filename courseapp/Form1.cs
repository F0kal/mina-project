using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;

namespace courseapp
{
    public partial class Form1 : Form
    {
        Course MyCourse = new Course();
        public Form1()
        {
            InitializeComponent();
            LoadData();
            ShowData();

        }
        void LoadData()
        {
            MyCourse.name = "Kemi 1";
            MyCourse.code = "KemKem01";
            MyCourse.points = 100;
            MyCourse.Start = DateTime.Parse("2021-08-16");
            MyCourse.End = DateTime.Parse("2025-06-13");
        }


        void ShowData()
        {
            Debug.Print("Data in instance");
            Debug.Print("Name: " +  MyCourse.name);
            Debug.Print("Code: " + MyCourse.code);
            Debug.Print("Points: " + MyCourse.Start.ToShortDateString());
            Debug.Print("Name: " + MyCourse.End.ToShortDateString());
        }

    }
}
