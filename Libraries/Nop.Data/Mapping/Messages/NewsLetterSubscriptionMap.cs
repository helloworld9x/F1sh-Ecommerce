using F1sh.Core.Domain.Messages;

namespace F1sh.Data.Mapping.Messages
{
    public partial class NewsLetterSubscriptionMap : F1shEntityTypeConfiguration<NewsLetterSubscription>
    {
        public NewsLetterSubscriptionMap()
        {
            this.ToTable("NewsLetterSubscription");
            this.HasKey(nls => nls.Id);

            this.Property(nls => nls.Email).IsRequired().HasMaxLength(255);
        }
    }
}