using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModelToTheView.Models
{
    public class Teacher
    {
        [CombinedMinLength(20, "Code", "Name", ErrorMessage = "min lenth should be 20")]
        public int TeacherId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }
    }

    public class ViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}