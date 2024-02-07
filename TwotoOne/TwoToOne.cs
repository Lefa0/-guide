using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoToOneKata
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            var characters = string.Concat(s1,s2).Distinct().ToArray();

            Array.Sort(characters);

            return new string(characters);

        }
    }
}
