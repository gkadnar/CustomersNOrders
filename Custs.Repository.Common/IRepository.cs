using Custs.DAL.Entities;
using Custs.Model.Common;
using System.Collections.Generic;

namespace Custs.Repository.Common
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
