using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using Custs.DAL.Entities;

namespace Custs.DAL
{
    public interface IDbContext
    {
        DbSet<CustomerEntity> Customers { get; set; }
        DbSet<OrderEntity> Orders { get; set; }

        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
    }
}
