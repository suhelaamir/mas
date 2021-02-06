using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public delegate void MyDelegate(string name);
    public class DelegateSyntax
    {
        MyDelegate del = new MyDelegate(GetStringName);
      
        public static void GetStringName(string name)
        {
            Console.WriteLine("My name is Amir");
        }
    }
}
