using System;
using F1sh.Core.Domain.Orders;

namespace F1sh.Core.Domain.Discounts
{
    /// <summary>
    /// Represents a discount usage history entry
    /// </summary>
    public partial class DiscountUsageHistory : BaseEntity
    {
        /// <summary>
        /// Gets or sets the discount identifier
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }


        /// <summary>
        /// Gets or sets the discount
        /// </summary>
        public virtual Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets the order
        /// </summary>
        public virtual Order Order { get; set; }
    }

    public class DiscountUsageHistoryMap : GoqEntityTypeConfiguration<DiscountUsageHistory>
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
