using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity.Product.Master.ResponseDTO
{
    public class CustomersResponse: BaseResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string SmsMessage { get; set; }
        public IEnumerable<ProvideServiceResponse> ProvideService { get; set; }
    }
}
