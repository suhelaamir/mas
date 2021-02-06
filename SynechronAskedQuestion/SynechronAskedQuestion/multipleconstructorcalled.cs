using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class multipleconstructorcalled
    {
        public static void CallMethods()
        {
            a obj = new a();
        }        
    }

    public class a
    {
        public a() : this(2, 2)
        {
            Console.WriteLine("call 0 parameter method");
        }
        public a(int a, int b) 
        {
            Console.WriteLine("call 2 parameter method");
        }
       
    }
    //public class b : a
    //{
    //    public b()
    //    {
    //        Console.WriteLine("b parametre");
    //    }
    //}
}
