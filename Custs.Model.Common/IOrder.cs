using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custs.Model.Common
{
    interface IOrder
    {
        // Primary key property
        int Id { get; set; }

        // Value properties
        string Name { get; set; }
        int Quantity { get; set; }
        decimal Price { get; set; }

        // Navigation properties
        ICustomer Customer { get; set; }
    }
}
