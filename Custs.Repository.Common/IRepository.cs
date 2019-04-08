using Custs.DAL.Entities;
using Custs.Model.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Custs.Repository.Common
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(long id);
        void Delete(long id);
        void Add(T entity);
        void Update(T entity, long id);
    }
}
