using Euler.Console.Problems;
public class Problem001Tests
{
    [Fact]
    public void Solves_Problem_001_Correctly()
    {
        var result = Problem001.Solve();
        Assert.Equal("1", result);
    }
}