using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class FindDuplicateStrInTheSentenceAndFindCalculatedValueInArray
    {
        public void Find()
        {
            int[] val = { 6, -6, 8, -8, 9,8,4,-12, 8 };
            int[] num = new int[1];
            int resultVal = val.Sum();
            num[0] = resultVal;

            //https://dailydotnettips.com/back-to-basic-how-to-count-occurrences-of-a-specific-word-in-a-sentence-using-c/
            string strRepeatedWord = "Geeksforgeeks in the administration for geeks";
            string matchword = "geeks";
            int count = 0;
            foreach (Match matchw in Regex.Matches(strRepeatedWord, matchword, RegexOptions.IgnoreCase))
            {
                count++;
            }
            Console.WriteLine(count);
            //Console.Readline();();
        }
    }
}
