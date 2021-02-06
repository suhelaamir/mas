using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public static class PrintStar
    {
        public static void PrintStarOnDemand()
        {
            int num = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }
                num++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
