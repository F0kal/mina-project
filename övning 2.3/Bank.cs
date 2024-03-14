using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._3
{
    internal class Bank
    {
        private List<BankKonto> konton = new List <BankKonto> ();

        internal List<BankKonto> Konton { get => konton; set => konton = value; }
    }
}
