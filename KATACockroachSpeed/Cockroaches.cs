using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATACockroachSpeed
{
    public class Cockroaches
    {
        public static int CockroachSpeed(double x)
        {
            const double constant = 27.77778;
            return (int) Math.Floor(x * constant);
        }
    }
}
