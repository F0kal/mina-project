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
        public bool Uttag(double belopp)
        {
            return true || false;
        }

        public double BeräknaRänta()
        {
            return 0;
        }










    }
}
