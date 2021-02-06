using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public sealed class Atidan
    {
        public static void findDuplicate()
        {
            string[] findDuplicate = { "atidan", "programming" }; //a r

            var dict = new Dictionary<Char, int>();
            foreach (string str in findDuplicate)
            {
                var it = str.GroupBy(c => c).Where(c => c.Count() > 1).Select(c => new { charName = c.Key, charCount = c.Count() });
                foreach (var item in it)
                {
                    dict[item.charName] = item.charCount;
                }
            }
            foreach (var itemRepeat in dict)
            {
                if(itemRepeat.Key == 'a' || itemRepeat.Key=='r')
                Console.WriteLine(itemRepeat.Key + " repeated "+itemRepeat.Value+" times");
            }

            //Logic: To find the duplicate records in the string array
            var duplicateChar = findDuplicate.GroupBy(g => g).Where(y => y.Count() > 1).Select(x=> x.Key);
            foreach (var item in duplicateChar)
            {
                // Console.WriteLine(item.charkey+" repeated "+item.charval+" times.");
            }

            //Logic: To find the repeated char in the string using Linq
            string name = "Duetsche";
            var repeatedName = name.GroupBy(g => g).Where(x => x.Count() > 1).Select(y => new { charName = y.Key, charCounter = y.Count() });
            foreach (var charItem in repeatedName)
            {
                Console.WriteLine("================================================");
                Console.WriteLine(charItem.charName+" Repeated "+charItem.charCounter+" times");
            }

            //Logic: To find out the duplicates in list of array
            List<int> i = new List<int> { 1, 1, 2, 3, 3, 4 };
            i.ToLookup(g => g).Where(y => y.Count() > 1).ToList().ForEach(x=> Console.WriteLine("number {0} repleated {1} times", x.Key, x.Count()));
            //Console.Readline();();
        }

    }
}
