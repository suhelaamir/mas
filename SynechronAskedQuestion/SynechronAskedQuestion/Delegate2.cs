using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class Delegate2
    {
        public delegate void MyDelegate(int i);
        public event MyDelegate MyEvent;
        public void RaiseEvent()
        {
            MyEvent(20);
            Console.WriteLine("RaisEvent Called.");
        }
        public void Display(int i)
        {
            Console.WriteLine("Display the value of {0}",i);
        }
    }
}
