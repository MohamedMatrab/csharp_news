namespace csharp_11.Features;

public class IntPtrUIntPtr
{
    public void Test()
    {
        nint intPtr = new IntPtr(42);
        nuint uintPtr = new UIntPtr(42);

        Console.WriteLine($"nint value: {intPtr}");
        Console.WriteLine($"nuint value: {uintPtr}");
    }
}
