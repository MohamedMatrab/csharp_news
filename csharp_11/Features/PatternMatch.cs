namespace csharp_11.Features;

public class PatternMatch
{
    public void Test()
    {
        ReadOnlySpan<char> span = "Hello, World!".AsSpan();

        // Pattern matching with ReadOnlySpan<char>
        if (span is "Hello, World!") Console.WriteLine("The span matches 'Hello, World!'");

        // Pattern matching with Span<char>
        Span<char> mutableSpan = stackalloc char[] { 'H', 'e', 'l', 'l', 'o' };

        if (mutableSpan is "Hello") Console.WriteLine("The mutable span matches 'Hello'");
    }
}
