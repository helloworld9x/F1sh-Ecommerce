﻿using F1sh.Core.Domain.Logging;

namespace F1sh.Data.Mapping.Logging
{
    public partial class ActivityLogMap : F1shEntityTypeConfiguration<ActivityLog>
    {
        public ActivityLogMap()
        {
            this.ToTable("ActivityLog");
            this.HasKey(al => al.Id);
            this.Property(al => al.Comment).IsRequired();

            this.HasRequired(al => al.ActivityLogType)
                .WithMany()
                .HasForeignKey(al => al.ActivityLogTypeId);

            this.HasRequired(al => al.Customer)
                .WithMany()
                .HasForeignKey(al => al.CustomerId);
        }
    }
}
