using System;

namespace SwimProAcadamy.Models
{
    public class Fee
    {
        public int FeeId { get; set; }
        public int SwimmerId { get; set; }
        public string SwimmerName { get; set; } = string.Empty;
        public decimal TrainingFee { get; set; }
        public decimal CompetitionFee { get; set; }
        public decimal CoachingFee { get; set; }
        public decimal TotalFee { get; set; }
        public DateTime FeeMonth { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
