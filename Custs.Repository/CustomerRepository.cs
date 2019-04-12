using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Custs.Common.Filters;
using Custs.DAL;
using Custs.Model.Common;
using Custs.Repository.Common;

namespace Custs.Repository
{
    public class CustomerRepository : Repository<ICustomer,CustomerEntity>, ICustomerRepository
    {
        
        public CustomerRepository(IUnitOfWork uow, IMapper mapper) : base(uow,mapper)
        {
        }

        
        public async Task<IEnumerable<ICustomer>> GetAllAsync(CustomersFilter filter)
        {
            /*
            return  await ((UnitOfWork)base._uow).DbContext.Customers
                .Where(item => String.IsNullOrEmpty(filter.SearchCustomer) ? item != null : item.Name.Contains(filter.SearchCustomer))
                .OrderBy(item => filter.Ordering)
                .ToPagedListAsync();
            throw new System.NotImplementedException();
            */
            return null;
        }
    }

}
