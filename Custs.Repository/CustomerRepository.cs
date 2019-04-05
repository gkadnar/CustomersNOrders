using AutoMapper;
using Custs.DAL;
using Custs.Model.Common;
using Custs.Repository.Common;
using System.Data.Entity;

namespace Custs.Repository
{
    public class CustomerRepository : Repository<ICustomer,CustomerEntity>, ICustomerRepository
    {
        
        public CustomerRepository(IDbContext context, IMapper mapper) : base(context,mapper)
        {
        }

    }

}
