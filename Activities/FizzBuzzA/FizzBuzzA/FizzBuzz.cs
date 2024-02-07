using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzA
{
    public class FizzBuzz
    {
        public void FuzzBuzzM(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                switch (i)
                {
                    case var Fizz when i % 5 == 0:
                        Console.Write("Fizz, ");
                        break;
                    case var Buzz when i % 7 == 0:
                        Console.Write("Buzz, ");
                        break;
                    default:
                        Console.Write($"{i}, ");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
