using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public abstract class AbstractClassPractice
    {
        public delegate void M();
        public static readonly string r = ConfigurationManager.AppSettings["DallorPrice"];
        public string DefaultMessage { get; set; }
        public AbstractClassPractice()
        {
            Console.WriteLine("r has a value: {0}", r);
            DefaultMessage = "Amir send a message.";
            ////Console.Readline();();
        }
        public AbstractClassPractice(string i)
        {
            var i1 = i;
            Console.WriteLine("i has value {0}", i1);
        }
        static AbstractClassPractice()
        {
            Console.WriteLine("r has single value: {0}", r);
            //Console.Readline();();
        }
        public virtual void MainMethod()
        {
            Console.WriteLine(DefaultMessage);
        }
        
    }
    public class UseAbstractClass : AbstractClassPractice
    {
        public UseAbstractClass() : base()
        {
        }
        public override void MainMethod()
        {
            Console.WriteLine("Derived Mesage");//apen new behaviour.
            base.MainMethod();
        }
    }
}
