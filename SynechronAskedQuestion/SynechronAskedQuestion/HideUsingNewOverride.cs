using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class A12
    {
        public virtual void Method1()
        {
            Console.WriteLine("A12.Method1");
        }
    }
    public class B12: A12
    {

        public new void Method1()
        {
            try
            {
                Console.WriteLine("B12.Method1");
            }
            finally
            { }
        }
    }
    public class HideUsingNewOverride
    {
        public void MethodToCreateInstance()
        {
            A12 a12 = new B12();
            a12.Method1();
            B12 b12 = new B12();
            b12.Method1();


            BaseClass bc = new BaseClass();
            DeriveClass dc = new DeriveClass();
            BaseClass bcdc = new DeriveClass();//pllymorphism
            //BaseClass bcC = new C();
            //C objc = new C();
            bc.Method1();
            dc.Method1();
            bcdc.Method1();
            //objc.Method1();
            //bcC.M1();
            dc.M1();

            //Explicit Interface Implementation.
            ExplicitInterface objExplicitInterface = new ExplicitInterface();
            I1 i1 = (I1)objExplicitInterface;
            I2 i2 = (I2)objExplicitInterface;
            i1.Display();
            i2.Display();
        }
    }
    public class BaseClass
    {
        public BaseClass() { }
        public void Method1()
        {
            Console.WriteLine("Baseclass - method1");
        }
        public void method2() { }
    }
    public class DeriveClass: BaseClass
    {
        public DeriveClass() : base()
        { }
        public new void Method1()
        {
            Console.WriteLine("DerivedClass - Method1");
        }
    }
    public static class C 
    {
        public static void M1(this BaseClass obj)
        {
            Console.WriteLine("C - M1");
        }
    }
    public interface I1
    {
        void Display();
    }
    public interface I2
    {
        void Display();
    }
    public class ExplicitInterface: I1, I2
    {
        void I1.Display()
        {
            Console.WriteLine("I1");
        }
        void I2.Display()
        {
            Console.WriteLine("I2");
        }
    }
}
