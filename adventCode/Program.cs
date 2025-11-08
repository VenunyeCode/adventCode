using adVentCode;
using adVentCode.Data;

var puzzle = PuzzleData.Puzzle;
Console.WriteLine(puzzle.Reports.Count);

Console.WriteLine($"Number of safe reports without dampeener: {ReportService.NumberOfSafeReportInsideThePuzzle(puzzle)}");
Console.WriteLine($"Number of safe reports with dampeener: {ReportService.NumberOfSafeReportInsideThePuzzleAfterUsingDampeener(puzzle)}");




