using F1sh.Core.Domain.Localization;

namespace F1sh.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product attribute
    /// </summary>
    public class ProductAttribute : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }
    }

    public class ProductAttributeMap : GoqEntityTypeConfiguration<ProductAttribute>
    {
        public ProductAttributeMap()
        {
            ToTable("ProductAttribute");
            HasKey(pa => pa.Id);
            Property(pa => pa.Name).IsRequired();
        }
    }
}
