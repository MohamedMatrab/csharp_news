using System;
using System.Runtime.CompilerServices;

namespace csharp_12.Features;

public class Interceptors
{

}

class C
{
    public void InterceptableMethod(int param)
    {
        Console.WriteLine($"interceptable {param}");
    }
}

