using ECL.Common;
using System;
using System.Data.Entity;

namespace ECL.DataAccess
{
    public interface IDbContext
    {
        IDbSet<TEntity> set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
