using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Product
{
   public class DBCustomers: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string SmsMessage { get; set; }
        public IEnumerable<DBProvideService> ProvideService { get; set; }
    }
}
