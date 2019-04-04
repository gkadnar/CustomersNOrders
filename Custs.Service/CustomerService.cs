using Custs.Model.Common;
using Custs.Service.Common;
using System.Collections.Generic;
using System.Linq;
using Custs.Repository.Common;

namespace Custs.Service
{
    public class CustomerService : ICustomerService
    {
        
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            this._repository = repository;
        }

        public List<ICustomer> GetAllCustomers()
        {
            return _repository.GetAll().ToList();
        }

        public string GetTest()
        {
            return "gkadnar";
        }
    }
}