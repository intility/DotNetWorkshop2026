namespace DotnetWorkshop2026.Models;

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int? Height { get; set; }

    public Person? Mother { get; set; }
    public Person? Father { get; set; }

    public string GetFullName() => $"{FirstName} {LastName}";

    public string GetMotherFullName() => Mother?.GetFullName() ?? "Unknown";

    public string GetFatherFullName() => Father?.GetFullName() ?? "Unknown";
}
