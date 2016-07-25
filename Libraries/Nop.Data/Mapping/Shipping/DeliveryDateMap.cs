using F1sh.Core.Domain.Shipping;

namespace F1sh.Data.Mapping.Shipping
{
    public class DeliveryDateMap : F1shEntityTypeConfiguration<DeliveryDate>
    {
        public DeliveryDateMap()
        {
            this.ToTable("DeliveryDate");
            this.HasKey(dd => dd.Id);
            this.Property(dd => dd.Name).IsRequired().HasMaxLength(400);
        }
    }
}
