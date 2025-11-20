namespace App.Core.Entities;

public class Meal
{
    public int MealId { get; set; }
    public int TourId { get; set; }
    public required string MealType { get; set; }
    public string? Description { get; set; }

    public required virtual Tour Tour { get; set; }
}
