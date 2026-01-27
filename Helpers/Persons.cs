using System.Text.Json;
using DotNetWorkshop2026.Models;

namespace DotNetWorkshop2026.Helpers;

public static class Persons
{
    private static readonly JsonSerializerOptions jsonOptions = new(JsonSerializerDefaults.Web);

    public static List<Person> LoadPersons()
    {
        // load from ../Data/persons.json
        var json = File.ReadAllText("Data/persons.json");
        var persons = JsonSerializer.Deserialize<List<Person>>(json, jsonOptions);

        if (persons == null)
        {
            throw new Exception("Failed to load persons from JSON.");
        }

        return persons;
    }
}
