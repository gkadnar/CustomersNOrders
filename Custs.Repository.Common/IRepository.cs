using Custs.Common.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Custs.Repository.Common
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Asynchronously insert a new T to database.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>Number of created entities.</returns>
        Task<int> AddAsync(IEnumerable<T> entities);

        /// <summary>
        /// Asynchronously get all T from database.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Asynchronously get T by Id from database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(long id);

        /// <summary>
        /// Asynchronously delete T by Id from database.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(IEnumerable<long> ids);

        /// <summary>
        /// Asynchronously update T by Id from database.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> UpdateAsync(T entity, int id);
    }
}
