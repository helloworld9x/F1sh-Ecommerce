//using F1sh.Core.Domain.Catalog;

//namespace F1sh.Data.Mapping.Catalog
//{
//    public partial class CategoryMap : F1shEntityTypeConfiguration<Category>
//    {
//        public CategoryMap()
//        {
//            this.ToTable("Category");
//            this.HasKey(c => c.Id);
//            this.Property(c => c.Name).IsRequired().HasMaxLength(400);
//            this.Property(c => c.PriceRanges).HasMaxLength(400);
//            this.Property(c => c.PageSizeOptions).HasMaxLength(200);
//        }
//    }
//}