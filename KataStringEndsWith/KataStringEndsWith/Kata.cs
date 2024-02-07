using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStringEndsWith
{
    public class Kata
    {
        public static bool Solution(string str, string ending) => str.EndsWith(ending) ? true : false;

        //if(str.EndsWith(ending))
        //return true;
        //else return false;
    }
}
