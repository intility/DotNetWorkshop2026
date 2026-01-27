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

    public void PrintFamilyTree()
    {
        PrintBranch(Father, "", true);
        Console.WriteLine(GetFullName());
        PrintBranch(Mother, "", false);
    }

    private static void PrintBranch(Person? person, string prefix, bool isFather)
    {
        if (person == null)
            return;

        string deeper = prefix + (isFather ? "    " : "│   ");
        PrintBranch(person.Father, deeper, true);

        string connector = isFather ? "┌── " : "└── ";
        Console.WriteLine(prefix + connector + person.GetFullName());

        string lower = prefix + (isFather ? "│   " : "    ");
        PrintBranch(person.Mother, lower, false);
    }
}
