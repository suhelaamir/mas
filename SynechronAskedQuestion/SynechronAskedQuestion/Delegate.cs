using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class Delegate
    {
        public delegate void MultiCastDelegate1();
        public delegate int DelegateCalculate(int i, int j);
        public DelegateCalculate getOperationToPerform(int operation)
        {
            DelegateCalculate objDCalculate = null;
            if (operation == 1)
                objDCalculate = Add;
            else
                objDCalculate = Subtract;

            // objDCalculate.BeginInvoke(new AsyncCallback(CallBackMethod), objDCalculate);

            return objDCalculate;
        }
        public static void CallbackMethod(IAsyncResult result)
        {
            // int returnValue = flusher.EndInvoke(result);
        }
        public int Add(int i, int j)
        {
            return (i + j);
        }
        public string Add(string A, string B)
        {
            return A + B;
        }
        public int Subtract(int i, int j)
        {
            return (i + j);
        }
        // Reusable delegate
        public static void callDelegate()
        {
            List<Employee1> emplist = new List<Employee1>()
            {
                new Employee1() { ID=101, Name="Amir", Salary=600, Experience=6},
                new Employee1() { ID=102, Name="Khizr Khan", Salary=9000, Experience=9},
                new Employee1() { ID=103, Name="Arslan Khan", Salary=1000, Experience=10},
                new Employee1() { ID=104, Name="Khan Talat Jabeen", Salary=3000, Experience=5}
            };
            // IsPromotable promoteD = new IsPromotable(Promote);
            // Employee1.GetEmployeePromoted(emplist, promoteD);
            Employee1.GetEmployeePromoted(emplist, emp=>emp.Experience>=5);
            // MultiCast delegate
            MultiCastDelegate1 objeMultiCastDelegate1 = new MultiCastDelegate1(M1);
            objeMultiCastDelegate1 += M2;
            objeMultiCastDelegate1 += M4;
            objeMultiCastDelegate1 += M3;
            objeMultiCastDelegate1.Invoke();

        }
        public static bool Promote(Employee1 emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void M1()
        {
            Console.WriteLine("M1 is called");
        }
        public static void M2()
        {
            Console.WriteLine("M2 is called");
        }
        public static void M3()
        {
            Console.WriteLine("M3 is called");
        }
        public static void M4()
        {
            Console.WriteLine("M4 is called");
        }
    }
    public delegate bool IsPromotable(Employee1 emp);
    public class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void GetEmployeePromoted(List<Employee1> emplist, IsPromotable promotable)
        {
            foreach (Employee1 emp in emplist)
            {
                if (promotable(emp))
                {
                    Console.WriteLine(emp.Name + " Promoted");
                }
            }
        }
    }
}
