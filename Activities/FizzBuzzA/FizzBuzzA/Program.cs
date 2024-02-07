using System;

namespace FizzBuzzA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number you would like to count to: ");
            int input = int.Parse(Console.ReadLine());
            var number = new FizzBuzz();
            number.FuzzBuzzM(input);
        }
    }
}
