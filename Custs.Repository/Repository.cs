using AutoMapper;
using Custs.DAL;
using Custs.Repository.Common;
using System.Collections.Generic;
using System.Linq;

namespace Custs.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _automapper;

        protected Repository(IDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._automapper = mapper;
        }

        public virtual IEnumerable<T> GetAll()
        {
            var res1 = _automapper.Map<IEnumerable<T>>(_dbContext.Customers.ToList());
            return res1;
        }
    }
}
