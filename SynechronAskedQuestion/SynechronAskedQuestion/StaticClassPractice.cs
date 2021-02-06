using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class StaticClassPractice
    {
        public StaticClassPractice()
        {
            Console.WriteLine("default");
        }
        static StaticClassPractice()
        {
            Console.WriteLine("static");
        }
    }
    public class A: StaticClassPractice
    {
        public A()
        {
            Console.WriteLine("Child class default.");
        }
        static A()
        {
            Console.WriteLine("Child static");
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("B default");
        }
        static B()
        {
            Console.WriteLine("B static");
        }
    }
}
