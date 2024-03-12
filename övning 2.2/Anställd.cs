using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    internal class Anställd
    {
        private string namn = "";

        public Anställd(string n) 
        {
            Namn = n;
        }

        public string Namn { get => namn; set => namn = value; }
        public virtual double BeräknaLön()
        {
            return 0;
        }

        public override string ToString()
        {
            return namn;
        }
    }
}
