using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    /// <summary>
    /// AsyncAwaitProgramming
    /// </summary>
    public class AsyncAwaitProgramming
    {
        /// <summary>
        /// CallAllMethod
        /// </summary>
        public static async void CallAllMethod()
        {
            Task<int> task = Method1();
            Method2();
            //int count = await task;
            int i = task.Result;
            Method3(i);
        }
        static async Task<int> Method1()
        {
            System.Threading.Thread.Sleep(30000);
            int count=0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method1=" + i);
                    count += 1;
                }
            });
            return count;
        }
        static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method2="+i);
            }
        }
        static void Method3(int count)
        {
            Console.WriteLine("Getting count from Mehotd1="+count);
        }
    }
}
