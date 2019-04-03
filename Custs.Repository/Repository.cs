using AutoMapper;
using Custs.DAL;
using Custs.Model.Common;
using Custs.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Custs.Repository
{
    public class Repository : IRepository
    {
        
        private readonly IDbContext _context;

        private readonly IMapper _automapper;

        public Repository(IDbContext context, IMapper mapper)
        {
            this._context = context;
            this._automapper = mapper;
        }

        public List<ICustomer> GetAllCustomers()
        {
            var tmp2 = _context.Customers.ToList();

            var tmp3 = _automapper.Map<IEnumerable<ICustomer>>(tmp2);

            return new List<ICustomer>(tmp3);
            //return new List<ICustomer>((List<ICustomer>)_automapper.Map<IEnumerable<CustomerEntity>>(_context.Customers.ToList()));
        }
    }

}
