using AutoMapper;
using Custs.DAL;
using Custs.DAL.Entities;
using Custs.Repository.Common;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace Custs.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbContext DbContext;

        public UnitOfWork(IDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public Task<int> AddAsync<T>(T entity) where T : BaseEntity
        {
            try
            {
                DbEntityEntry dbEntityEntry = ((DbContext)DbContext).Entry(entity);
                if (dbEntityEntry.State != EntityState.Detached)
                {
                    dbEntityEntry.State = EntityState.Added;
                }
                else
                {
                    DbContext.Set<T>().Add(entity);
                }
                return Task.FromResult(1);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<int> DeleteAsync<T>(long id) where T : BaseEntity
        {
            var entity = DbContext.Set<T>().Find(id);
            if (entity == null)
            {
                return Task.FromResult(0);
            }
            return DeleteAsync<T>(entity);
        }

        public Task<int> DeleteAsync<T>(T entity) where T : BaseEntity
        {
            DbEntityEntry dbEntityEntry = ((DbContext)DbContext).Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbContext.Set<T>().Attach(entity);
                DbContext.Set<T>().Remove(entity);
            }
            return Task.FromResult(1);
        }

        public Task<int> UpdateAsync<T>(T entity) where T : BaseEntity
        {
            DbEntityEntry dbEntityEntry = ((DbContext)DbContext).Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbContext.Set<T>().Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;

            return Task.FromResult(1);
        }

        public async Task<int> CommitAsync()
        {
            return await ((DbContext)DbContext).SaveChangesAsync();
        }

    }
}
