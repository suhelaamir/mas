using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public static class ExtensionMethod
    {
        //extension method should be static
        //we can add this method in existing type without changing the existing type
        public static int GetWordCount(this string str)
        {
            Base bs = new Derived();
            bs.BaseMethod();
           
            return str.Split(' ').Length;
        }
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
        public static string GetSubstringInAddress(this string str, string AddressName)
        {
            return AddressName.Substring(0, 11)+"....";
        }
        public static void Love(this StringCount count, int i)
        { }
    }
    public sealed class StringCount
    {
        public void SomeMethod(string str)
        {
            StringCount s = new StringCount();
            s.Love(12);
            if (str.GetWordCount() > 1)
            {
            }
            else
            {
            }
        }
    }
    public class Base
    {
        public Base() { }
        public virtual void BaseMethod()
        {
            Console.WriteLine("I am base");
        }
    }
    public class Derived: Base
    {
        public Derived()
        { }
        public new void BaseMethod()
        {
            Console.WriteLine("I am derived");
        }
    }
}
