using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    /// <summary>
    ///Destructors (~) cannot be defined in Structs.
    ///Destructors(~) are only used with classes.
    ///Destructor cannot be inherited or overloaded.
    ///Destructor does not take modifiers or have parameters.
    ///Destructor cannot be called. They are invoked automatically.
    /// </summary>
    class First
    {
        ~First()
        {
            System.Console.WriteLine("First's destructor is called");
        }
    }
    class Second : First
    {
        ~Second()
        {
            System.Console.WriteLine("Second's destructor is called");
        }
    }
    class Third : Second
    {
        ~Third()
        {
            System.Console.WriteLine("Third's destructor is called");
        }
    }
}
