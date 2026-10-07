using System;

namespace SwimProAcadamy.Models
{
    public class CompetitionCategory
    {
        public int CompetitionCategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
