namespace csharp_14.Features;

public class MorePartialMembers
{
    public static void Test()
    {
        var prt = new PRTClass("Matrab", 22);
        prt.OnSomethingHappened("Hello");
    }
}

public partial class PRTClass(string name,int age)
{
    /// Declaring definition
    public partial void OnSomethingHappened(string s);
}

public partial class PRTClass
{
   
    // Comment out this method and the program
    // will still compile.
    public partial void OnSomethingHappened(string s) =>
        Console.WriteLine($"Something happened: {s}");
}