using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityContainer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Driver driver = new Driver(new BMW());

            //driver.RunCar();

            //IUnityContainer container = new UnityContainer();
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            var driver = container.Resolve<Driver>();
            driver.RunCar();



            Console.ReadLine();
        }
    }


    public interface ICar
    {
        int Run();
    }

    public class BMW : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Ford : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Audi : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }

    }
    public class Driver
    {
        //private ICar _car = null;

        //public Driver(ICar car)
        //{
        //    _car = car;
        //}
        [Dependency]
        public ICar _car { get; set; }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
