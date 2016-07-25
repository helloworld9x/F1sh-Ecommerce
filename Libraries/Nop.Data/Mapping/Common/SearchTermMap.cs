using F1sh.Core.Domain.Common;

namespace F1sh.Data.Mapping.Common
{
    public partial class SearchTermMap : F1shEntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
