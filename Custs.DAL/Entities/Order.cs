namespace Custs.DAL
{
    public class OrderEntity
    {
        // Primary key property
        public int Id { get; set; }

        // Value properties
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation properties - represents relationships
        public int CustomerId;
        public CustomerEntity Customer { get; set; }
    }
}
