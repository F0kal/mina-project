using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._3
{
    internal abstract class BankKonto
    {
        protected string personNummer;
        private double behållning;
        protected double ränteSats;

        public double Behållning { get => behållning; set => behållning = value; }


        public BankKonto( string p,double b, double r)
        {
            personNummer = p;
            behållning = b;
            ränteSats = r;
        }

        public void Insättning(double belopp)
        {
            behållning += belopp;
        }

        public abstract bool Uttag(double belopp);


        public abstract double BeräknaRänta();


        public abstract override string ToString();

    }
}
