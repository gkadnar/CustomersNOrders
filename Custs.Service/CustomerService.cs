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
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerRepository repository, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._repository = _unitOfWork.getCustomerRepository();
            
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