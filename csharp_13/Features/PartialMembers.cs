namespace csharp_13.Features;

public class PartialMembers
{
    public void Test()
    {
        var c = new C();
        c.Name = "John Doe";
        Console.WriteLine(c.Name);
    }
}

public partial class C
{
    // Declaring declaration
    public partial string Name { get; set; }
}

public partial class C
{
    // implementation declaration:
    private string _name;
    public partial string Name
    {
        get => _name;
        set => _name = value;
    }
}