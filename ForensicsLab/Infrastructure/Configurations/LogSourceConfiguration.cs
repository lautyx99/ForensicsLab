using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class LogSourceConfiguration : IEntityTypeConfiguration<LogSource>
    {
        public void Configure(EntityTypeBuilder<LogSource> builder)
        {
            builder.ToTable("LogSources");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Type)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Property(x => x.Hostname)
                .HasMaxLength(255);

            builder.Property(x => x.IpAddress)
                .HasMaxLength(45);

            builder.Property(x => x.CreatedAt)
                .IsRequired();
        }
    }
    }
