using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Custs.DAL.Tests
{
    public class DBTests
    {
        private readonly ITestOutputHelper output;

        public DBTests(ITestOutputHelper output)
        {
            this.output = output;
        }
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

        [Fact]
        public void ReadAllCustomers()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
            using (var context = new EFDbContext())
            {
                context.Database.CreateIfNotExists();

                List<CustomerEntity> custs = context.Customers.ToList();

                context.SaveChanges();
                
                output.WriteLine("Read all customers ==> " + custs);
                foreach(CustomerEntity c in custs)
                {
                    output.WriteLine("c ==> " + c.Id);
                }
            }
        }

    }
}
