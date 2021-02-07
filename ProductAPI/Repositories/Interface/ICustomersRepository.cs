using BusinessEntity.Product.Master.RequestDTO;
using Repositories.Product;
using System.Collections.Generic;

namespace Repositories.Interface
{
    public interface ICustomersRepository
    {
        long Add(CustomersRequest viewModel);
        long Update(CustomersRequest viewModel);
        long Delete(long Id);
        DBCustomers GetById(long Id);
        IEnumerable<DBCustomers> GetAll();
    }
}
