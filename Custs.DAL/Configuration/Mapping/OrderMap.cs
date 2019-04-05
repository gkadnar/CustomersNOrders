using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custs.DAL.Configuration.Mapping
{
    class OrderMap : EntityTypeConfiguration<OrderEntity>
    {
        public OrderMap()
        {
            // Primary key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);               // DB will auto-increment PK
            Property(t => t.Name).IsRequired();                                                             // Name is not-null
            Property(t => t.Quantity).IsRequired();                                                         // Quantity is not-null
            Property(t => t.Price).IsRequired();                                                            // Quantity is not-null
            //Property(t => t.CustomerId).IsRequired();                                                       // CustomerId FK is mandatory

            // Table
            ToTable("Orders");

            // Relationships
            HasRequired(t => t.Customer).WithMany(c => c.Orders).WillCascadeOnDelete(true);

            // HasRequired indicates that CustomerFK is mandatory for each Order.
            // WithMany indicates which navigation property in Customer entity contains the Many relationship.
            // WillCascadeOnDelete configures whether or not cascade delete is on for the relationship.
        }
    }
}
