namespace DotNetWorkshop2026.Helpers;

class GridRenderer
{
    public static void Render(IEnumerable<IEnumerable<bool>> grid)
    {
        // render coords
        Console.Write(" ");

        for (int col = 0; col < grid.Count(); col++)
        {
            Console.Write(" | " + col % 10);
        }

        Console.WriteLine();

        for (int row = 0; row < grid.Count(); row++)
        {
            // row separator
            Console.WriteLine(new string('-', grid.ElementAt(row).Count() * 4 + 2));

            Console.Write(row % 10);

            for (int col = 0; col < grid.ElementAt(row).Count(); col++)
            {
                Console.Write(" | " + (grid.ElementAt(row).ElementAt(col) ? "X" : " "));
            }
            Console.WriteLine();
        }
    }
}
