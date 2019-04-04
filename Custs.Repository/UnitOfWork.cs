using AutoMapper;
using Custs.DAL;
using Custs.Repository.Common;
using System;

namespace Custs.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _automapper;

        private ICustomerRepository customerRepository;

        public UnitOfWork(IDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._automapper = mapper;
        }

        public ICustomerRepository getCustomerRepository()
        {
            return customerRepository = customerRepository ?? new CustomerRepository(_dbContext, _automapper);
        }

        public void Commit()
        {
            _dbContext.commit();
        }
    }
}
