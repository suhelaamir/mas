using ECL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECL.DataAccess
{
    /// <summary>
    /// This is higher level module
    /// dependency inversion principle: Higher level module creates Interface
    /// Lower level module will implement it
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T: BaseEntity
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
