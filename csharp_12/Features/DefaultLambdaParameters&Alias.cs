using X = System.Collections.Generic.List<string?>;
using Y = int?;

//cannot be nullable reference type
//using L = string?;

namespace csharp_12.Features;

public class DefaultLambdaParameters
{
    public void Test()
    {
        var line = (string text,int num=0) => Console.WriteLine($"{text} - {num}");
        line("First");
        line("Second",90);
    }
}