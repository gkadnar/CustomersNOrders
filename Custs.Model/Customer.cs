using System.Collections.Generic;
using Custs.Model.Common;

namespace Custs.Model
{
    public class Customer : ICustomer
    {
        // Primary key property
        public int Id { get; set; }

        // Value properties
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation properties - represents relationships
        public List<IOrder> Orders { get; set; }
    }
}
