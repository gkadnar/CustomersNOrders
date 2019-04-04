using AutoMapper;
using Custs.DAL;
using Custs.Repository.Common;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<T>> GetAll()
        {
            //var res1 = _automapper.Map<IEnumerable<T>>(_dbContext.Customers.ToList());
            //return res1;

            var dbres = await _dbContext.Customers.ToListAsync();
            return _automapper.Map<IEnumerable<T>>(dbres);
        }
    }
}
