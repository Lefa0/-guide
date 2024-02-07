using System;

namespace FibonacciDemo
{
    internal class Program
    {
        static int Fib(int termnumber)
        {
            
            if (termnumber == 0) return 0;
            if (termnumber == 1) return 1;
            return Fib(termnumber - 1) + Fib(termnumber - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("length of series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(Fib(i));
            }
        }
    }
}
