using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class HieghtSalaryUsingLinq
    {
        public string name { get; set; }
        public int id { get; set; }
        public int salary { get; set; }

        public static List<HieghtSalaryUsingLinq> GetSalary()
        {
            List<HieghtSalaryUsingLinq> _hieghtSalaryUsingLinq = new List<HieghtSalaryUsingLinq>();
            _hieghtSalaryUsingLinq.Add(new HieghtSalaryUsingLinq { id = 1, name = "Amir", salary = 1000 }) ;
            _hieghtSalaryUsingLinq.Add(new HieghtSalaryUsingLinq { id=2,name="Khizr Khan", salary = 3000});
            _hieghtSalaryUsingLinq.Add(new HieghtSalaryUsingLinq { id = 3, name = "Arslan Khan", salary = 9780 });
            _hieghtSalaryUsingLinq.Add(new HieghtSalaryUsingLinq { id = 4, name ="Talat", salary = 8762});
            _hieghtSalaryUsingLinq.Add(new HieghtSalaryUsingLinq { id = 5, name = "Kamrealam", salary = 87320});

            return _hieghtSalaryUsingLinq;
        }
    }
}
