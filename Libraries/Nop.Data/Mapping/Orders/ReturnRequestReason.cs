using F1sh.Core.Domain.Orders;

namespace F1sh.Data.Mapping.Orders
{
    public partial class ReturnRequestReasonMap : F1shEntityTypeConfiguration<ReturnRequestReason>
    {
        public ReturnRequestReasonMap()
        {
            this.ToTable("ReturnRequestReason");
            this.HasKey(rrr => rrr.Id);
            this.Property(rrr => rrr.Name).IsRequired().HasMaxLength(400);
        }
    }
}