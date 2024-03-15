using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._3
{
    internal class Lånekonto:BankKonto
    {

        private double kreditGräns = -1000;
        public Lånekonto(string personNummer, double behållning, double Räntesats) : base(personNummer, behållning, Räntesats) 
        { 

        }

        public override bool Uttag(double belopp)
        {
            if (belopp > Behållning && belopp <kreditGräns)

            {
                Behållning = Behållning - belopp;

                return true;
            }
            else return false;
        }

        public override double BeräknaRänta(double belopp)
        {

            return Behållning
                
                
                * (ränteSats / 100);
        }

        public override string ToString()
        {
            return personNummer;
        }


    }
}
