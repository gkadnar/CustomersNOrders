namespace Custs.Model.Common
{
    public interface IOrder
    {
        // Primary key property
        int Id { get; set; }

        // Value properties
        string Name { get; set; }
        int Quantity { get; set; }
        decimal Price { get; set; }

        // Navigation properties - represents relationships
        ICustomer Customer { get; set; }
    }
}
