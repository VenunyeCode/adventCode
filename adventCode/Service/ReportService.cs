using adVentCode.Models;
using adVentCode.Service;

public abstract class ReportService
{
    public static bool IsReportSafe(Report report, bool allowDampener = true)
    {
        int direction = 0;
        if (report.NbLevels() < 2) return true;
        for (int i = 0; i < report.NbLevels() - 1; i++)
        {
            int diff = report.Levels[i+1] - report.Levels[i];
            bool invalidDiff = Math.Abs(diff) < 1 || Math.Abs(diff) > 3;
            if (invalidDiff)
            {
                if (allowDampener) return ProblemDampenerService.LetSeeHowToMakeAnUnsafeReportSafe(report);
                else return false;
            }
            if (Math.Abs(diff) < 1 || Math.Abs(diff) > 3) return false;

            if (direction == 0) direction = diff > 0 ? 1 : -1;
            else
            {
                if ((direction == 1 && diff < 0) || (direction == -1 && diff > 0))
                {
                    if (allowDampener) return ProblemDampenerService.LetSeeHowToMakeAnUnsafeReportSafe(report);
                    else return false;
                }
            }
        }
        return true;
    }

    public static int NumberOfSafeReportInsideThePuzzle(Puzzle puzzle)
    {
        int nb = 0;
        foreach (var report in puzzle.Reports)
        {
            if (ReportService.IsReportSafe(report, false)) nb += 1;
        }

        return nb;
    }

    public static int NumberOfSafeReportInsideThePuzzleAfterUsingDampeener(Puzzle puzzle)
    {
        int nb = 0;
        foreach (var report in puzzle.Reports)
        {
            if (ReportService.IsReportSafe(report)) nb += 1;
        }

        return nb;
    }

}