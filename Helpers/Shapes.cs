namespace DotNetWorkshop2026.Helpers;

public static class Shapes
{
    public static void Separator(int width = 6)
    {
        Console.WriteLine(new string('-', width));
    }

    public static void Pyramid(int width = 6)
    {
        for (int line = 0; line < width / 2; line++)
        {
            Console.Write(new string(' ', (width / 2) - line - 1));
            Console.Write("/");
            Console.Write(new string(' ', line * 2 + width % 2));
            Console.WriteLine("\\");
        }
    }

    public static void Walls(int width = 6)
    {
        for (int i = 0; i < width - 2; i++)
        {
            Console.Write("|");
            Console.Write(new string(' ', width - 2));
            Console.WriteLine("|");
        }
    }

    public static void UpsideDownPyramid(int width = 6)
    {
        for (int line = 0; line < width / 2; line++)
        {
            Console.Write(new string(' ', line));
            Console.Write("\\");
            Console.Write(new string(' ', (width / 2 - line - 1) * 2 + width % 2));
            Console.WriteLine("/");
        }
    }
}
