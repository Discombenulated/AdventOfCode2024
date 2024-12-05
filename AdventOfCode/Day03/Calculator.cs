
using System.Text.RegularExpressions;

namespace AdventOfCode.Day03;

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

    public int MultiplyWithEnabledCommands(string command)
    {
        var pattern = new Regex(@"don't\(\).*?do\(\)|don't\(\).*?\Z");
        var enabledCommands = pattern.Replace(command, "");
        Console.WriteLine(enabledCommands);
        return Multiply(enabledCommands);
    }
}