using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    internal class Konsult:Anställd
    {
        private double arbetadeTimmar;
        private double timLön;



        public Konsult(string n, double a, double t) :base(n)
        {
            arbetadeTimmar = a;
            timLön = t;
        }


        public override double BeräknaLön() 
        {

            return arbetadeTimmar * timLön;
        }

        public override string ToString()
        {
            return Namn + " (Konsult)";
        }

    }
}
