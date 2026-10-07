using System;

namespace SwimProAcadamy.Models
{
    public class TrainingPlan
    {
        public int TrainingPlanId { get; set; }
        public string PlanName { get; set; } = string.Empty;
        public int SessionsPerWeek { get; set; }
        public decimal WeeklyFee { get; set; }
        public bool CompetitionAllowed { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
