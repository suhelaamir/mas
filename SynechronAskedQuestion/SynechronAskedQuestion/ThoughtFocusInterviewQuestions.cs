using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class ThoughtFocusInterviewQuestions
    {
        string i = "hi";
        enum color : int
        {
            red,
            green,
            blue = 5,
            cyan,
            magenta = 80,
            yellow
        }
        public static void Test()
        {
            Test4();
            Console.WriteLine((int) color.green + ", ");
            Console.WriteLine((int)color.yellow);
            Console.WriteLine("==========================");
            Test1();
            Console.WriteLine("==========================");
            Test3();
            //Console.ReadLine();
        }

        enum color1
        {
            red,
            green,
            blue
        }
        public static void Test1()
        {
            color1 z;
            z = color1.red;
            Console.WriteLine(z);
        }

        public static void Test3()
        {
            int[][] a = new int[2][];
            a[0] = new int[4] { 6,1,4,3};
            a[1] = new int[3] { 9,2,7};
            foreach (int[ ] i in a)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j + " ");
                }
            }
        }
        public static void Test4()
        {
            ThoughtFocusInterviewQuestions obj1 = new ThoughtFocusInterviewQuestions();
            ThoughtFocusInterviewQuestions obj2 = new ThoughtFocusInterviewQuestions();
            obj2 = null;
            if (obj1 == obj2)
            {
                Console.WriteLine("Reference check");
            }

            if (obj1.Equals(obj2))
            {
                Console.WriteLine("Value check"); 
            }

            string AAB = "Amir Suhel";
            string V = "Amir Suhel";
            if (AAB.Equals(V))
            {
                Console.WriteLine("True");
            }

            if (AAB.Contains(V))
            {
                Console.WriteLine("False");
            }
        }
    }
}
