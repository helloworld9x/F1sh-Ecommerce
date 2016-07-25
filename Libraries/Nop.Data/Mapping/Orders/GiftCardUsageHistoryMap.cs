
//using F1sh.Core.Domain.Orders;

//namespace F1sh.Data.Mapping.Orders
//{
//    public partial class GiftCardUsageHistoryMap : F1shEntityTypeConfiguration<GiftCardUsageHistory>
//    {
//        public GiftCardUsageHistoryMap()
//        {
//            this.ToTable("GiftCardUsageHistory");
//            this.HasKey(gcuh => gcuh.Id);
//            this.Property(gcuh => gcuh.UsedValue).HasPrecision(18, 4);
//            //this.Property(gcuh => gcuh.UsedValueInCustomerCurrency).HasPrecision(18, 4);

//            this.HasRequired(gcuh => gcuh.GiftCard)
//                .WithMany(gc => gc.GiftCardUsageHistory)
//                .HasForeignKey(gcuh => gcuh.GiftCardId);

//            this.HasRequired(gcuh => gcuh.UsedWithOrder)
//                .WithMany(o => o.GiftCardUsageHistory)
//                .HasForeignKey(gcuh => gcuh.UsedWithOrderId);
//        }
//    }
//}