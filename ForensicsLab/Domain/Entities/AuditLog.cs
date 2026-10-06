using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class AuditLog
    {
        public Guid Id { get; private set; }

        public Guid? UserId { get; private set; }

        public string Action { get; private set; } = null!;
        public string EntityType { get; private set; } = null!;
        public string? EntityId { get; private set; }

        public string? IpAddress { get; private set; }

        public DateTime Timestamp { get; private set; }

        private AuditLog() { }
    }
}
