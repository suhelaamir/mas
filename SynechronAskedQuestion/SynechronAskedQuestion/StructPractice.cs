using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    /// <summary>
    /// does not support the destructor
    /// does not support parameter less constructor
    /// its a value type and stored on stack
    /// automatically destroy once the scope is over
    /// when we create the parameter less object of the struct then it assigne default value as 0 in case of integer type
    /// in case of string type it get assigned as null
    /// </summary>
    public struct StructPractice
    {
        public string x, y;
        public StructPractice(string a, string b)
        {
            x = a;
            y = b;
        }
    }
}
