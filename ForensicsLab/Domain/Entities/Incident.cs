using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Incident
    {
        public Guid Id { get; private set; }

        public Guid InvestigationId { get; private set; }

        public string Title { get; private set; } = null!;
        public string Description { get; private set; } = null!;

        public IncidentStatus Status { get; private set; }
        public SeverityLevel Severity { get; private set; }

        public DateTime DetectedAt { get; private set; }
        public DateTime? ResolvedAt { get; private set; }

        private Incident() { }

        public Incident(
            Guid investigationId,
            string title,
            string description,
            SeverityLevel severity)
        {
            Id = Guid.NewGuid();

            InvestigationId = investigationId;

            Title = title;
            Description = description;
            Severity = severity;

            Status = IncidentStatus.Open;
            DetectedAt = DateTime.UtcNow;
        }
    }
}
