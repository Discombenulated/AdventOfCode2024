namespace AdventOfCode.Day02;

public class ReportList
{
    private List<Report> reports;

    public ReportList(string[] input)
    {
        this.reports = new List<Report>();
        foreach (string reportText in input){
            this.reports.Add(new Report(reportText));
        }
    }

    public int CountSafeReports()
    {
        return this.reports.Where(r => r.IsSafe()).Count();
    }

    public int CountSafeReportsWithTolerance(){
        return this.reports.Where(r => r.IsSafeWithTolerence()).Count();
    }
}

