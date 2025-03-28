namespace csharp_11.Features;

public class ListPatterns
{
    public void Test()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        
        if (numbers is [1, 2, 3, 4, 5]) Console.WriteLine("The sequence is [1, 2, 3, 4, 5]");

        if (numbers is [1, _, 3, _, 5]) Console.WriteLine("The sequence matches [1, _, 3, _, 5]");

        if (numbers is [1, .., 5]) Console.WriteLine("The sequence starts with 1 and ends with 5");
    }
}