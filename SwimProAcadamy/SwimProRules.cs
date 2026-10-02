namespace SwimProAcadamy;

/// <summary>All assignment prices and validation rules are kept in one simple place.</summary>
public static class SwimProRules
{
    public const decimal CompetitionFee = 180.00m;
    public const decimal CoachingFee = 120.00m;
    public const decimal MaximumMonthlyCoachingHours = 24m;

    public static decimal GetTrainingFee(string plan) => plan switch
    {
        "Beginner" => 800.00m,
        "Intermediate" => 1100.00m,
        "Advanced" => 1300.00m,
        _ => 0m
    };

    public static bool IsCompetitionAllowed(string plan) =>
        plan == "Intermediate" || plan == "Advanced";

    public static bool AgeMatchesCategory(int age, string category) => category switch
    {
        "Junior" => age >= 8 && age <= 12,
        "Youth" => age >= 13 && age <= 17,
        "Adult" => age >= 18 && age <= 39,
        "Senior" => age >= 40,
        _ => false
    };
}
