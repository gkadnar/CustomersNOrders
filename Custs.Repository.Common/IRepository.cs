using Custs.Model.Common;
using System.Collections.Generic;

namespace Custs.Repository.Common
{
    public interface IRepository
    {
        List<ICustomer> GetAllCustomers();
    }
}
