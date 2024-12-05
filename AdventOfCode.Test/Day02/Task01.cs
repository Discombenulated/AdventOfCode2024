
using AdventOfCode.Day02;

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