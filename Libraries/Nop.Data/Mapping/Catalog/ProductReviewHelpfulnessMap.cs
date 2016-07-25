//using F1sh.Core.Domain.Catalog;

//namespace F1sh.Data.Mapping.Catalog
//{
//    public partial class ProductReviewHelpfulnessMap : F1shEntityTypeConfiguration<ProductReviewHelpfulness>
//    {
//        public ProductReviewHelpfulnessMap()
//        {
//            this.ToTable("ProductReviewHelpfulness");
//            this.HasKey(pr => pr.Id);

//            this.HasRequired(prh => prh.ProductReview)
//                .WithMany(pr => pr.ProductReviewHelpfulnessEntries)
//                .HasForeignKey(prh => prh.ProductReviewId).WillCascadeOnDelete(true);
//        }
//    }
//}