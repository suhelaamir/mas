using BusinessEntity.Product.Master.RequestDTO;
using Repositories.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interface
{
    public interface IProvideServiceRepository
    {
        long Add(ProvideServiceRequest viewModel);
        long Update(ProvideServiceRequest viewModel);
        long Delete(long Id);
        DBProvideService GetById(long Id);
        IEnumerable<DBProvideService> GetAll();
    }
}
