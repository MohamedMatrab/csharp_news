namespace csharp_12.Features;

public class RefReadOnly
{
    public void Test()
    {
        var l = "Matrab Mohamed";
        TestMethod(l);
    }
    public void TestMethod(in string p)
    {
        //Cant Modify
        //p = ";";

        Console.WriteLine(p);
    }
}