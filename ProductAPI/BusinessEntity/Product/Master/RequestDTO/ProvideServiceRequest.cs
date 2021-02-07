using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity.Product.Master.RequestDTO
{
    public class ProvideServiceRequest: BaseRequest
    {
        public int Id { get; set; }
        //case 1: Garage: ModelName like Hero, bajaj.
        //case 2: School: StudentName
        public string ServiceName { get; set; }
        //case 1: Garage: MotorcycleNumber liek UP32 DA 1242.
        //case 2: School: RollNumber
        public string ServiceNumber { get; set; }
        //public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    }
}
