using BusinessEntity.Product.Master.RequestDTO;
using BusinessEntity.Product.Master.ResponseDTO;
using Repositories.dbContext;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Repositories.Product;

namespace Repositories.Implementation
{
    public class CustomersRepository : ICustomersRepository
    {
        private ApplicationDBContext _Context;
        public CustomersRepository(ApplicationDBContext context)
        {
            _Context = context;
        }
        public long Add(CustomersRequest viewModel)
        {
            var obj = _Context.Database.ExecuteSqlCommand(" Execute InsertCustomers @Name,@CreatedBy,@MobileNumber,@EmailId,@Address,@SmsMessage",
                    new SqlParameter("@Name", viewModel.Name),
                    new SqlParameter("@CreatedBy", viewModel.CreatedBy),
                    new SqlParameter("@MobileNumber", viewModel.Name),
                    new SqlParameter("@EmailId", viewModel.CreatedBy),
                    new SqlParameter("@Address", viewModel.Name),
                    new SqlParameter("@SmsMessag", viewModel.SmsMessage)
                    );

            return obj;
        }

        public long Delete(long Id)
        {
            var obj = _Context.Database.ExecuteSqlCommand("EXECUTE DeleteCustomers @Id,@ModifiedBy",
                new SqlParameter("@Id", Id),
                new SqlParameter("@ModifiedBy",1)
                );
            return obj;
        }

        public IEnumerable<DBCustomers> GetAll()
        {
            IEnumerable<DBCustomers> obj = _Context.Customers.FromSql("GetAllCustomers").ToList();
            return obj;
        }

        public DBCustomers GetById(long Id)
        {
            DBCustomers obj = _Context.Customers.FromSql("GetCustomersById @Id",
                new SqlParameter("@Id", Id)
                ).FirstOrDefault();
            return obj;
        }

        public long Update(CustomersRequest viewModel)
        {
            var obj = _Context.Database.ExecuteSqlCommand(" EXECUTE  UpdateCustomers @Id,@Name,@ModifiedBy,@MobileNumber,@EmailId,@Address,@SmsMessage",
                     new SqlParameter("@Id", viewModel.Id),
                     new SqlParameter("@Name", viewModel.Name),
                     new SqlParameter("@ModifiedBy", viewModel.ModifiedBy),
                     new SqlParameter("@MobileNumber", viewModel.MobileNumber),
                     new SqlParameter("@EmailId", viewModel.EmailId),
                     new SqlParameter("@Address", viewModel.Address),
                     new SqlParameter("@SmsMessage", viewModel.SmsMessage)
                 );
            return obj;
        }
    }
}
