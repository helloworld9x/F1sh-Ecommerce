using F1sh.Core.Domain.Topics;

namespace F1sh.Data.Mapping.Topics
{
    public class TopicMap : F1shEntityTypeConfiguration<Topic>
    {
        public TopicMap()
        {
            this.ToTable("Topic");
            this.HasKey(t => t.Id);
        }
    }
}
