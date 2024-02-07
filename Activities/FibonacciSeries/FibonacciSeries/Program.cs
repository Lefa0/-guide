using System;

namespace FibonacciSeries
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the Fibonacci Series: ");

            int length = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Fibonacci.Fib(termNumber));

            for (int i = 0; i <= length; i++)
            {
                Console.Write(Fibonacci.Fib(i) + " ");
            }
        }
    }
}
