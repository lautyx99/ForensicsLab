using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class EvidenceConfiguration : IEntityTypeConfiguration<Evidence>
    {
        public void Configure(EntityTypeBuilder<Evidence> builder)
        {
            builder.ToTable("Evidences");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FileName)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.ContentType)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.FileSize)
                .IsRequired();

            builder.Property(x => x.StoragePath)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(x => x.Sha256Hash)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(x => x.UploadedAt)
                .IsRequired();

            builder.HasIndex(x => x.Sha256Hash);

            builder.HasIndex(x => x.InvestigationId);

            builder.HasOne<Investigation>()
                .WithMany()
                .HasForeignKey(x => x.InvestigationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(x => x.UploadedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
