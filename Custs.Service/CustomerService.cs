using Custs.Model.Common;
using Custs.Repository.Common;
using Custs.Service.Common;
using System.Collections.Generic;

namespace Custs.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository _repository;

        public CustomerService(IRepository repository)
        {
            this._repository = repository;
        }

        public List<ICustomer> GetAllCustomers()
        {
            return _repository.GetAllCustomers();
        }
    }
}