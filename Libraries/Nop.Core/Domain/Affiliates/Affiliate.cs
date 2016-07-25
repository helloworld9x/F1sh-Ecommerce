using F1sh.Core.Domain.Common;

namespace F1sh.Core.Domain.Affiliates
{
    /// <summary>
    /// Represents an affiliate
    /// </summary>
    public class Affiliate : BaseEntity
    {
        /// <summary>
        /// Gets or sets the address identifier
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the admin comment
        /// </summary>
        public string AdminComment { get; set; }

        /// <summary>
        /// Gets or sets the friendly name for generated affiliate URL (by default affiliate ID is used)
        /// </summary>
        public string FriendlyUrlName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        public virtual Address Address { get; set; }
    }

    public class AffiliateMap : GoqEntityTypeConfiguration<Affiliate>
    {
        public AffiliateMap()
        {
            ToTable("Affiliate");
            HasKey(a => a.Id);

            HasRequired(a => a.Address).WithMany().HasForeignKey(x => x.AddressId).WillCascadeOnDelete(false);
        }
    }
}
