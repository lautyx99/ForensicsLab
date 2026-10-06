using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Alert
    {
        public Guid Id { get; private set; }

        public Guid? InvestigationId { get; private set; }
        public Guid? SecurityEventId { get; private set; }

        public string Title { get; private set; } = null!;
        public string Description { get; private set; } = null!;

        public SeverityLevel Severity { get; private set; }

        public bool IsAcknowledged { get; private set; }

        public DateTime CreatedAt { get; private set; }

        private Alert() { }

    }
}
