using System;

namespace SwimProAcadamy.Models
{
    public class Swimmer
    {
        public int SwimmerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public int TrainingPlanId { get; set; }
        public string TrainingPlanName { get; set; } = string.Empty;
        public int? CompetitionCategoryId { get; set; }
        public string CompetitionCategoryName { get; set; } = string.Empty;
        public int Competitions { get; set; }
        public decimal CoachingHours { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
