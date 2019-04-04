using Custs.Model.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Custs.Service.Common
{
    public interface ICustomerService
    {
        Task<IEnumerable<ICustomer>> GetAllCustomers();
    }
}
