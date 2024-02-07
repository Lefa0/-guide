using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumString
{
    public class Solution
    {
        public int solution(string S)
        {
            string[] numbers = S.Split(new[] { "+", "-" }, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            int sign = 1; // Initialize with positive sign


            foreach (string num in numbers)
            {
                if (num == "one")
                    result += 1 * sign;
                else if (num == "two")
                    result += 2 * sign;

                // Check the next character to determine the sign
                if (S[num.Length] == '-')
                    sign = -1;
                else if (S[num.Length] == '+')
                    sign = 1;
            }

            return result;
        }
    }
}
