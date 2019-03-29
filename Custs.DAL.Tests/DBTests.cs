using System;
using System.Collections.Generic;
using System.Data.Entity;
using Xunit;

namespace Custs.DAL.Tests
{
    public class DBTests
    {

        [Fact]
        public void CreateCustomersAndOrders()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
            using (var context = new EFDbContext())
            {
                context.Database.CreateIfNotExists();
                CustomerEntity customer = new CustomerEntity
                {
                    Name = "Goran Kadnar",
                    Email = "gkadnar@test.com",
                    Orders = new List<OrderEntity>{
                                            new OrderEntity
                                            {
                                                Name = "PrviOrder",
                                                Quantity =12,
                                                Price =15
                                            },
                                            new OrderEntity
                                            {
                                                Name = "DrugiOrder",
                                                Quantity =10,
                                                Price =25
                                            }
                                        }
                };
                context.Entry(customer).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
