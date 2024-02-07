using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataReversedStrings
{
    public class ReversedStrings
    {
        public static string Reverse(string str)
        {
            return new string (str.Reverse().ToArray());

            //string.Join("",str.Reverse())
            //OR
            //string.Concat(str.Reverse())
            //OR
            //  //char[] newstr = str.ToCharArray();
            //Array.Reverse(newstr);
            //return new String(newstr);
            //OR
            //string seged = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    seged += str[i];
            //}
           // return seged;
        }
    }
}
