using System.Runtime.CompilerServices;

namespace csharp_13.Features;

public class OverLoadPriority
{
    public void Test()
    {
        Calculatrice.Afficher(10);
    }
}

public class Calculatrice
{
    [OverloadResolutionPriority(1)]
    public static void Afficher(int x)
    {
        Console.WriteLine($"Affichage d'un entier : {x}");
    }

    [OverloadResolutionPriority(10)]
    public static void Afficher(double x)
    {
        Console.WriteLine($"Affichage d'un double : {x}");
    }
}