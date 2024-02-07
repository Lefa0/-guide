using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> itemNumbs = new List<int>();

            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (listOfItems[i] is Int32)
                    itemNumbs.Add((int)listOfItems[i]);
            }
            return itemNumbs;
            //OR
            //return listOfItems.OfType<int>();

            //IEnumerable<int> ans =from item in listOfItems
            //where item is int
            // select (int)item;
            // return ans;

            //return listOfItems.Where(loi => loi is int).Select(i => (int)i);

            //       foreach (object x in listOfItems)
            //if (x is int) yield return (int)x;
        }
    }
}
