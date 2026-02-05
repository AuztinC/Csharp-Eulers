namespace Euler.Console.Problems;

public static class Problem001
{
    public static int[] Find_Multiples(int limit)
    {
        var multiples = new List<int>();
        for (int i = 1; i < limit; i++)
        {
            if(i % 3 == 0)
            {
                multiples.Add(i);
            }
            else if(i % 5 == 0)
            {
                multiples.Add(i);
            }
        }
        return [.. multiples];
    }

    public static int Add_Multiples(int[] ints)
    {
        return ints.Sum();
    }

}