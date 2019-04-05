using System.Data.Entity;
using Custs.DAL.Entities;

namespace Custs.DAL
{
    public interface IDbContext
    {
        DbSet<CustomerEntity> Customers { get; set; }
        DbSet<OrderEntity> Orders { get; set; }

        void commit();
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
    }
}
