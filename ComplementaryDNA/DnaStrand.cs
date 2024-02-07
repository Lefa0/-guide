using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplementaryDNA
{
    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            string output = string.Empty;

            foreach(char symbol in dna)
            {
                switch (symbol)
                {
                    case 'A': output += 'T';
                        break;
                    case 'T': output += 'A'; 
                        break;
                    case 'G': output += 'C'; 
                        break;
                    case 'C': output += 'G'; 
                        break;

                    default:
                        throw new ArgumentException("\"Parameter must be a valid chemical base ('T', 'A', 'G' or 'C').\", \"chemicalBase\"");
                }
            }

            return output;
            
        }
    }
}
