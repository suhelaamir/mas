using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class Methods
    {
        public void Calling()
        {
            int x = 10;
            CallbyVal(x);
            Console.WriteLine("CallbyVal: {0}", x);
            CallbyRef(ref x);
            Console.WriteLine("CallbyRef: {0}", x);
           
        }
        public static void CallbyVal(int a)
        {
            a *= a;
            Console.WriteLine("Inside: {0}", a);
        }

        public static void CallbyRef(ref int a)
        {
            a *= a;
            Console.WriteLine("Inside: {0}", a);
        }
        
    }
}
