// See https://aka.ms/new-console-template for more information

using DotNetWorkshop2026.Helpers;

Console.WriteLine("Velkommen til DotNet Workshop 2026!");

string? command = null;

while (command != "exit")
{
    Console.WriteLine("Hva vil du gjøre i dag?");

    command = Console.ReadLine()?.ToLower();

    try
    {
        switch (command)
        {
            case "name":
            case "greet":
                Commands.Greet();
                break;
            case "age":
                Commands.Age();
                break;
            case "beer":
                Commands.Beer();
                break;
            case "pyramid":
                Shapes.Pyramid();
                Shapes.Separator();
                break;
            case "cube":
                // implement this yourself
                break;
            case "train":
                Commands.TrainCommand();
                break;
            case "slash":
                Commands.Slash();
                break;
            case "exit":
                break;
            default:
                Console.WriteLine("Ukjent kommando, prøv igjen.");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Oops, der skjedde det noe galt!");
    }
    Shapes.Separator(20);

    Thread.Sleep(1000);
}
