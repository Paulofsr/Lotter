using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Number
    {
        public int sum(int numberA, int numberB)
        {
            return numberA + numberB;
        }

        public double divide(int numberA, int numberB)
        {
            if (numberB == 0) throw new ArgumentException("Invalid number.");
            return numberA / (double)numberB;
        }
    }
}
