using Euler.Console.Problems;
public class Problem001Tests
{
    [Fact]
    public void Multiples_Of_3_Or_5_Below_10()
    {
        var result = Problem001.Find_Multiples(10);
        Assert.Equal([3, 5, 6, 9], result);
    }

    [Fact]
    public void Adds_Multiples_Under_10()
    {
        var multiples = Problem001.Find_Multiples(10);
        var result = Problem001.Add_Multiples(multiples);
        Assert.Equal(23, result);
    }

    [Fact]
    public void Under_1000()
    {
        var multiples = Problem001.Find_Multiples(1000);
        var result = Problem001.Add_Multiples(multiples);
        Assert.Equal(233168, result);
    }

    [Fact]
    public void Under_100()
    {
        var multiples = Problem001.Find_Multiples(100);
        var result = Problem001.Add_Multiples(multiples);
        Assert.Equal(2318, result);
    }
}