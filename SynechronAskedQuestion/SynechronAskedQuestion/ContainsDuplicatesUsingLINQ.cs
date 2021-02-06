using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class ContainsDuplicatesUsingLINQ
    {
        /// <summary>
        /// how to check the duplicate records in array
        /// </summary>
        /// <param name="arrayToCheck"></param>
        /// <returns></returns>
        public static void DuplicateValues()
        {
            int[] arrayExpression = { 1, 1, 2, 2, 3, 90, 90 };
            //1. to get duplicate records
            var duplicates = arrayExpression.GroupBy(g=>g).Where(x=>x.Count()>1).Select(t=>new { duplicateKey=t.Key, duplicateValue=t.Count()});
             
            foreach (var item in duplicates)
            {
                Console.WriteLine(item.duplicateKey+" repeated "+ item.duplicateValue+"times");
            }
            // 2. to get duplicate records with writing new function of it
            int[] arrray = containsDuplicates(arrayExpression); //check the duplicate records in an array
            Console.WriteLine("=================Duplicate items using LINQ====================");
            foreach (var item in arrray.OrderBy(o => o))
            {
                Console.WriteLine("Duplicate items are: {0}", item);
            }
        }
        public static int[] containsDuplicates(int[] arrayToCheck)
        {
            var duplicates = arrayToCheck
                             .GroupBy(s => s)
                             .Where(g => g.Count() > 1) //this will return the duplicate records in array
                                                        // .Where(g => g.Count() == 1) //this will return the unique records in array
                             .Select(g => g.Key);

            return duplicates.ToArray();
        }
    }
}
