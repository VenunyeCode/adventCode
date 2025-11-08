namespace adVentCode.Models;

public class Puzzle
{
    private List<Report> reports = new();
    public List<Report> Reports
    {
        get => reports;
        set => reports = value;
    }

    public void AddReport(Report report)
    {
        this.reports.Add(report);
    }

    public void AddReport(List<Report> reports)
    {
        this.reports.AddRange(reports);
    }

    public void AddReport(List<List<int>> reportLevels)
    {
        foreach (var levels in reportLevels)
        {
            var report = new Report();
            report.AddLevel(levels);
            reports.Add(report);
        }
    }

    override
    public string ToString()
    {
        var result = "";
        foreach (var report in this.reports)
        {
            result += report.ToString();
        }

        return result;
    }
}
