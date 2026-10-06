using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class ThreatAnalysisConfiguration : IEntityTypeConfiguration<ThreatAnalysis>
    {
        public void Configure(EntityTypeBuilder<ThreatAnalysis> builder)
        {
            builder.ToTable("ThreatAnalyses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Summary)
                .IsRequired()
                .HasMaxLength(10000);

            builder.Property(x => x.ThreatLevel)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.ConfidenceScore)
                .IsRequired()
                .HasPrecision(5, 4);

            builder.Property(x => x.RecommendedActions)
                .HasMaxLength(10000);

            builder.Property(x => x.AnalysisProvider)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.HasIndex(x => x.InvestigationId);

            builder.HasOne<Investigation>()
                .WithMany()
                .HasForeignKey(x => x.InvestigationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
