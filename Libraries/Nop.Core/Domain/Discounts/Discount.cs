using System;
using System.Collections.Generic;
using F1sh.Core.Domain.Catalog;

namespace F1sh.Core.Domain.Discounts
{
    /// <summary>
    /// Represents a discount
    /// </summary>
    public class Discount : BaseEntity
    {
        private ICollection<Category> _appliedToCategories;
        private ICollection<Product> _appliedToProducts;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the discount type identifier
        /// </summary>
        public int DiscountTypeId { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether to use percentage
        /// </summary>
        public bool UsePercentage { get; set; }

        /// <summary>
        /// Gets or sets the discount percentage
        /// </summary>
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or sets the discount amount
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the maximum discount amount (used with "UsePercentage")
        /// </summary>
        public decimal? MaximumDiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the discount start date and time
        /// </summary>
        public DateTime? StartDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the discount end date and time
        /// </summary>
        public DateTime? EndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether discount requires coupon code
        /// </summary>
        public bool RequiresCouponCode { get; set; }

        /// <summary>
        /// Gets or sets the coupon code
        /// </summary>
        public string CouponCode { get; set; }

        /// <summary>
        /// Gets or sets the discount limitation identifier
        /// </summary>
        public int DiscountLimitationId { get; set; }

        /// <summary>
        /// Gets or sets the discount limitation times (used when Limitation is set to "N Times Only" or "N Times Per Customer")
        /// </summary>
        public int LimitationTimes { get; set; }

        /// <summary>
        /// Gets or sets the maximum product quantity which could be discounted
        /// Used with "Assigned to products" or "Assigned to categories" type
        /// </summary>
        public int? MaximumDiscountedQuantity { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether it should be applied to all subcategories or the selected one
        /// Used with "Assigned to categories" type only.
        /// </summary>
        public bool AppliedToSubCategories { get; set; }

        /// <summary>
        /// Gets or sets the discount type
        /// </summary>
        public DiscountType DiscountType
        {
            get
            {
                return (DiscountType)DiscountTypeId;
            }
            set
            {
                DiscountTypeId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the discount limitation
        /// </summary>
        public DiscountLimitationType DiscountLimitation
        {
            get
            {
                return (DiscountLimitationType)DiscountLimitationId;
            }
            set
            {
                DiscountLimitationId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the categories
        /// </summary>
        public virtual ICollection<Category> AppliedToCategories
        {
            get { return _appliedToCategories ?? (_appliedToCategories = new List<Category>()); }
            protected set { _appliedToCategories = value; }
        }
        
        /// <summary>
        /// Gets or sets the products 
        /// </summary>
        public virtual ICollection<Product> AppliedToProducts
        {
            get { return _appliedToProducts ?? (_appliedToProducts = new List<Product>()); }
            protected set { _appliedToProducts = value; }
        }
    }

    public class DiscountMap : GoqEntityTypeConfiguration<Discount>
    {
        public DiscountMap()
        {
            ToTable("Discount");
            HasKey(d => d.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(200);
            Property(d => d.CouponCode).HasMaxLength(100);
            Property(d => d.DiscountPercentage).HasPrecision(18, 4);
            Property(d => d.DiscountAmount).HasPrecision(18, 4);
            Property(d => d.MaximumDiscountAmount).HasPrecision(18, 4);

            Ignore(d => d.DiscountType);
            Ignore(d => d.DiscountLimitation);

            HasMany(dr => dr.AppliedToCategories)
                .WithMany(c => c.AppliedDiscounts)
                .Map(m => m.ToTable("Discount_AppliedToCategories"));

            HasMany(dr => dr.AppliedToProducts)
                .WithMany(p => p.AppliedDiscounts)
                .Map(m => m.ToTable("Discount_AppliedToProducts"));
        }
    }
}
