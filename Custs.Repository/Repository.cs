using AutoMapper;
using Custs.DAL;
using Custs.DAL.Entities;
using Custs.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net.Http;
using System.Threading.Tasks;
using Custs.Common.Filters;
using System.Linq;

namespace Custs.Repository
{
    public abstract class Repository<T, TEntity> : IRepository<T> where T : class where TEntity: BaseEntity
    {
        protected readonly IUnitOfWork _uow;
        private readonly IMapper _automapper;
        protected readonly IDbSet<TEntity> dbSet;

        protected Repository(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._automapper = mapper;
            dbSet = ((UnitOfWork)_uow).DbContext.Set<TEntity>();
        }

        /// <summary>
        /// Asynchronously insert a new T to database.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Number of created entities.</returns>
        public async Task<int> AddAsync(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                var tentity = _automapper.Map<TEntity>(entity);
                await _uow.AddAsync(tentity);
            }
            return await _uow.CommitAsync();
        }

        /// <summary>
        /// Asynchronously get all T from database.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var dbresG = await dbSet.ToListAsync();
            return _automapper.Map<IEnumerable<T>>(dbresG);
        }

        /// <summary>
        /// Asynchronously get T by Id from database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(long id)
        {
            var entity = await dbSet.FirstOrDefaultAsync(x=> x.Id == id);
            var model = _automapper.Map<T>(entity);
            return model;
        }

        /// <summary>
        /// Asynchronously delete T by Id from database.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(IEnumerable<long> ids)
        {
            foreach (long id in ids)
            {
                await _uow.DeleteAsync<TEntity>(id);
            }
            return await _uow.CommitAsync();
        }

        /// <summary>
        /// Asynchronously update T by Id from database.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(T entity, int id)
        {
            var tentity = dbSet.Find(id);
            tentity = _automapper.Map<T, TEntity>(entity, tentity);
            tentity.Id = id;
            await _uow.UpdateAsync<TEntity>(tentity);
            return await _uow.CommitAsync();
        }

    }
}
