namespace csharp_14.Features;

public class UnboundNameOf
{
    public static void Test()
    {
        var name = nameof(List<>);
        Console.WriteLine(name);
    }
}