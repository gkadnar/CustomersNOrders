using System.Collections.Generic;

namespace Custs.DAL
{
    public class CustomerEntity
    {
        // Primary key property
        public int Id { get; set; }

        // Value properties
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation properties - represents relationships
        public List<OrderEntity> Orders { get; set; }
    }
}
