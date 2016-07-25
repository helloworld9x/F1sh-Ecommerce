
namespace F1sh.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product template
    /// </summary>
    public class ProductTemplate : BaseEntity
    {
        /// <summary>
        /// Gets or sets the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the view path
        /// </summary>
        public string ViewPath { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }
    public class ProductTemplateMap : GoqEntityTypeConfiguration<ProductTemplate>
    {
        public ProductTemplateMap()
        {
            ToTable("ProductTemplate");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(400);
            Property(p => p.ViewPath).IsRequired().HasMaxLength(400);
        }
    }
}
