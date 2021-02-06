using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class Anagrams
    {
        public static void AnagramsCheck()
        {
            string wordFirst = "Listen";
            string wordSecond = "Silent";

            char[] wordCharFirst = wordFirst.ToLower().ToCharArray();
            char[] wordCharSecond = wordSecond.ToLower().ToCharArray();
            Array.Sort(wordCharFirst);
            Array.Sort(wordCharSecond);
            string newcharFirst = new string(wordCharFirst);
            string newcharSecond = new string(wordCharSecond);

            if (newcharFirst == newcharSecond)
            {
            }
            else
            {
            }
        }
    }
}
