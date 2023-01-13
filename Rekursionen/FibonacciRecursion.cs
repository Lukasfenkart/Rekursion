using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursionen
{
    public class FibonacciRecursion
    {
        public int Fibonacci_Recursive(int number)
        {
            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return Fibonacci_Recursive(number - 2) + Fibonacci_Recursive(number - 1);
            }
        }
    }
}
