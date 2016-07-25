using F1sh.Core.Domain.Tasks;

namespace F1sh.Data.Mapping.Tasks
{
    public partial class ScheduleTaskMap : F1shEntityTypeConfiguration<ScheduleTask>
    {
        public ScheduleTaskMap()
        {
            this.ToTable("ScheduleTask");
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.Type).IsRequired();
        }
    }
}