namespace F1sh.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a related product
    /// </summary>
    public class RelatedProduct : BaseEntity
    {
        /// <summary>
        /// Gets or sets the first product identifier
        /// </summary>
        public int ProductId1 { get; set; }

        /// <summary>
        /// Gets or sets the second product identifier
        /// </summary>
        public int ProductId2 { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }

    public  class RelatedProductMap : GoqEntityTypeConfiguration<RelatedProduct>
    {
        public RelatedProductMap()
        {
            ToTable("RelatedProduct");
            HasKey(c => c.Id);
        }
    }
}
