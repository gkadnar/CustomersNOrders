using Custs.DAL;
using Custs.Model.Common;
using Custs.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Custs.Repository
{
    public class Repository : IRepository
    {
        private readonly IDbContext _context;

        public Repository(IDbContext context)
        {
            this._context = context;
        }

        public List<ICustomer> GetAllCustomers()
        {
            return new List<ICustomer>((List<ICustomer>)AutoMapper.Mapper.Map<IEnumerable<CustomerEntity>>(_context.Customers));
        }
    }

}
