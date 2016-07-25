using F1sh.Core.Domain.Tax;

namespace F1sh.Data.Mapping.Tax
{
    public class TaxCategoryMap : F1shEntityTypeConfiguration<TaxCategory>
    {
        public TaxCategoryMap()
        {
            this.ToTable("TaxCategory");
            this.HasKey(tc => tc.Id);
            this.Property(tc => tc.Name).IsRequired().HasMaxLength(400);
        }
    }
}
