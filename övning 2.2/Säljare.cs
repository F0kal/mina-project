using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    internal class Säljare:Anställd
    {
        private double provision;
        private double försäljning; 


        public Säljare(string n, double p, double f ) :base (n)
        {
            provision = p;
            försäljning = f;

        }
        

        public virtual double Beräknalön(double p, double f)
        {

            return försäljning * (provision / 100);

        }

        public override string ToString()
        {
            return Namn + " (säljare)";
        }


    }
}
