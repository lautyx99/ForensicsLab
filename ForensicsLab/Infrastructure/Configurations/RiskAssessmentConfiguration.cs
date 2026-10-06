using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class RiskAssessmentConfiguration : IEntityTypeConfiguration<RiskAssessment>
    {
        public void Configure(EntityTypeBuilder<RiskAssessment> builder)
        {
            builder.ToTable("RiskAssessments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.RiskScore)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(x => x.RiskLevel)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.Reason)
                .IsRequired()
                .HasMaxLength(4000);

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
