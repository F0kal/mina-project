using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._4
{
    internal class Triangel:Figur,IArea
    {
        public Triangel(double b, double h) :base (b, h)
        { 

        }


        public double BeräknaArea()
        {
            return  (bredd * höjd) / 2;
          
        }

        public override string ToString()
        {
            return "triangel " + bredd + " x " + höjd;
        }






    }
}
