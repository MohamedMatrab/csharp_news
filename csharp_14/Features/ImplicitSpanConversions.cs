namespace csharp_14.Features;

public class ImplicitSpanConversions
{
    public static void Test()
    {
        int[] numbers = { 1, 2, 3 };
        Span<int> span = numbers;
        foreach (var item in span) Console.WriteLine(item);
    }
}
public static class MemoryExtensions
{
    public static bool StartsWith<T>(this ReadOnlySpan<T> span, T value) where T : IEquatable<T> => span.Length != 0 && EqualityComparer<T>.Default.Equals(span[0], value);
}