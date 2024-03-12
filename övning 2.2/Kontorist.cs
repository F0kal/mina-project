using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    internal class Kontorist:Anställd
    {
        private double månadslön;
        public Kontorist(string n, double m) :base(n)
        {
            månadslön = m;
        }

        public virtual double BeräknaLön(double m)
        {
            return m;
        }
        public override string ToString()
        {
            return Namn + " (Kontorist)";
           
        }
    }
}
