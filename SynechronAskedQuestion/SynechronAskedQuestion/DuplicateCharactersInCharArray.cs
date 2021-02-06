using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class DuplicateCharactersInCharArray
    {
        /// <summary>
        /// how to check the duplicate records in character array
        /// </summary>
        /// <param name="arrayToCheck"></param>
        /// <returns></returns>
        public static void DuplicateChar()
        {
            // find duplicate characters in string name
            Console.WriteLine("===========find duplicate characters in string name===============");
            string stringValues = "Nitin Peep Amir";
            char[] charT = stringValues.ToCharArray();
            var countDuplicate = charT.GroupBy(x => x).Where(a => a.Count() >1).Select(t => new { key = t.Key, value = t.Count() });
            foreach (var item in countDuplicate)
            {
                Console.WriteLine(item.key+" | "+item.value);
            }
            Console.WriteLine("============Duplicate=============");
            var amir = "amirsuhelamir";
            var duplicateB = amir.GroupBy(x => x).Where(g => g.Count() > 1).Select(t=>new { key=t.Key, value=t.Count()});
            foreach (var item in duplicateB)
            {
                Console.WriteLine(item.key+"  |  "+item.value);
            }
            Console.WriteLine("============ENDDuplicate=============");
            DuplicateCharactersInCharArray.characterContainsDuplicates(charT);
        }
        public static void characterContainsDuplicates(char[] arrayToCheck)
        {
            var dict = new Dictionary<char, char>();
            foreach (var value in arrayToCheck)
            {
                if (!string.IsNullOrWhiteSpace(value.ToString()))
                {
                    if (dict.ContainsKey(value))
                    {
                        dict[value]++;
                    }
                    else
                    {
                        dict[value] = '1';
                    }
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} occurse {1} times", pair.Key, pair.Value);
            }
        }
    }
}
