using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Numbers
    {
        public double average(int[] numbers)
        {
            Number number = new Number();
            return number.divide(sum(numbers), numbers.Length);
        }

        public int sum(int[] numbers)
        {
            Number number = new Number();
            int total = 0;
            foreach (var num in numbers)
                total = number.sum(total, num);
            return total;
        }
    }
}
