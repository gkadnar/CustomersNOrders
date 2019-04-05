using Custs.Model.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Custs.Service.Common
{
    public interface ICustomerService
    {
        Task<IEnumerable<ICustomer>> GetAllCustomers();
        Task<ICustomer> GetCustomerById(long id);
        void DeleteCustomerById(long id);
    }
}
