using AutoMapper;
using Custs.DAL;
using Custs.Model.Common;
using Custs.Repository.Common;

namespace Custs.Repository
{
    public class CustomerRepository : Repository<ICustomer>, ICustomerRepository
    {
        
        //private readonly IDbContext _context;
        //private readonly IMapper _automapper;

        public CustomerRepository(IDbContext context, IMapper mapper) : base(context,mapper)
        {
          //  this._context = context;
            //this._automapper = mapper;
        }

    }

}
