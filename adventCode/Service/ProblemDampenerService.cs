using adVentCode.Models;
namespace adVentCode.Service;

public static class ProblemDampenerService
{
    public static bool LetSeeHowToMakeAnUnsafeReportSafe(Report report)
    {
        if (ReportService.IsReportSafe(report, false)) return true;
        var tempLevels = new List<int>(report.Levels);
        var clone = new Report() { Levels = tempLevels };
        for (int i = 0; i < report.NbLevels(); i++)
        {
            tempLevels.Clear();
            tempLevels.AddRange(report.Levels);

            tempLevels.RemoveAt(i);

            if (ReportService.IsReportSafe(clone, false)) return true;
        }
        return false;
    }
}