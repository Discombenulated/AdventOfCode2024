namespace AdventOfCode.Day01;

public class LocationList
{
    private List<int> FirstList;
    private List<int> SecondList;

    public LocationList(params string[] input)
    {
        this.FirstList = new List<int>();
        this.SecondList = new List<int>();
        foreach (var line in input){
            var numbers = line.Split("   ");
            this.FirstList.Add(int.Parse(numbers[0]));
            this.SecondList.Add(int.Parse(numbers[1]));
        }
        this.FirstList.Sort();
        this.SecondList.Sort();
    }

    public int TotalDistance()
    {
        var sum = 0;
        for (int i = 0; i < this.FirstList.Count(); i++){
            sum += DistanceForListItem(i);
        }
        return sum;
    }

    private int DistanceForListItem(int index)
    {
        return Math.Abs(this.FirstList[index] - this.SecondList[index]);
    }
}