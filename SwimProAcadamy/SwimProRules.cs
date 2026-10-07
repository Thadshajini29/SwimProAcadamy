namespace SwimProAcadamy;

/// <summary>All assignment prices and validation rules are kept in one simple place.</summary>
public static class SwimProRules
{
    public const decimal CompetitionFee = 180.00m;
    public const decimal CoachingFee = 120.00m;
    public const decimal MaximumMonthlyCoachingHours = 24m;

    // Training plan fees, category limits and competition access are loaded from MySQL.
}
