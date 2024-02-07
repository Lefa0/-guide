using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter the term number: ");
            int termNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i > termNumber; i++)
            {
                Console.WriteLine("{0}", Fib(i));
            }
            Console.ReadKey();
        }
        public static int Fib(int termNumber)
        {
            if (termNumber == 0)
            {
                return 0;
            }

            if (termNumber == 1)
            {
                return 1;
            }

            return Fib(termNumber - 1) + Fib(termNumber - 2);
        }
    }
}

