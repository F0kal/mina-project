using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._4
{
    internal class cirkel : Figur, IArea
    {
        public cirkel(double b, double h) : base(b, h)
        { 

        }
        public double BeräknaArea()
        {
            return (bredd /2) * (bredd / 2) * Math.PI;

        }
        public override string ToString()
        {
            return "cirkel " + bredd + " x " + höjd;
        }
    }
}
