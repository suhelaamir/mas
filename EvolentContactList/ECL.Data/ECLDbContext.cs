using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using ECL.Common;
using System.Reflection;

namespace ECL.DataAccess
{
    public class ECLDbContext : DbContext, IDbContext
    {
        public ECLDbContext(): base("name=DbConnectionString")
        { }
        public IDbSet<TEntity> set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typeToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrWhiteSpace(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typeToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
