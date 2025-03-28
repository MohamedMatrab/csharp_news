namespace csharp_12.Features;

public class PrimaryContructor
{
    public void Test()
    {
        var pc1 = new PrimaryCtrClass("ddd", 2333);
        var pc2 = new PrimaryCtrClass("ddd", 2333, 122);

        var ps1 = new PrimaryCtrStruct("ddd",2333);
        var ps2 = new PrimaryCtrStruct("ddd", 2333,122);
    }
}

public class PrimaryCtrClass(string name,int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public int Birthday { get; set; }

    public PrimaryCtrClass(string name, int age,int birthday) : this(name, age)
    {
        //Here the other contructor
    }
}

public struct PrimaryCtrStruct(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public int Birthday { get; set; }

    public PrimaryCtrStruct(string name, int age, int birthday) : this(name, age)
    {
        //Here the other contructor
    }
}
