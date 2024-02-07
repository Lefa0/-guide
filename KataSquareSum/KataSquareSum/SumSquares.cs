using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataSquareSum
{
    public class SumSquares
    {
        public static int SquareSum(int[] numbers)
        {
            return numbers.Sum(x => x * x);

            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    sum += number * number;
            //}
            //return sum;
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i] * numbers[i];
            //}
            //return sum;
        }
    }
}
