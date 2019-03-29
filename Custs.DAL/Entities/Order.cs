using Custs.DAL.Entities;

namespace Custs.DAL
{
    public class OrderEntity : BaseEntity
    {
        // Value properties
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation properties - represents relationships
        //public int CustomerId;
        public virtual CustomerEntity Customer { get; set; }
    }
}
