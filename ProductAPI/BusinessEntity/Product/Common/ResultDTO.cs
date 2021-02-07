using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity.Product.Common
{
    public class ResultDTO<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
    }
}
