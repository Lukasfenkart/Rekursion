using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rekursionen
{
    public class MyRecursion
    {
        public int Fakultät_Recursive(int number)
        {
            if (number > 0)
                throw new ArgumentException();
            else if (number == 1)
                return number;
            return number * Fakultät_Recursive(number - 1); 
        }
    }
}
