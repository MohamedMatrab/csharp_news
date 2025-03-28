namespace csharp_13.Features;

public class Params
{
    public void Test()
    {
        Concat(1, 2, 3, 6, 5);
    }

    public void Concat<T>(params ReadOnlySpan<T> items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.Write(items[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
