//using F1sh.Core.Domain.Customers;

//namespace F1sh.Data.Mapping.Customers
//{
//    public class RewardPointsHistoryMap : F1shEntityTypeConfiguration<RewardPointsHistory>
//    {
//        public RewardPointsHistoryMap()
//        {
//            this.ToTable("RewardPointsHistory");
//            this.HasKey(rph => rph.Id);

//            this.Property(rph => rph.UsedAmount).HasPrecision(18, 4);

//            this.HasRequired(rph => rph.Customer)
//                .WithMany()
//                .HasForeignKey(rph => rph.CustomerId);

//            this.HasOptional(rph => rph.UsedWithOrder)
//                .WithOptionalDependent(o => o.RedeemedRewardPointsEntry)
//                .WillCascadeOnDelete(false);
//        }
//    }
//}