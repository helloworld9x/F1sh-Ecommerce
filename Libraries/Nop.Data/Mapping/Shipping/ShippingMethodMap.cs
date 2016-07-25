using F1sh.Core.Domain.Shipping;

namespace F1sh.Data.Mapping.Shipping
{
    public class ShippingMethodMap : F1shEntityTypeConfiguration<ShippingMethod>
    {
        public ShippingMethodMap()
        {
            this.ToTable("ShippingMethod");
            this.HasKey(sm => sm.Id);
            this.Property(sm => sm.Name).IsRequired().HasMaxLength(400);

            this.HasMany(sm => sm.RestrictedCountries)
                .WithMany(c => c.RestrictedShippingMethods)
                .Map(m => m.ToTable("ShippingMethodRestrictions"));
        }
    }
}
