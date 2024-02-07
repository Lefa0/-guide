using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATASumOfGoals
{
    public class KATAGoals
    {
        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
        {
            return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
        }

        // public static int GetGoals(params int[] objects) => objects.Sum();
    }
}
