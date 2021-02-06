using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class FindDuplicateSingleDigitOrCharInArray
    {
        public static void DisplayNumberAndFrequencyOfNumber()
        {
            int[] numberF = { 1, 2, 9, 5, 6, 5, 9, 4, 8, 0,5 };
            string str = "Khizr Khan";
            var result = from n in str group n by n into y select y;
            Console.WriteLine("==============Number Frequency===============");
            foreach (var item in result)
            {
                if (item.Key != ' ')
                {
                    Console.WriteLine("Number=" + item.Key + " appears " + item.Count() + " times");
                }
            }
            Console.WriteLine("==============Number Frequency===============");
            //Console.ReadLine();
        }
        public static void findDuplicateSingleDigitOrCharInArray()
        {
            DisplayNumberAndFrequencyOfNumber();
            //find the duplicate integers in integer array
            int[] array = { 10, 15, 222, 125, 49, 135 };
            var dict = new Dictionary<char, int>();

            foreach (var value in array)
            {
                foreach (var i in (value.ToString()).ToCharArray())
                {
                    if (dict.ContainsKey(i))
                        dict[i]++;
                    else
                        dict[i] = 1;
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            }

            Console.WriteLine("=============Find duplicate value and collected it in Array====================");
            //Collect the duplicate integer in int array.
            var makeItForIntArray = dict.Where(g => g.Value > 1)
                         .Select(g => g.Key).Select(c => Convert.ToInt32(c.ToString()));
            int[] sequence = makeItForIntArray.ToArray();//makeItForIntArray.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            sequence = sequence.OrderBy(o => o).ToArray();
            Console.WriteLine("Duplicated value in asceding order");
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("====================Find the duplicate value======================");
            var it = dict.Where(g => g.Value > 1);
            var result = it.OrderBy(o => o.Key);
            foreach (var i in result)
            {
                Console.WriteLine("Value {0} occured {1} times", i.Key, i.Value);
            }

            //find the duplicate characters in string
            string[] name = { "Khizr Khan", "Talat", "Amir" };
            var dictForChar = new Dictionary<char, int>();
            foreach (var item in name)
            {
                foreach (var itemChar in item.Replace(" ","").ToLower().ToCharArray())
                {
                    if (dictForChar.ContainsKey(itemChar))
                    {
                        dictForChar[itemChar]++;
                    }
                    else
                    {
                        dictForChar[itemChar] = 1;
                    }
                }
            }
            Console.WriteLine("=================Character counter============================");
            foreach (var duplicateChar in dictForChar)
            {
                Console.WriteLine("Value {0} occures {1} times", duplicateChar.Key, duplicateChar.Value);
            }
            var result1 = dictForChar.Where(x=>x.Value>1);
            var sortedResult = result1.OrderBy(o =>o.Key);
            Console.WriteLine("Sorted Item are:");
            foreach (var sortedItem in sortedResult)
            {
                Console.WriteLine("Value {0} occures {1} times", sortedItem.Key, sortedItem.Value);
            }
        }
    }
}
