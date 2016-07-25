using System.Collections.Generic;
using F1sh.Core.Domain.Localization;

namespace F1sh.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product tag
    /// </summary>
    public class ProductTag : BaseEntity, ILocalizedEntity
    {
        private ICollection<Product> _products;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the products
        /// </summary>
        public virtual ICollection<Product> Products
        {
            get { return _products ?? (_products = new List<Product>()); }
            protected set { _products = value; }
        }
    }
    public class ProductTagMap : GoqEntityTypeConfiguration<ProductTag>
    {
        public ProductTagMap()
        {
            ToTable("ProductTag");
            HasKey(pt => pt.Id);
            Property(pt => pt.Name).IsRequired().HasMaxLength(400);
        }
    }
}
