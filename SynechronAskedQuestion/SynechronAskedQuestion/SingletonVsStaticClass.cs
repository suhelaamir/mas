using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class Love
    {
        public int i;
        void display()
        {
            Console.WriteLine("Love");
        }
    }
    public class Janu: Love
    {
        public int j;
        public void display()
        {
            Console.WriteLine("Janu");
        }
    }
    public interface A1
    {
        string ReturnMessage();
    }
    public class NormalClass
    {
        public int ABC;
    }
    public sealed class SingletonVsStaticClass : A1
    {
        private static SingletonVsStaticClass _instance;
        public static SingletonVsStaticClass Instance
        {
            get
            {
                return _instance ?? (_instance = new SingletonVsStaticClass());
            }
        }
        private SingletonVsStaticClass() { }
        public string Message { get; set; }

        public string ReturnMessage()
        {
            throw new NotImplementedException();
        }
    }
    public static class StaticClass 
    {
        private static readonly int somevalue;
        static StaticClass()
        {
            somevalue = 1;
        }
        public static string ShowMessage()
        {
            return string.Format("Value of the variable in the class: {0}", somevalue);
        }
        const int number = 1;//we can have const variable in static class because it is itself a static
    }
    //public class B
    //{
    //    protected void B1() { }
    //}
    //public abstract class A : B
    //{
    //    protected abstract void F1();
    //}
    //public class C : A
    //{
    //    public override void F1()
    //    {

    //    }
    //}

    public abstract class EmployeeMannager
    {
        protected EmployeeMannager() { ShowEmpList(); }
        public void GetEmployeeDetails(string companyID, string empId)
        {

        }

        public abstract void GetEmployeeSalaryStructure(string companyID, string empId);
        protected abstract List<string> emplist { get; set; }
        void ShowEmpList()
        {
            int indexArray = emplist.IndexOf("Amir");
            foreach (string name in emplist)
            {
                Console.WriteLine("Name: {0}", name);
            }
            //Console.Readline();();
        }
    }

    public class TietoEmployee: EmployeeMannager
    {
        public override void GetEmployeeSalaryStructure(string companyID, string empId)
        {
           
        }
        public void GetEqualAndContains()
        {
            string containsCheck = "Amir Suhel Khan";
            Console.WriteLine("Contains: {0} and Equals: {1}", containsCheck.Contains("Amir"), containsCheck.Equals("Amir Khan"));
        }
        protected override List<string> emplist
        {
            get;

            set;
        }  = new List<string>() { "Amir", "Vinod", "Khizr Khan", "Arslan Khan"};
    }

    public class HitachhiEmployee : EmployeeMannager
    {
        protected override List<string> emplist
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void GetEmployeeSalaryStructure(string companyID, string empId)
        {

        }
    }
    #region Generics
    public class KGK<T>
    {
        private T loveYouJann;
        public T myVal
        {
            get { return loveYouJann; }
            set { loveYouJann = myVal; }
        }
    }
    #endregion
}
