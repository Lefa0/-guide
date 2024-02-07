using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATAPerfectSquare
{
    public class PerfectSquare
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;

            //OR return Math.Abs(Math.Sqrt(n) - (int)Math.Sqrt(n)) < double.Epsilon;

            //OR     int sqrt = (int) Math.Sqrt(n);
            //       return sqrt * sqrt == n;
        }
    }
}
