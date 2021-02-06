using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class FindDuplicateInArrayCollection
    {
        /// <summary>
        /// How to check the duplicate records count into an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static void FindDuplicateInArrayCollections()
        {
            int[] arrayExpression = { 1, 1, 2, 2, 3, 90, 90 };
            //Find duplicate records in array
            IEnumerable<KeyValuePair<int, int>> collectionArray = findDuplicateInArrayCollection(arrayExpression).Where(x => x.Value>1).OrderBy(o => o.Key);
            Console.WriteLine("==Find duplicate in an array using IEnumerable<KeyValuePair<int, int>>==");
            foreach (var pair in collectionArray)
            {
                Console.WriteLine("value {0} occures {1} times", pair.Key, pair.Value);
            }
        }
        public static IEnumerable<KeyValuePair<int, int>> findDuplicateInArrayCollection(int[] array)
        {
            var dict = new Dictionary<int, int>();
            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }
            return dict;
        }
    }
}
