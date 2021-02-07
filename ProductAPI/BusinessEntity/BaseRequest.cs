using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity
{
    public class BaseRequest
    {
        public BaseRequest()
        {
            CreatedBy = 1;
            ModifiedBy = 1;
            ModifiedOn = DateTime.Now;
        }
        public int IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
