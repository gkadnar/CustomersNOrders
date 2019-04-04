using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custs.Repository.Common
{
    public interface IUnitOfWork
    {
        ICustomerRepository getCustomerRepository();
        void Commit();
    }
}
