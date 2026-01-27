namespace DotNetWorkshop2026.Helpers;

public static class Train
{
    private static readonly string[] _art =
    [
        @"      ___",
        @" Y____| |",
        @"<_______|-1",
        @"  O-O-O",
    ];

    /// <summary>
    /// The ASCII art of the train as an array of strings (one per line).
    /// </summary>
    public static string[] Art => _art;

    /// <summary>
    /// The width of the train in characters.
    /// </summary>
    public static int Width => _art.Max(line => line.Length);

    /// <summary>
    /// The height of the train in lines.
    /// </summary>
    public static int Height => _art.Length;
    
    /// <summary>
    /// The width of the track in characters. Going out of bounds will cause an error.
    /// </summary>
    public static int TrackWidth = 50;

    /// <summary>
    /// Renders the train at the specified position within the track width.
    /// Handles wrapping so the train seamlessly appears on both edges.
    /// </summary>
    /// <param name="position">The position of the train's left edge (0 to TrackWidth-1)</param>
    /// <param name="trackWidth">The total width of the track</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when position is out of bounds</exception>
    public static void Render(int position)
    {
        Clear();

        // Validate position is within bounds
        if (position < 0)
        {
            RenderEmptyTrack();
            RenderError("ERROR: Position out of bounds!",
                $"Position cannot be negative.",
                $"Got: position = {position}",
                $"Expected: position >= 0",
                "",
                "Hint: Check your wrap-around logic.",
                "When position goes below 0, reset it to trackWidth - 1");
            Environment.Exit(1);
        }

        if (position >= TrackWidth)
        {
            RenderEmptyTrack();
            RenderError("ERROR: Position out of bounds!",
                $"Position must be less than trackWidth.",
                $"Got: position = {position}",
                $"Expected: position < {TrackWidth} (valid range: 0 to {TrackWidth - 1})",
                "",
                "Hint: This is an off-by-one error!",
                "Arrays are zero-indexed, so the last valid index is trackWidth - 1");
            Environment.Exit(1);
        }

        // Draw top border
        Console.WriteLine("+" + new string('-', TrackWidth) + "+");

        foreach (var line in _art)
        {
            // Create a buffer filled with spaces
            char[] buffer = new char[TrackWidth];
            Array.Fill(buffer, ' ');

            // Place each character of the train line into the buffer with wrapping
            for (int i = 0; i < line.Length; i++)
            {
                int screenPos = (position + i) % TrackWidth;
                buffer[screenPos] = line[i];
            }

            Console.WriteLine("|" + new string(buffer) + "|");
        }

        // Draw bottom border
        Console.WriteLine("+" + new string('-', TrackWidth) + "+");
    }

    /// <summary>
    /// Clears the console and resets the cursor position.
    /// </summary>
    public static void Clear()
    {
        Console.SetCursorPosition(0, 0);
    }

    private static void RenderEmptyTrack()
    {
        Console.WriteLine("+" + new string('-', TrackWidth) + "+");
        for (int i = 0; i < _art.Length; i++)
        {
            Console.WriteLine("|" + new string(' ', TrackWidth) + "|");
        }
        Console.WriteLine("+" + new string('-', TrackWidth) + "+");
    }

    private static void RenderError(string title, params string[] lines)
    {
        Console.WriteLine();

        // Find the longest line to size the box
        int maxLength = title.Length;
        foreach (var line in lines)
        {
            if (line.Length > maxLength) maxLength = line.Length;
        }
        int boxWidth = maxLength + 4;

        // Draw error box
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("+" + new string('-', boxWidth) + "+");
        Console.WriteLine("|  " + title.PadRight(maxLength) + "  |");
        Console.WriteLine("+" + new string('-', boxWidth) + "+");
        Console.ResetColor();

        foreach (var line in lines)
        {
            Console.WriteLine("|  " + line.PadRight(maxLength) + "  |");
        }
        Console.WriteLine("+" + new string('-', boxWidth) + "+");
        Console.WriteLine();
    }
}
