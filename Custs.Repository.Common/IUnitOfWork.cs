using Custs.DAL;
using Custs.DAL.Entities;
using System;
using System.Threading.Tasks;

namespace Custs.Repository.Common
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
        Task<int> AddAsync<T>(T entity) where T : BaseEntity;
        Task<int> DeleteAsync<T>(long id) where T : BaseEntity;
        Task<int> UpdateAsync<T>(T entity) where T : BaseEntity;
    }
}
