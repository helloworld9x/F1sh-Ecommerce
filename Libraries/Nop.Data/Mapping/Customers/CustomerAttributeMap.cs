using F1sh.Core.Domain.Customers;

namespace F1sh.Data.Mapping.Customers
{
    public partial class CustomerAttributeMap : F1shEntityTypeConfiguration<CustomerAttribute>
    {
        public CustomerAttributeMap()
        {
            this.ToTable("CustomerAttribute");
            this.HasKey(ca => ca.Id);
            this.Property(ca => ca.Name).IsRequired().HasMaxLength(400);

            this.Ignore(ca => ca.AttributeControlType);
        }
    }
}