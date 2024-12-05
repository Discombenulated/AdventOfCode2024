
using AdventOfCode.Day02;

namespace AdventOfCode.Test.Day02;

public class Task02
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReportIsSafeIfLevelRemoved(){
        Assert.That(new Report("1 3 2 4 5").IsSafeWithTolerence(), Is.True);
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day02/ExampleInput.txt").ReadLines();
        Assert.That(new ReportList(input).CountSafeReportsWithTolerance(), Is.EqualTo(4));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day02/MyInput.txt").ReadLines();
        Assert.That(new ReportList(input).CountSafeReportsWithTolerance(), Is.EqualTo(354));
    }
}