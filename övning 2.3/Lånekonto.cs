using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._3
{
    internal class Lånekonto:BankKonto
    {

        private double kreditGräns;
        public Lånekonto(string personNummer, double behållning, double Räntesats, double kreditgräns) : base(personNummer, behållning, Räntesats) 
        { 
            this.kreditGräns = -kreditgräns;
        }

        public override bool Uttag(double belopp)
        {
            double kvarefteruttag = Behållning - belopp;
            if (kvarefteruttag >= kreditGräns)

            {
                Behållning = Behållning - belopp;

                return true;
            }
            else return false;
        }

        public override double BeräknaRänta()
        {

            return (Behållning * (ränteSats / 100));
        }

        public override string ToString()
        {
            return " Lånekonto " + personNummer + "  " + Behållning + " kr";
        }


    }
}
