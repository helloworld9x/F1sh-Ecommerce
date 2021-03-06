namespace F1sh.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a cross-sell product
    /// </summary>
    public class CrossSellProduct : BaseEntity
    {
        /// <summary>
        /// Gets or sets the first product identifier
        /// </summary>
        public int ProductId1 { get; set; }

        /// <summary>
        /// Gets or sets the second product identifier
        /// </summary>
        public int ProductId2 { get; set; }
    }

    public class CrossSellProductMap : GoqEntityTypeConfiguration<CrossSellProduct>
    {
        public CrossSellProductMap()
        {
            ToTable("CrossSellProduct");
            HasKey(c => c.Id);
        }
    }

}
