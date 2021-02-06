using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class TestEvent
    {
        public event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("Event are added.");
            }
            remove
            {
                Console.WriteLine("Event are detached");
            }
        }
    }
    public class InvokEvent
    {
        public void Event()
        {
            TestEvent testevent = new TestEvent();
            testevent.MyEvent += Testevent_MyEvent;
            testevent.MyEvent -= Testevent_MyEvent;
        }
        private void Testevent_MyEvent(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
