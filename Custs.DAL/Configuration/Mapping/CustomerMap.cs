using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Custs.DAL.Configuration.Mapping
{
    class CustomerMap : EntityTypeConfiguration<CustomerEntity>
    {
        public CustomerMap()
        {
            // Primary key
            HasKey(t => t.Id);                                                                              

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);               // DB will auto-increment PK
            Property(t => t.Name).IsRequired();                                                             // Name is not-null
            Property(t => t.Email).IsRequired();                                                            // Email is not-null

            // Table
            ToTable("Customers");
        }
    }
}
