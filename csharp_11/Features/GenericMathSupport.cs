namespace csharp_11.Features;

public class GenericMathSupport
{
    public void Test()
    {
        int signedValue = -16;
        uint unsignedValue = (uint)signedValue;

        uint shiftedValue = unsignedValue >>> 2;

        Console.WriteLine($"Unsigned right-shift result: {shiftedValue}");
    }
}

public interface IAdditionOperators<TSelf, TOther, TResult>
    where TSelf : IAdditionOperators<TSelf, TOther, TResult>
{
    static abstract TResult operator +(TSelf left, TOther right);
}