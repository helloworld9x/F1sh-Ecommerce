using F1sh.Core.Domain.Shipping;

namespace F1sh.Data.Mapping.Shipping
{
    public class WarehouseMap : F1shEntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            this.ToTable("Warehouse");
            this.HasKey(wh => wh.Id);
            this.Property(wh => wh.Name).IsRequired().HasMaxLength(400);
        }
    }
}
