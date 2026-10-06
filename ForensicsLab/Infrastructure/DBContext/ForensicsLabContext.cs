using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DBContext
{
    public class ForensicsLabContext : DbContext
    {
        public ForensicsLabContext(DbContextOptions<ForensicsLabContext> options) : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Investigation> Investigations => Set<Investigation>();
        public DbSet<Evidence> Evidences => Set<Evidence>();
        public DbSet<LogSource> LogSources => Set<LogSource>();
        public DbSet<SecurityEvent> SecurityEvents => Set<SecurityEvent>();
        public DbSet<Incident> Incidents => Set<Incident>();
        public DbSet<Alert> Alerts => Set<Alert>();
        public DbSet<ThreatAnalysis> ThreatAnalyses => Set<ThreatAnalysis>();
        public DbSet<RiskAssessment> RiskAssessments => Set<RiskAssessment>();
        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ForensicsLabContext).Assembly);
        }
    }
}
