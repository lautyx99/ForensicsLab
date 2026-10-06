using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class RiskAssessment
    {
        public Guid Id { get; private set; }

        public Guid InvestigationId { get; private set; }

        public int RiskScore { get; private set; }

        public RiskLevel RiskLevel { get; private set; }

        public string Reason { get; private set; } = null!;

        public DateTime CreatedAt { get; private set; }

        private RiskAssessment() { }
    }
}
