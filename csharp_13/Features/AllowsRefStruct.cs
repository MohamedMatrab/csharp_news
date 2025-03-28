namespace csharp_13.Features;

public class AllowsRefStruct
{
    public void Test()
    {
        var p = new AllowsRefStruct<TestRefStruct>();
    }
}

public ref struct TestRefStruct
{

}

public class AllowsRefStruct<T> where T : allows ref struct
{
    public void M(scoped T p)
    {
        // The parameter p must follow ref safety rules
    }
}