using System;

namespace FibonacciIterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber, numberOfElements;

            Console.WriteLine("Enter the number of elements: ");

            numberOfElements = Convert.ToInt32(Console.ReadLine());

            if(numberOfElements < 2)
            {
                Console.WriteLine("Please Enter a number greater than two");
            }
            else
            {
                Console.WriteLine(firstNumber + " " + secondNumber + " ");

                //loop starts from 2 because 0 and 1 are already printed

                for(int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;

                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            Console.ReadKey();
        }
    }
}
