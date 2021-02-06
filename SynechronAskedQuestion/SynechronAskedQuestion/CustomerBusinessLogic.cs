using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    #region Implemented IOC and DIP
    //Implemented IOC and DIP
    //public interface ICustomerDataAccess
    //{
    //    string GetCustomerName(int id);
    //}

    //public class CustomerDataAccess : ICustomerDataAccess
    //{
    //    public string GetCustomerName(int id)
    //    {
    //        return "Dummy Customer Name";
    //    }
    //}

    //public class DataAccessFactory
    //{
    //    public static ICustomerDataAccess GetCustomerDataAccessObject()
    //    {
    //        return new CustomerDataAccess();
    //    }
    //}
    //public class CustomerBusinessLogic
    //{
    //    ICustomerDataAccess _iCustomerDataAccess;
    //    public CustomerBusinessLogic()
    //    {
    //        _iCustomerDataAccess = DataAccessFactory.GetCustomerDataAccessObject();
    //    }

    //    public string GetCustomerName(int id)
    //    {
    //        return _iCustomerDataAccess.GetCustomerName(id);
    //    }
    //}
    #endregion Implemented IOC and DIP


    #region Implemented IOC, DIP and DI
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _iCustomerDataAccess;
        public CustomerBusinessLogic(ICustomerDataAccess iCustomerDataAccess)
        {
            _iCustomerDataAccess = iCustomerDataAccess;
        }
        public string ProcessCustomerData(int id)
        {
            return _iCustomerDataAccess.GetCustomerName(id);
        }
    }
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public string GetCustomerName(int id)
        {
            return "Dummy customer name";
        }
    }
    //Inject Dependencies
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;
        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.ProcessCustomerData(id);
        }
    }

    #endregion Implemented IOC, DIP and DI
}
