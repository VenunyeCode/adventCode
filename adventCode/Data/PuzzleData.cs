using adVentCode.Models;

namespace adVentCode.Data;

public static class PuzzleData
{
    public static Puzzle Puzzle { get; } = InitializePuzzle();
    private static Puzzle InitializePuzzle()
    {
        var puzzle = new Puzzle();
        var filePath = Path.Combine(AppContext.BaseDirectory, Utilities.Utilities.DataPath);

        if (!File.Exists(filePath)) throw new FileNotFoundException($"Puzzle input not found: {filePath}");

        var lines = File.ReadAllLines(Utilities.Utilities.DataPath);

        var reports = new List<List<int>>();
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var levels = new List<int>();
            foreach (var s in line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries))
                levels.Add(int.Parse(s));
            reports.Add(levels);
        }

        puzzle.AddReport(reports);

        return puzzle;
    }
}
