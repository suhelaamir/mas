using MultipleModelToTheView.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleModelToTheView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.message = "Welcome Teachers";
            ViewBag.name = "Amir";
            dynamic myModel = new ExpandoObject();
            myModel.Teachers = GetTeachers();
            myModel.Students = GetStudents();
            return View(myModel);
        }
        public ActionResult GetEmployeeList()
        {
            IEnumerable<EmployeeData> employeeData = new List<EmployeeData>() { 

                new EmployeeData
                {
                    Id = 101,
                    EmployeeName = "Amir",
                    Age = 35,
                    Salary = 6000
                },
                new EmployeeData
                {
                    Id = 102,
                    EmployeeName = "Khizr Khan",
                    Age = 3,
                    Salary = 300
                },
                new EmployeeData
                {
                    Id = 103,
                    EmployeeName = "Arslan Khan",
                    Age = 1,
                    Salary = 100
                }
            };
            TempData["EMP"] = employeeData;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher{TeacherId=1, Code="TT", Name="Amir" });
            teachers.Add(new Teacher { TeacherId = 2, Code = "Maths", Name = "Sonali" });
            teachers.Add(new Teacher { TeacherId=3, Code="History", Name="Sushil"});
            return teachers;
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentId = 1, Code = "001", Name = "Rajiv", EnrollmentNo = "1234" });
            students.Add(new Student { StudentId=2, Code="002", Name="Khizr", EnrollmentNo="1235"});
            students.Add(new Student { StudentId=3, Code="003", Name="Arslan", EnrollmentNo="112"});
            return students;
        }
    }
}