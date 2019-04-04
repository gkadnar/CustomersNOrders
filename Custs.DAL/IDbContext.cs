using System.Data.Entity;

namespace Custs.DAL
{
    public interface IDbContext
    {
        DbSet<CustomerEntity> Customers { get; set; }
        DbSet<OrderEntity> Orders { get; set; }

        void commit();
    }
}
