using System.Collections.Generic;

namespace Custs.Model.Common
{
    public interface ICustomer
    {
        // Primary key property
        int Id { get; set; }

        // Value properties
        string Name { get; set; }
        string Email { get; set; }

        // Navigation properties - represents relationships
        List<IOrder> Orders { get; set; }
    }
}
