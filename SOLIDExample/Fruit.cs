using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }



    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class AppleV2 : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class OrangeV2 : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
