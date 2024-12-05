
using System.Text.RegularExpressions;

namespace AdventOfCode.Test.Day03;

public class Task01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CanMultipleCorrectly(){
        var calc = new Calculator();
        Assert.That(calc.Multiply("mul(5,3)"), Is.EqualTo(15));
        Assert.That(calc.Multiply("mul(2,4)"), Is.EqualTo(8));
    }
    
    [Test]
    public void CanMultiplyCorrectlyWithMultipleCommands(){
        var calc = new Calculator();
        Assert.That(calc.Multiply("mul(2,4)mul(3,1)"), Is.EqualTo(11));
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day03/ExampleInput.txt").ReadLines();
        var calc = new Calculator();
        Assert.That(calc.Multiply(input[0]), Is.EqualTo(161));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day03/MyInput.txt").ReadLines();
        var calc = new Calculator();
        Assert.That(calc.Multiply(input[0]), Is.EqualTo(170807108));
    }
}

public class Calculator
{
    public Calculator()
    {
    }

    public int Multiply(string command)
    {
        var total = 0;
        var pattern = new Regex(@"mul\((?<1>\d+),(?<2>\d+)\)");
        var matches = pattern.Matches(command);
        foreach(Match m in matches){
            var firstNum = int.Parse(m.Groups["1"].Value);
            var secondNum = int.Parse(m.Groups["2"].Value);
            total += (firstNum * secondNum);
        }
        return total;
    }
}