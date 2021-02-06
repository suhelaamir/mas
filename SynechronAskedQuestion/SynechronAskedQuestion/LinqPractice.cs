using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class LinqPractice
    {
        public void GetCalled()
        {
            Customer[] customers = new Customer[] {
                new Customer { CustId=101, Name="Khizr Khan", Address="Pune", PhoneNumber="123"},
                new Customer { CustId=102, Name="Arslan Khan", Address="Lucknow", PhoneNumber="456"},
                new Customer { CustId=103, Name="Nabeel", Address="Mehan", PhoneNumber="457"}
            };
                Car[] cars = new Car[] {
                new Car { CarId=1, ModelName="TataNano", Color="Red", SoldTo=101},
                new Car { CarId=2, ModelName="Amesador", Color="White", SoldTo=102},
                new Car { CarId=3, ModelName="Amesador2", Color="Silver", SoldTo=105}
            };
            //Lambda expression
            var CrossJoinUsingLambda = customers.SelectMany(t1 => cars.Select(t2 => new {
                Name=t1.Name, Phone=t1.PhoneNumber, CarName=t2.ModelName, Color=t2.Color
            }));
            Console.WriteLine();
            Console.WriteLine("Name           Phone         CarName     Color");
            Console.WriteLine();
            foreach (var item in CrossJoinUsingLambda)
            {
                Console.WriteLine(item.Name+"       "+item.Phone+"      "+item.CarName+"        "+item.Color);
            }
            //Linq expression
            var dataGotByLinq = from customer in customers from car in cars
                                //where (customer.CustId == car.SoldTo)
                                select new { Name=customer.Name, Phone=customer.PhoneNumber, CarName=car.ModelName, Color=car.Color};
            Console.WriteLine();
            Console.WriteLine("Name           Phone         CarName     Color");
            Console.WriteLine();
            foreach (var item in dataGotByLinq)
            {
                Console.WriteLine(item.Name + "       " + item.Phone + "      " + item.CarName + "        " + item.Color);
            }

            //Left outer join
            var queryLeftOuterJoin = from customer in customers
                                     join car in cars on customer.CustId equals car.SoldTo 
                                     //into result from result1 in result.DefaultIfEmpty()
                                     select new { Name=customer.Name, Phone=customer.PhoneNumber, CarName=car.ModelName, Color=car.Color};
            Console.WriteLine();
            Console.WriteLine("Name           Phone         CarName     Color");
            Console.WriteLine();
            foreach (var item in queryLeftOuterJoin)
            {
                Console.WriteLine(item.Name + "       " + item.Phone + "      " + item.CarName + "        " + item.Color);
            }
            //Console.Readline();(); 
        }
    }
    public class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Car
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }
        public int SoldTo { get; set; }
    }
    #region Single SingleOrDefault First FirstOrDefault
    #endregion Single SingleOrDefault First FirstOrDefault
    #region Sum of the even numbers
    public class EvenNumbers
    {
        public static void SumOfEvenNumbers()
        {
            int[] value = { 1, 3, 4, 5, 7, 8, 10 };
            var result = (from n in value where (n % 2 == 0) select n).Sum();
        }
    }
    #endregion Sum of the even numbers

    #region Joins in linq
    public class Departments
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Departments> GetAllDepartment()
        {
            return new List<Departments>()
            {
                new Departments { ID = 1, Name="IT"},
                new Departments { ID=2, Name="PMC"}
            };
        }

    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee> GetAllEmployee()
        {
            return new List<Employee>()
            {
                new Employee { ID=1, Name="Khizr", DepartmentId=1},
                new Employee { ID=2, Name="Arslan", DepartmentId=2},
                new Employee { ID=3, Name="Talat", DepartmentId=1},
                new Employee { ID=4, Name="Golu"}
            };
        }
        public static void GetResultUsingLeftJoin()
        {
            var result = from e in Employee.GetAllEmployee()
                         join d in Departments.GetAllDepartment() on e.DepartmentId equals d.ID into eGroup
                         from d in eGroup.DefaultIfEmpty()
                         select new {
                             EmployeeId = e.ID,
                             EMployeeName = e.Name,
                             DepartmentName = d == null ? "Department not found" : d.Name
                         };
            foreach (var v in result)
            {
                Console.WriteLine("EmployeeId: " + v.EmployeeId + " Emp Name: " + v.EMployeeName + " DepartmentName: " + v.DepartmentName);
            }
            Console.WriteLine("===============Inner Join===============");
            var innerJoinResult = from e in Employee.GetAllEmployee()
                                  join d in Departments.GetAllDepartment() on e.DepartmentId equals d.ID
                                  orderby e.ID
                                  select new
                                  {
                                      EmployeeName = e.Name,
                                      DepartmentName = d.Name
                                  };
            foreach (var item in innerJoinResult)
            {
                Console.WriteLine("EmployeeName: "+item.EmployeeName +" DepartmentName: "+ item.DepartmentName);
            }
            Console.WriteLine("====================Cross Join===================");
            var crossJoin = from e in Employee.GetAllEmployee() from d in Departments.GetAllDepartment()
                            select new
                            {
                                empname = e.Name,
                                depname = d.Name
                            };
            foreach (var item in crossJoin)
            {
                Console.WriteLine("Empname: "+item.empname + "DepartmanetName: "+item.empname);
            }
        }
    }
    #endregion Joins in linq
}
