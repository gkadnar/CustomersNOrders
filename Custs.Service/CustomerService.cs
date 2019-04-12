using Custs.Model.Common;
using Custs.Service.Common;
using System.Collections.Generic;
using Custs.Repository.Common;
using System.Threading.Tasks;
using System;
using Custs.Common.Filters;

namespace Custs.Service
{
    public class CustomerService : ICustomerService
    {
        
        private readonly ICustomerRepository CustomerRepository;

        public CustomerService(ICustomerRepository CustomerRepository)
        {
            this.CustomerRepository = CustomerRepository;
        }

        public async Task<IEnumerable<ICustomer>> GetAllCustomersAsync()
        {
            return await CustomerRepository.GetAllAsync();
        }

        public async Task<IEnumerable<ICustomer>> GetAllCustomersAsync(CustomersFilter filter)
        {
            return await CustomerRepository.GetAllAsync(filter);
        }

        public async Task<ICustomer> GetCustomerByIdAsync(long id)
        {
            return await CustomerRepository.GetByIdAsync(id);
        }

        public async Task<int> DeleteCustomerByIdAsync(IEnumerable<long> ids)
        {
            var res = await CustomerRepository.DeleteAsync(ids);
            return res;
        }

        public async Task<int> CreateCustomerAsync(IEnumerable<ICustomer> customers)
        {
            var res =  await CustomerRepository.AddAsync(customers);
            return res;
        }

        public async Task<int> UpdateCustomerAsync(int id,ICustomer customer)
        {
            var res =  await CustomerRepository.UpdateAsync(customer, id);
            return res;
        }

    }
}