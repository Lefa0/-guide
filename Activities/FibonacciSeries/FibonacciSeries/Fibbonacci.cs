using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public static class Fibonacci
    {
        public static int Fib(int termNumber)
        {
            if (termNumber == 0)
            {
                return 0;
            }
            else if (termNumber == 1)
             {
                 return 1;
             }
             else
             {
                 return Fib(termNumber - 1) + Fib(termNumber - 2);
             }
        }
    }
}
