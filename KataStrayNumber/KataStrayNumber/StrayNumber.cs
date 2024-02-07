using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStrayNumber
{
    public class StrayNumber
    {
        public static int Stray(int[] numbers)
        {
           return numbers.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key).First();

            //OR     Array.Sort(numbers);
            //       return numbers[0] == numbers[1] ? numbers.Last() : numbers.First();

            //OR     return n.First(x => n.Count(i => i == x) == 1);
        }
    }
}
