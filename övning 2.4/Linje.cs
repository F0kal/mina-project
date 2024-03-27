using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._4
{
    internal class Linje:Figur
    {
        public Linje(double b, double h) : base(b, h)
        {

        }


        public override string ToString()
        {
            return "Linje " + bredd + " x " + höjd;
        }

    }
}
