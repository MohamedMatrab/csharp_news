using System.Diagnostics.CodeAnalysis;

namespace csharp_11.Features;

public class ExtendedNameOfScope
{
    public static void PrintMessage([NotNull] string? message)
    {
        if (message is not null) Console.WriteLine(message);
        else throw new ArgumentNullException(nameof(message));
    }

    public void Test() 
    {
        PrintMessage(null);
    }
}