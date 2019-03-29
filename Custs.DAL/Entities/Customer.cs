using Custs.DAL.Entities;
using System.Collections.Generic;

namespace Custs.DAL
{
    public class CustomerEntity : BaseEntity
    {
        // Value properties
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation properties - represents relationships
        public virtual List<OrderEntity> Orders { get; set; }
    }
}
