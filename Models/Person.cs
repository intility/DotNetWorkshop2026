namespace DotNetWorkshop2026.Models;

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int? Height { get; set; }

    public Person? Mother { get; set; }
    public Person? Father { get; set; }

    public string GetFullName() => $"{FirstName} {LastName}";

    public string GetMotherFullName()
    {
        if (Mother != null)
        {
            return Mother.GetFullName();
        }
        return "Unknown";
    }

    public string GetFatherFullName()
    {
        if (Father != null)
        {
            return Father.GetFullName();
        }
        return "Unknown";
    }
}
