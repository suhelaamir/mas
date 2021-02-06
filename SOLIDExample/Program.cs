using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class Program
    {
        static void Main(string[] args)
        {

            SRPrincipleProb();
            //SRPrincipleResolve();
            //OCPrincipleProb();
            //OCPrincipleResolve();
            //LSPrincipleProb();
            //LSPrincipleResolve();
            //DIPrincipleProb();
            //DIPrincipleResolve();
            Console.ReadLine();
        }

        /// <summary>
        /// This method violate Single responsibility principle
        /// </summary>
        public static void SRPrincipleProb()
        {
            Employee emp = new Employee();
            emp.deleteAllEmp();
            Console.WriteLine("employee records deleted...");
            emp.EmpName = "Sandeep Tathe";
            emp.Designation = "Specialist";
            emp.insertEmployee(emp);
            emp.EmpName = "Yogiraj Deshpande";
            emp.Designation = "Senior Consultant";
            emp.insertEmployee(emp);
            Console.WriteLine("employee records inserted...");
            Console.WriteLine("report generation started...");
            emp.GenerateReport();
            Console.WriteLine("report generated...");
        }

        /// <summary>
        /// This method achive Single responsibility principle
        /// </summary>
        public static void SRPrincipleResolve()
        {
            EmployeeV2 emp = new EmployeeV2();
            emp.deleteAllEmp();
            Console.WriteLine("employee records deleted...");
            emp.EmpName = "Sandeep Tathe";
            emp.Designation = "Specialist";
            emp.insertEmployee(emp);
            emp.EmpName = "Yogiraj Deshpande";
            emp.Designation = "Senior Consultant";
            emp.insertEmployee(emp);
            Console.WriteLine("employee records inserted...");

            Console.WriteLine("report generation started...");
            ReportGeneration report = new ReportGeneration();
            report.GenerateReport((int)ReportType.CSV);
            Console.WriteLine("report generated...");
        }

        /// <summary>
        /// This method violate Open Closed principle
        /// </summary>
        public static void OCPrincipleProb()
        {
            Console.WriteLine("report generation started...");
            ReportGeneration report = new ReportGeneration();
            report.GenerateReport((int)ReportType.CSV);
            report.GenerateReport((int)ReportType.Excel);
            report.GenerateReport((int)ReportType.PDF);
            report.GenerateReport((int)ReportType.WORD);
            Console.WriteLine("report generated...");
        }

        /// <summary>
        /// This method achive Open Closed principle
        /// </summary>
        public static void OCPrincipleResolve()
        {
            Console.WriteLine("report generation started...");
            ReportGenerateCsv exportToCsv = new ReportGenerateCsv();
            exportToCsv.generateReport();

            ExportToExcel exportToExcel = new ExportToExcel();
            exportToExcel.generateReport();

            ExportToPDF exportToPDF = new ExportToPDF();
            exportToPDF.generateReport();
            Console.WriteLine("report generated...");
        }

        /// <summary>
        /// This method violate Liskov Substitution  principle
        /// </summary>
        public static void LSPrincipleProb()
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
        }

        /// <summary>
        /// This method achive Liskov Substitution  principle
        /// </summary>
        public static void LSPrincipleResolve()
        {
            Fruit fruit = new OrangeV2();
            Console.WriteLine(fruit.GetColor());
            fruit = new AppleV2();
            Console.WriteLine(fruit.GetColor());
        }

        /// <summary>
        /// This method violate Dependency Inversion principle
        /// </summary>
        public static void DIPrincipleProb()
        {
            Notification notification = new Notification();
            notification.PromotionalNotification();
        }

        /// <summary>
        /// This method achive Dependency Inversion principle
        /// </summary>
        public static void DIPrincipleResolve()
        {
            Console.WriteLine("Constructor Injection...");
            ConstructorInjection();
            Console.WriteLine("\nProperty Injection...");
            PropertyInjection();
            Console.WriteLine("\nMethod Injection...");
            MethodInjection();
        }

        public static void ConstructorInjection()
        {
            ConstructorNotification notification = new ConstructorNotification(new EmailV2());
            notification.DoNotify();
            notification = new ConstructorNotification(new SMSV2());
            notification.DoNotify();
        }

        public static void PropertyInjection()
        {
            PropertyNotification notification = new PropertyNotification();
            notification.MessageService = new EmailV2();
            notification.DoNotify();
            notification.MessageService = new SMSV2();
            notification.DoNotify();
        }

        public static void MethodInjection()
        {
            MethodNotification notification = new MethodNotification();
            notification.DoNotify(new EmailV2());
            notification.DoNotify(new SMSV2());
        }
    }
}
