using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class encapsulation
    {
        private string name, location;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
