using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursive
{
    public class Fibonacci
    {
        /*private int _firstNumber;
        private int _secondNumber;
        public int _counter;
        private int _number;

        public Fibonacci(int firstNumber, int secondNumber, int counter, int number)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
            _counter = counter;
            _number = number;
        }*/   

        public static void Fib(int firstNumber, int secondNumber, int counter, int number)
        {
            Console.WriteLine(firstNumber + " ");

            if(counter < number)
            {
                Fib(secondNumber, firstNumber + secondNumber, counter + 1, number);
            }

        }
        
    }
}
