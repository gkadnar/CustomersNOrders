using Custs.Model.Common;

namespace Custs.Model
{
    public class Order : IOrder
    {
        // Primary key property
        public int Id { get; set; }

        // Value properties
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation properties - represents relationships
        public ICustomer Customer { get; set; }
    }
}
