using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custs.Model.Common
{
    interface ICustomer
    {
        // Primary key property
        int Id { get; set; }

        // Value properties
        string Name { get; set; }
        string Email { get; set; }

        // Navigation properties
        IList<IOrder> Orders { get; set; }
    }
}
