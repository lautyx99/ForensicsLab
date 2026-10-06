using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class SecurityEventConfiguration : IEntityTypeConfiguration<SecurityEvent>
    {
        public void Configure(EntityTypeBuilder<SecurityEvent> builder)
        {
            builder.ToTable("SecurityEvents");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.EventType)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(4000);

            builder.Property(x => x.SourceIp)
                .HasMaxLength(45);

            builder.Property(x => x.DestinationIp)
                .HasMaxLength(45);

            builder.Property(x => x.Username)
                .HasMaxLength(255);

            builder.Property(x => x.Severity)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.Timestamp)
                .IsRequired();

            builder.HasIndex(x => x.Timestamp);
            builder.HasIndex(x => x.InvestigationId);
            builder.HasIndex(x => x.LogSourceId);

            builder.HasOne<Investigation>()
                .WithMany()
                .HasForeignKey(x => x.InvestigationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Evidence>()
                .WithMany()
                .HasForeignKey(x => x.EvidenceId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<LogSource>()
                .WithMany()
                .HasForeignKey(x => x.LogSourceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
