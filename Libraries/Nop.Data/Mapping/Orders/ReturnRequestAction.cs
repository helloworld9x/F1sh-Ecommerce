using F1sh.Core.Domain.Orders;

namespace F1sh.Data.Mapping.Orders
{
    public partial class ReturnRequestActionMap : F1shEntityTypeConfiguration<ReturnRequestAction>
    {
        public ReturnRequestActionMap()
        {
            this.ToTable("ReturnRequestAction");
            this.HasKey(rra => rra.Id);
            this.Property(rra => rra.Name).IsRequired().HasMaxLength(400);
        }
    }
}