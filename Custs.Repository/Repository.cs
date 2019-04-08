using AutoMapper;
using Custs.DAL;
using Custs.DAL.Entities;
using Custs.Repository.Common;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Custs.Repository
{
    public abstract class Repository<T, TEntity> : IRepository<T> where T : class where TEntity: BaseEntity
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _automapper;
        private readonly IDbSet<TEntity> dbSet;

        protected Repository(IDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._automapper = mapper;
            dbSet = _dbContext.Set<TEntity>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            //var dbres = await _dbContext.Customers.ToListAsync();
            //return _automapper.Map<IEnumerable<T>>(dbres);

            var dbresG = await dbSet.ToListAsync();
            return _automapper.Map<IEnumerable<T>>(dbresG);
        }

        public Task<T> GetById(long id)
        {
            var a =  dbSet.Find(id);
            var b = _automapper.Map<T>(a);
            return Task.FromResult(b);
        }

        public void Delete(long id)
        {
            //var customer = await _repository.GetById(id);
            dbSet.Remove(dbSet.Find(id));
            //return await ((DbContext)_dbContext).SaveChangesAsync();
            ((DbContext)_dbContext).SaveChanges();
        }

        public void Add(T entity)
        {
            var tentity = _automapper.Map<TEntity>(entity);
            dbSet.Add(tentity);
            ((DbContext)_dbContext).SaveChanges();
        }

        public void Update(T entity, long id)
        {
            var tentity = dbSet.Find(id);
            tentity = _automapper.Map<T, TEntity>(entity, tentity);
            ((DbContext)_dbContext).SaveChanges();
        }
    }
}
