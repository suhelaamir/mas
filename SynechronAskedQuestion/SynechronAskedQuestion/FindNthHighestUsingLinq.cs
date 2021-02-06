using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class FindNthHighestUsingLinq
    {
        public void FindNthHighestNumber()
        {
            int[] number = { 11, 90, 17, 4, 3, 4 };
            var result = from n in number orderby n descending select n;
            var res = result.Skip(2);
            var highestnumber = result.ToList().ElementAt(0);//1st highest element
            Console.WriteLine("Nth Highest number: {0}", highestnumber);

            var highestn = number.GroupBy(x => x).OrderByDescending(Group => Group.Key).ToList().ElementAt(0);
            //find duplicate records
            var duplicateRecord = number.GroupBy(g => g).Where(x=>x.Count()>1).Select(x=> new { key=x.Key, count=x.Count()});
            foreach (var item in duplicateRecord)
            {
                Console.WriteLine(item.key +" is repeated "+item.count +" times.");
            }
            //Console.Readline();();
        }
             
    }
}
