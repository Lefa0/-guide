using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Linq
    {
        public static void NumFromRange(int numbers)
        {
            IEnumerable<int> numbersQuery = from number in numbers
                                            where number > 30 && number < 100
                                            select number;

            Console.WriteLine("List of numbers greater than 30 and less than 100 is: ");
            foreach (int number in numbersQuery)
            {
                Console.Write(number + " ");
            }
        }

        public static void SquareGreaterthan(int values)
        {
            var valuesQuery = from value in values
                              let squaredValue = value * value
                              where squaredValue > 20
                              select $"{value} - {squaredValue}";

            Console.WriteLine("\nSquare greater than 20: ");
            foreach (var value in valuesQuery)
            {
                Console.Write(value + " ");
            }
        }

        public static void ShuffleArray(int array)
        {
            IEnumerable<int> arrayAShuffled = arrayA.OrderBy(x => randomA.Next());

            Console.WriteLine("\nShuffle array 1:");
            foreach (var array1 in arrayAShuffled)
            {
                Console.Write(array1 + " ");
            }

            Console.WriteLine("\nShuffle array 2:");
            IEnumerable<int> arrayBShuffled = arrayB.OrderBy(x => randomB.Next());
            foreach (var array2 in arrayBShuffled)
            {
                Console.Write($"{array2}" + " ");
            }
        }
    }
}
