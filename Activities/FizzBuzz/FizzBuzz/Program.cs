using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number you would like to count to: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number for FIZZ: ");
            int inputFizz = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number for BUZZ: ");
            int inputBuzz = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {

                if (i % 5 == 0)
                {
                    Console.Write("FIZZ, ");
                }
                else if (i % 7 == 0) 
                {
                    Console.Write("BUZZ, ");
                }
                else 
                {
                    Console.Write($"{i}, ");
                }

            }

            Console.WriteLine();
        }
    }
}
