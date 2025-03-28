namespace csharp_13.Features;

public class RefStructInterfaces
{
    public void Test()
    {
        var iStruct = new StructTest();
        iStruct.Method();
    }
}

public interface IStruct
{
    void Method();
}

public ref struct StructTest : IStruct
{
    public void Method()
    {
        Console.WriteLine("Method from IStruct");
    }
}