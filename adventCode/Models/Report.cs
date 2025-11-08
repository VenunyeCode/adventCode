namespace adVentCode.Models;

public class Report
{
    private List<int> levels = new();
    public List<int> Levels
    {
        get => levels;
        set => levels = value;
    }


    public void AddLevel(int level)
    {
        this.levels.Add(level);
    }

    public void AddLevel(List<int> levels)
    {
        this.levels.AddRange(levels);
    }

    public int NbLevels()
    {
        return this.levels.Count;
    }
    

    override
    public string ToString()
    {
        var result = "";
        result += string.Join(" ", levels);
        result += "\n";

        return result;
    }
    
    
}