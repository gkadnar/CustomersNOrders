using Custs.Model.Common;
using Custs.Service.Common;
using System.Collections.Generic;
using Custs.Repository.Common;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<ICustomer>> GetAllCustomers()
        {
            return await _repository.GetAll();
        }

        public async Task<ICustomer> GetCustomerById(long id)
        {
            return await _repository.GetById(id);
        }

        public void DeleteCustomerById(long id)
        {
            _repository.Delete(id);
        }

        public string GetTest()
        {
            return "gkadnar";
        }
    }
}