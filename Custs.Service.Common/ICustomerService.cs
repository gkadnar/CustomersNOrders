using Custs.Common.Filters;
using Custs.Model.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Custs.Service.Common
{
    public interface ICustomerService
    {
        Task<int> CreateCustomerAsync(IEnumerable<ICustomer> customers);
        Task<IEnumerable<ICustomer>> GetAllCustomersAsync();
        Task<IEnumerable<ICustomer>> GetAllCustomersAsync(CustomersFilter filter);
        Task<ICustomer> GetCustomerByIdAsync(long id);
        Task<int> UpdateCustomerAsync(int id, ICustomer customer);
        Task<int> DeleteCustomerByIdAsync(IEnumerable<long> id);
    }
}
