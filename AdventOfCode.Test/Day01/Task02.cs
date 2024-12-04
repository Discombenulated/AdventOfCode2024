using AdventOfCode.Day01;

namespace AdventOfCode.Test.Day01;

public partial class Task02
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SimilarityInSingleItemList(){
        Assert.That(new LocationList("1   0").Similarity(), Is.EqualTo(0));
        Assert.That(new LocationList("1   1").Similarity(), Is.EqualTo(1));
        Assert.That(new LocationList("3   3").Similarity(), Is.EqualTo(3));
    }

    [Test]
    public void SimilarityInTwoItemList(){
        Assert.That(new LocationList("1   0", "1   0").Similarity(), Is.EqualTo(0));
        Assert.That(new LocationList("1   1", "1   1").Similarity(), Is.EqualTo(4));
        Assert.That(new LocationList("3   3", "3   3").Similarity(), Is.EqualTo(12));
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day01/ExampleInput.txt").ReadLines();
        Assert.That(new LocationList(input).Similarity(), Is.EqualTo(31));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
        Assert.That(new LocationList(input).Similarity(), Is.EqualTo(18650129));
    }
}