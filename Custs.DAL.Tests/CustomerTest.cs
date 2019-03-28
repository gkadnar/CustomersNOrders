using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Custs.DAL.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomerOrderTest()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
            using (var context = new EFDbContext())
            {
                context.Database.Create();
                CustomerEntity customer = new CustomerEntity
                {
                    Name = "Raviendra",
                    Email = "raviendra@test.com",
                    Orders = new List<OrderEntity>{
                                            new OrderEntity
                                            {
                                                Quantity = 12,
                                                Price =15,
                                            },
                                            new OrderEntity
                                            {
                                                Quantity =10,
                                                Price =25,
                                            }
                                        }
                };
                //context.Entry(customer).State = System.Data.EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
