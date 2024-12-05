
namespace AdventOfCode.Test.Day02;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReportIsSafe(){
        Assert.That(new Report("1 2 3 4 5").IsSafe(), Is.True);
        Assert.That(new Report("5 4 3 2 1").IsSafe(), Is.True);
        Assert.That(new Report("7 6 4 2 1").IsSafe(), Is.True);
        Assert.That(new Report("1 3 6 7 9").IsSafe(), Is.True);
    }

    [Test]
    public void ReportIsUnsafeIfIncreaseOfMoreThanThree(){
        Assert.That(new Report("1 2 6 7 8").IsSafe(), Is.False);
    }

    [Test]
    public void ReportIsUnsafeIfNoIncrease(){
        Assert.That(new Report("1 2 2 3 4").IsSafe(), Is.False);
    }

    [Test]
    public void ReportIsUnsafeIfNotAllIncreasingOrDecreasing(){
        Assert.That(new Report("1 2 1 3 4").IsSafe(), Is.False);
        Assert.That(new Report("2 1 3 4 5").IsSafe(), Is.False);
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day02/ExampleInput.txt").ReadLines();
        Assert.That(new ReportList(input).CountSafeReports(), Is.EqualTo(2));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day02/MyInput.txt").ReadLines();
        Assert.That(new ReportList(input).CountSafeReports(), Is.EqualTo(287));
    }
}

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
}

public class Report
{
    private List<int> levels;
    private string reportText;

    public Report(string reportText)
    {
        this.reportText = reportText;
        this.levels = reportText.Split(' ').Select(s => int.Parse(s)).ToList();
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

    public override string ToString(){
        return reportText;
    }
}