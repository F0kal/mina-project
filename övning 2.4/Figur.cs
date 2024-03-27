using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._4
{
    internal abstract class Figur
    {
       
        protected double bredd;
        protected double höjd;
      public   Figur(double b, double h)
        {
            bredd = b;
            höjd = h;
        }
        public abstract override string ToString();


    }
}
