using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    class RefKeywordPractice
    {
        /// <summary>
        /// its output will be 11, 2, 13, 4, 15
        /// because the for loop will have i like 0, 2, 4 so corresponding index has it array value: 11, 13, 15
        /// and the ref array will have its won value like at index 1 have 2 and index 3 have 4
        /// </summary>
        public static void FuctionCallUsingRef()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            GetRefUsed(ref array);
            Console.ReadLine();
        }
        private static void GetRefUsed(ref int[] array)
        {
            for (int i = 0; i < array.Length; i = i + 2)
            {
                array[i] = array[i] + 10;
            }
            Console.WriteLine(string.Join(",",array));
        }
    }
}
