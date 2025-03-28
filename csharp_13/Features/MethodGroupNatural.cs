namespace csharp_13.Features;

public class MethodGroupNatural
{
    public void Test()
    {
        //var printer = new Printer();
        //var printMethodGroup = printer.Print;
        var printer = new Printer();
        Action<int> printInt = printer.Print;
        Action<string> printString = printer.Print;
        Action<object> printGeneric = printer.Print;
    }
}

public class Printer
{
    public void Print(int value)
    {
        Console.WriteLine($"Printing int: {value}");
    }

    public void Print(string value)
    {
        Console.WriteLine($"Printing string: {value}");
    }

    public void Print<T>(T value)
    {
        Console.WriteLine($"Printing generic: {value}");
    }
}