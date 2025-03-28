using System.Runtime.CompilerServices;

namespace csharp_12.Features;

public class InlineArrays
{
    public void Test()
    {
        var buffer = new Buffer();
        for (int i = 0; i < 10; i++)
        {
            buffer[i] = $"LALALA s{i}";
        }

        foreach (var i in buffer)
        {
            Console.WriteLine(i);
        }
    }
}

[InlineArray(10)]
public struct Buffer
{
    private string _element0;
}