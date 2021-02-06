using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class CopyConstructor
    {
        public string name = string.Empty, location = string.Empty;
        public CopyConstructor(string a, string b) {
            name = a;
            location = b;
        }

        public CopyConstructor(CopyConstructor user) {
            name = user.name;
            location = user.location;
        }
    }
}
