using ECL.Common;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace ECL.DataAccess
{
    /// <summary>
    /// This is lower level module
    /// dependency inversion principle: Higher level module creates Interface
    /// Lower level module will implement it
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Using Inversion Of Control pattern
        /// for both high level and lower level module should depend on abstraction layer
        /// Using Dependency Injection: Constructor Dependency Ijnection
        /// </summary>
        private readonly IDbContext _context;
        private IDbSet<T> _entities;
        public Repository(IDbContext context)
        {
            this._context = context;
        }
        #region Implement IRepository
        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }
        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.set<T>();
                }
                return _entities;
            }
        }
        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                this._context.SaveChanges();
            }
            catch (DbEntityValidationException dbex)
            {
                var msgError = string.Empty;
                foreach (var validateErrors in dbex.EntityValidationErrors)
                {
                    foreach (var validationError in validateErrors.ValidationErrors)
                    {
                        msgError += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }
                var failed = new Exception(msgError, dbex);
                throw failed;
            }
        }
        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this._context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }
        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Remove(entity);
                this._context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        msg += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }
        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }
        #endregion Implement IRepository
    }
}
