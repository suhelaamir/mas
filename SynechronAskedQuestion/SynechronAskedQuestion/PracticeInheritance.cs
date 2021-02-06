using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class PracticeInheritance
    {
        public virtual void M1() {
            Console.WriteLine("test");
        }
    }
    public class PracticeInheritanceB: PracticeInheritance
    {
        public override void M1()
        {
            Console.WriteLine("Derived class called");
        }
        public void M2()
        {
            Console.WriteLine("M2");
        }
        public double M2(Int32 i, Int32 j)
        {
            return i + j;
        }
        public Int32 M2(Int32 i, Int32 j, Int32 k)
        {
            return i + j + k;
        }
    }
    public interface IInheritance1
    {
        void M1();
    }
    public interface IInheritance2
    { }
    public class PracticeInheritanceC
    { }

}
