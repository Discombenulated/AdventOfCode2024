
using System.Runtime.CompilerServices;
using NUnit.Framework.Internal.Commands;

namespace AdventOfCode.Test.Day01;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DistanceBetweenTwoNumbersIsCalculatedCorrectly(){
        Assert.That(new LocationList("1 3").TotalDistance(), Is.EqualTo(2));
        Assert.That(new LocationList("3 4").TotalDistance(), Is.EqualTo(1));
        Assert.That(new LocationList("4 3").TotalDistance(), Is.EqualTo(1));
    }

    [Test]
    [Ignore("Not yet")]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day01/ExampleInput.txt").ReadLines();
        Assert.That(new LocationList(input).TotalDistance(), Is.EqualTo(11));
    }

    [Test]
    [Ignore("Not yet")]
    public void Test_MyData()
    {
        var input = new FileInput("Day01/MyInput.txt").ReadLines();
        //Assert.AreEqual(expected, actual);
    }

    private class LocationList
    {
        private List<int> FirstList;
        private List<int> SecondList;

        public LocationList(params string[] input)
        {
            this.FirstList = new List<int>();
            this.SecondList = new List<int>();
            foreach (var line in input){
                var numbers = line.Split(' ');
                this.FirstList.Add(int.Parse(numbers[0]));
                this.SecondList.Add(int.Parse(numbers[1]));
            }
        }

        public int TotalDistance()
        {
            return Math.Abs(this.FirstList[0] - this.SecondList[0]);
        }
    }
}