using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 67, 92, 153,15 };
            int[] values = new int[] { 7, 2, 30 };
            int[] arrayA = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            int[] arrayB = new int[] { 38, 24, 8, 0, -1, -17, -33, -100 };
            var randomA = new Random();
            var randomB = new Random();

            //Number from range
            IEnumerable<int> numbersQuery = from number in numbers
                                            where number > 30 && number < 100
                                            select number;

            Console.WriteLine("List of numbers greater than 30 and less than 100 is: ");
            foreach(int number in numbersQuery)
            {
                Console.Write(number + " ");
            }

            //Sqaure greater than 20
            var valuesQuery = from value in values
                                           let squaredValue  = value * value
                                           where squaredValue > 20
                                           select $"{value} - {squaredValue}";

            Console.WriteLine("\nSquare greater than 20: ");
            foreach (var value in valuesQuery)
            {
                Console.Write(value + " ");
            }

            //Shuffle an array
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
