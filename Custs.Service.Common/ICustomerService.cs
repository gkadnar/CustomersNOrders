using Custs.Model.Common;
using System.Collections.Generic;

namespace Custs.Service.Common
{
    public interface ICustomerService
    {
        List<ICustomer> GetAllCustomers();
    }
}
