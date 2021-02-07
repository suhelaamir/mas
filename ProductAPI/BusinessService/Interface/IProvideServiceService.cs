using BusinessEntity.Product.Common;
using BusinessEntity.Product.Master.RequestDTO;
using BusinessEntity.Product.Master.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Interface
{
    public interface IProvideServiceService
    {
        ResultDTO<long> Add(ProvideServiceRequest viewModel);
        ResultDTO<long> Update(ProvideServiceRequest viewModel);
        ResultDTO<long> Delete(long Id);
        ResultDTO<ProvideServiceResponse> GetById(long Id);
        ResultDTO<IEnumerable<ProvideServiceResponse>> GetAll();
    }
}
