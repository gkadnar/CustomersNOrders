using Custs.Common.Filters;
using Custs.Model.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Custs.Repository.Common
{
    public interface ICustomerRepository : IRepository<ICustomer>
    {
        Task<IEnumerable<ICustomer>> GetAllAsync(CustomersFilter filter);
    }
}
