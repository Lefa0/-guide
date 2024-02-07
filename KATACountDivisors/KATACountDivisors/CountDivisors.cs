using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATACountDivisors
{
    public class CountDivisors
    {
        public static int Divisors(int n)
        {
            int counter = 0;

            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    counter++;
            }
            return counter;
        }
    }
}
