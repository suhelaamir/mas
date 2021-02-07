using BusinessEntity.Product.Common;
using BusinessEntity.Product.Master.RequestDTO;
using BusinessEntity.Product.Master.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Interface
{
    public interface ICustomersService
    {
        ResultDTO<long> Add(CustomersRequest viewModel);
        ResultDTO<long> Update(CustomersRequest viewModel);
        ResultDTO<long> Delete(long Id);
        ResultDTO<CustomersResponse> GetById(long Id);
        ResultDTO<IEnumerable<CustomersResponse>> GetAll();
    }
}
