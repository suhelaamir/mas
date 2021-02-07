using BusinessEntity.Product.Master.RequestDTO;
using Microsoft.EntityFrameworkCore;
using Repositories.dbContext;
using Repositories.Product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repositories.Implementation
{
    public class ProvideServiceRepository
    {
        private ApplicationDBContext _Context;
        public ProvideServiceRepository(ApplicationDBContext context)
        {
            _Context = context;
        }
        public long Add(ProvideServiceRequest viewModel)
        {
            var obj = _Context.Database.ExecuteSqlCommand(" Execute InsertProvideService @ServiceName,@ServiceNumber,@CreatedOn,@EndDate,@Amount,@CustomerId,@CreatedBy",
                    new SqlParameter("@ServiceName", viewModel.ServiceName),
                    new SqlParameter("@ServiceNumber", viewModel.ServiceNumber),
                    new SqlParameter("@StartDate", viewModel.CreatedOn),
                    new SqlParameter("@EndDate", viewModel.EndDate),
                    new SqlParameter("@Amount", viewModel.Amount),
                    new SqlParameter("@CustomerId", viewModel.CustomerId),
                    new SqlParameter("@CreatedBy", viewModel.CreatedBy)
                    );

            return obj;
        }

        public long Delete(long Id)
        {
            var obj = _Context.Database.ExecuteSqlCommand("EXECUTE DeleteProvideService @Id,@ModifiedBy",
                new SqlParameter("@Id", Id),
                new SqlParameter("@ModifiedBy", 1)
                );
            return obj;
        }

        public IEnumerable<DBProvideService> GetAll()
        {
            IEnumerable<DBProvideService> obj = _Context.ProvideServices.FromSql("GetAllProvideService").ToList();
            return obj;
        }

        public DBCustomers GetById(long Id)
        {
            DBCustomers obj = _Context.Customers.FromSql("GetProvideServiceById @Id",
                new SqlParameter("@Id", Id)
                ).FirstOrDefault();
            return obj;
        }

        public long Update(ProvideServiceRequest viewModel)
        {
            var obj = _Context.Database.ExecuteSqlCommand("EXECUTE UpdateProvideService @Id,@ServiceName,@ServiceNumber,@EndDate,@Amount,@CustomerId,@ModifiedBy",
                    new SqlParameter("@Id", viewModel.Id),
                    new SqlParameter("@ServiceName", viewModel.ServiceName),
                    new SqlParameter("@ServiceNumber", viewModel.ServiceNumber),
                    new SqlParameter("@EndDate", viewModel.EndDate),
                    new SqlParameter("@Amount", viewModel.Amount),
                    new SqlParameter("@CustomerId", viewModel.CustomerId),
                    new SqlParameter("@ModifiedBy", viewModel.ModifiedBy)
                 );
            return obj;
        }
    }
}
