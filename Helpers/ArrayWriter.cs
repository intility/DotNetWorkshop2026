namespace DotNetWorkshop2026.Helpers;

public class ArrayWriter
{
    public static void WriteArray(List<bool> array)
    {
        var index = 0;
        while (index < array.Count)
        {
            Console.WriteLine($"bool at index {index} is {array[index]}");
            array[index] = !array[index];
            Console.WriteLine($"bool at index {index} is now {array[index]}");
            index++;
        }
    }
}
