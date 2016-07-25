using F1sh.Core.Domain.Media;

namespace F1sh.Data.Mapping.Media
{
    public partial class DownloadMap : F1shEntityTypeConfiguration<Download>
    {
        public DownloadMap()
        {
            this.ToTable("Download");
            this.HasKey(p => p.Id);
            this.Property(p => p.DownloadBinary).IsMaxLength();
        }
    }
}