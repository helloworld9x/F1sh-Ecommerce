using Nop.Core.Domain.Discounts;

namespace Nop.Data.Mapping.Discounts
{
    public class DiscountUsageHistoryMap : NopEntityTypeConfiguration<DiscountUsageHistory>
    {
        public DiscountUsageHistoryMap()
        {
            ToTable("DiscountUsageHistory");
            HasKey(duh => duh.Id);
            
            HasRequired(duh => duh.Discount)
                .WithMany()
                .HasForeignKey(duh => duh.DiscountId);

            HasRequired(duh => duh.Order)
                .WithMany(o => o.DiscountUsageHistory)
                .HasForeignKey(duh => duh.OrderId);
        }
    }
}