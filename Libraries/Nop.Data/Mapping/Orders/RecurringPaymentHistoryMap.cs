using F1sh.Core.Domain.Orders;

namespace F1sh.Data.Mapping.Orders
{
    public partial class RecurringPaymentHistoryMap : F1shEntityTypeConfiguration<RecurringPaymentHistory>
    {
        public RecurringPaymentHistoryMap()
        {
            this.ToTable("RecurringPaymentHistory");
            this.HasKey(rph => rph.Id);

            this.HasRequired(rph => rph.RecurringPayment)
                .WithMany(rp => rp.RecurringPaymentHistory)
                .HasForeignKey(rph => rph.RecurringPaymentId);

            //entity framework issue if we have navigation property to 'Order'
            //1. save recurring payment with an order
            //2. save recurring payment history with an order
            //3. update associated order => exception is thrown
        }
    }
}