using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class testClass : IDisposable
    {
        void IDisposable.Dispose()
        {
            Console.WriteLine("Dispose method called");
        }
    }
    public class UsingBlock
    {
        public void CallUsingMethod()
        {
            using (testClass obj = new testClass())
            {
                Console.WriteLine("Amir");
            }
            //Dispose method called 
            Console.WriteLine("Khan");
            Console.ReadLine();
        }
    }
}
