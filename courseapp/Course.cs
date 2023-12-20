using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseapp
{
    internal class Course
    {
        public string name;
        public string code;
        public int points;
        public DateTime Start;
        public DateTime End;

        public bool IsActive(DateTime inDate)
        {
            if (inDate > Start && inDate < End)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
