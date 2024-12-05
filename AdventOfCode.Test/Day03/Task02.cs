using AdventOfCode.Day03;

namespace AdventOfCode.Test.Day03;

public class Task02
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void CanMultiplyCorrectlyIgnoringDisabledCommands(){
        var calc = new Calculator();
        Assert.That(calc.MultiplyWithEnabledCommands("mul(2,4)don't()mul(3,1)"), Is.EqualTo(8));
        Assert.That(calc.MultiplyWithEnabledCommands("mul(2,4)don't()mul(3,1)do()mul(2,3)"), Is.EqualTo(14));
    }

    [Test]
    public void Test_ExampleData()
    {
        var input = new FileInput("Day03/Example2Input.txt").ReadLines();
        var calc = new Calculator();
        Assert.That(calc.MultiplyWithEnabledCommands(input[0]), Is.EqualTo(48));
    }

    [Test]
    public void Test_MyData()
    {
        var input = new FileInput("Day03/MyInput.txt").ReadLines();
        var calc = new Calculator();
        Assert.That(calc.MultiplyWithEnabledCommands(input[0]), Is.EqualTo(74838033));
    }
}
