using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultipleModelToTheView.Models
{
    public class EmployeeData
    {
        public int Id { get; set; }
        [Display(Name ="Name")]
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}