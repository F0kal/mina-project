using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._3
{
    internal class SparKonto:BankKonto
    {

        public SparKonto(string personNummer, double behållning, double Räntesats) :base(personNummer, behållning, Räntesats) 
        {
            
        }
        public override bool Uttag (double belopp)
        {
            if (belopp<Behållning)
            {
                Behållning = Behållning - belopp;

                return true;
            }
            else return false;
        }

        public override double BeräknaRänta(double belopp)
        {
           
            return Behållning * (ränteSats /100);
        }



        public override string ToString()
        {
            return " Sparkonto " + personNummer + "  " + Behållning + " kr";
        }






    }
}
