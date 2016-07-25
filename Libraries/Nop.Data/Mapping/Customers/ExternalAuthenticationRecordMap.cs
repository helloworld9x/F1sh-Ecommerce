//using F1sh.Core.Domain.Customers;

//namespace F1sh.Data.Mapping.Customers
//{
//    public partial class ExternalAuthenticationRecordMap : F1shEntityTypeConfiguration<ExternalAuthenticationRecord>
//    {
//        public ExternalAuthenticationRecordMap()
//        {
//            this.ToTable("ExternalAuthenticationRecord");

//            this.HasKey(ear => ear.Id);

//            this.HasRequired(ear => ear.Customer)
//                .WithMany(c => c.ExternalAuthenticationRecords)
//                .HasForeignKey(ear => ear.CustomerId);

//        }
//    }
//}