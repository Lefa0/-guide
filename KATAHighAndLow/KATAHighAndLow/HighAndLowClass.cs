using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATAHighAndLow
{
    public class HighAndLowClass
    {
        public static String HighAndLow(string numbers)
        {
            var values = numbers.Split(' ').Select(Int32.Parse);
            return $"{values.Max()} {values.Min()}";

            //public static string HighAndLow(string rawNumbers)
            //{
            //    string[] numbers = rawNumbers.Split(' ');
            //    int min = numbers.Min(int.Parse);
            //    int max = numbers.Max(int.Parse);
            //    return $"{max} {min}";
            //}
        }
    }
}
