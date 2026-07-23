using Euler.Console.Problems;

public class Problem002Tests
{
    [Fact]
    public void Under_10()
    {
        int limit = 10;
        var result = Problem002.Fibber(limit);
        Assert.Equal([1, 2, 3, 5, 8], result);
    }

    [Fact]
    public void Sum_Under_10()
    {
        int limit = 10;
        var result = Problem002.Sum_Even_Fibs(Problem002.Fibber(limit));
        Assert.Equal(10, result);
    }

    [Fact]
    public void Sum_Under_4M()
    {
        int limit = 4000000;
        var result = Problem002.Sum_Even_Fibs(Problem002.Fibber(limit));
        Assert.Equal(4613732, result);
        
    }
}