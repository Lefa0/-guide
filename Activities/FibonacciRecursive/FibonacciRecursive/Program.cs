using System;

namespace FibonacciRecursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the Fibonacci Series: ");

            int number = Convert.ToInt32(Console.ReadLine());

            Fibonacci.Fib(0, 1, 1, number);
        }
    }
}
