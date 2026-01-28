using DotNetWorkshop2026.Helpers;

public class Commands
{
    static int lastAge = 0;

    public static string Ask(string question)
    {
        Console.WriteLine(question);

        var input = Console.ReadLine();

        if (input == null)
        {
            throw new NullReferenceException();
        }

        return input;
    }

    public static void Greet()
    {
        var name = Ask("Hva heter du?");
        Console.WriteLine($"Hei, {name}!");
    }

    public static void Age()
    {
        try
        {
            var age = int.Parse(Ask("Hvor gammel er du?"));

            lastAge = age;

            if (age > 30)
            {
                Console.WriteLine("Uff da unc");
            }
            else
            {
                Console.WriteLine("Du er full av ungdommelig energi!");
            }
        }
        catch
        {
            Console.WriteLine("Det skjønte jeg ikke helt.");
            Age();
        }
    }

    public static void Beer()
    {
        if (lastAge >= 18)
        {
            Console.WriteLine("Her er ølen din, skål 🍻");
        }
        else
        {
            Console.WriteLine("Du er ikke gammel nok! 👶");
        }
    }

    public static void TrainCommand()
    {
        // make it animate?
        // hint: loops & Thread.Sleep()
        Train.Render(10);
    }

    public static void Slash()
    {
        var size = int.Parse(Ask("Hvor stor skal slashet være?"));

        for (var i = size; i >= 0; i--)
        {
            for (var j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("/");
        }
    }
}
