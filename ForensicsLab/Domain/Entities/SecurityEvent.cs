using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class SecurityEvent
    {
        public Guid Id { get; private set; }

        public Guid? InvestigationId { get; private set; }
        public Guid? EvidenceId { get; private set; }
        public Guid LogSourceId { get; private set; }

        public DateTime Timestamp { get; private set; }

        public string EventType { get; private set; } = null!;
        public string Description { get; private set; } = null!;

        public string? SourceIp { get; private set; }
        public string? DestinationIp { get; private set; }

        public string? Username { get; private set; }

        public SeverityLevel Severity { get; private set; }

        private SecurityEvent() { }
    }
}
