using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ThreatAnalysis
    {
        public Guid Id { get; private set; }

        public Guid InvestigationId { get; private set; }

        public string Summary { get; private set; } = null!;

        public ThreatLevel ThreatLevel { get; private set; }

        public double ConfidenceScore { get; private set; }

        public string? RecommendedActions { get; private set; }

        public string AnalysisProvider { get; private set; } = null!;

        public DateTime CreatedAt { get; private set; }

        private ThreatAnalysis() { }
    }
}
