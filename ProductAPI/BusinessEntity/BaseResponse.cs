﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity
{
    public class BaseResponse
    {
        public string status { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }
    }
}