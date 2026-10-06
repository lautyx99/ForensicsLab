using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class LogSource
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; } = null!;
        public LogSourceType Type { get; private set; }

        public string? Hostname { get; private set; }
        public string? IpAddress { get; private set; }

        public DateTime CreatedAt { get; private set; }

        private LogSource() { }

        public LogSource(
            string name,
            LogSourceType type,
            string? hostname = null,
            string? ipAddress = null)
        {
            Id = Guid.NewGuid();

            Name = name;
            Type = type;
            Hostname = hostname;
            IpAddress = ipAddress;

            CreatedAt = DateTime.UtcNow;
        }
    }
}
