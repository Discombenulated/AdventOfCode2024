namespace AdventOfCode.Day02;

public class Report
{
    private List<int> levels;
    private string reportText;

    public Report(string reportText)
    {
        this.reportText = reportText;
        this.levels = reportText.Split(' ').Select(s => int.Parse(s)).ToList();
    }

    public Report(List<int> levels)
    {
        this.levels = levels;
    }

    public bool IsSafe()
    {
        var isIncreasing = this.levels[1] - this.levels[0] > 0;
        for (int i = 1; i < this.levels.Count; i++){
            var difference = this.levels[i] - this.levels[i-1];
            var isStillIncreasing = difference > 0;
            if (isIncreasing != isStillIncreasing){
                return false;
            }
            var absoluteDifference = Math.Abs(difference);
            if (absoluteDifference > 3){
                return false;
            }
            if (absoluteDifference < 1){
                return false;
            }
        }
        return true;
    }

    public bool IsSafeWithTolerence()
    {
        if (IsSafe()) return true;
        for (int i = 0; i < this.levels.Count(); i++){
            
            var modifiedReport = copyLevelsMinusIndex(i);
            if (modifiedReport.IsSafe()) return true;
        }
        return false;
    }

    private Report copyLevelsMinusIndex(int index){
        var newList = new List<int>(this.levels);
        newList.RemoveAt(index);
        return new Report(newList);
    }

    public override string ToString(){
        return reportText;
    }
}

