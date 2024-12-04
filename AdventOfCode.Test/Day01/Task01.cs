using AdventOfCode.Day01;

namespace AdventOfCode.Test.Day01;

public partial class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DistanceBetweenTwoNumbersIsCalculatedCorrectly(){
        Assert.That(new LocationList("1   3").TotalDistance(), Is.EqualTo(2));
        Assert.That(new LocationList("3   4").TotalDistance(), Is.EqualTo(1));
        Assert.That(new LocationList("4   3").TotalDistance(), Is.EqualTo(1));
    }

    [Test]
    public void TotalDistanceWithMultiplineLines(){
        Assert.That(new LocationList("1   3", "1   3").TotalDistance(), Is.EqualTo(4));
        Assert.That(new LocationList("1   3", "2   5").TotalDistance(), Is.EqualTo(5));
    }


    [Test]
    public void TotalDistanceWithMultiplineLinesSortsListsFirst(){
        Assert.That(new LocationList("3   1", "2   5").TotalDistance(), Is.EqualTo(3));
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day01/ExampleInput.txt").ReadLines();
        Assert.That(new LocationList(input).TotalDistance(), Is.EqualTo(11));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
        Assert.That(new LocationList(input).TotalDistance(), Is.EqualTo(2904518));
    }
}