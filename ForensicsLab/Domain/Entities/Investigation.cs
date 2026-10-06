using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Investigation
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; } = null!;
        public string Description { get; private set; } = null!;

        public InvestigationStatus Status { get; private set; }

        public Guid CreatedByUserId { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime? ClosedAt { get; private set; }

        private Investigation() { }

        public Investigation(
            string name,
            string description,
            Guid createdByUserId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            CreatedByUserId = createdByUserId;

            Status = InvestigationStatus.Open;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
