using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursionen
{
    public class FibonacciRecursion
    {
        public int Fibonacci_Recursiv(int number)
        {
            if (number == 1)
            {
                return number;
            }
            int eins = 1;
            int zwei = eins; //1
            int drei = zwei + eins; //2
            int vier = drei + zwei; //3
            return vier;
        }
    }
}
