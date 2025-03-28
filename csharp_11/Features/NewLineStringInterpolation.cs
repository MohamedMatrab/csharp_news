namespace csharp_11.Features;

public class NewLineStringInterpolation
{
    public void Test()
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };

        var result = $"The sum of even numbers is: {numbers
                .Where(n => n % 2 == 0)
                .Sum()}";

        Console.WriteLine(result);
    }
}