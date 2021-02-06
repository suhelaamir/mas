using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    class GarbageCollection
    {
        public void M()
        {
            string path = @"C:\temp\MyTest.txt";
            using (System.IO.StreamWriter sw = System.IO.File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }
    }
    class FinalizeDemo : IDisposable
    {
        public FinalizeDemo()
        {
            Console.WriteLine("Object Created");

        }

        ~FinalizeDemo()
        {
            Console.WriteLine("Destructor Called.");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose Method Called");
        }
    }
}
