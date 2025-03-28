namespace csharp_11.Features;

public class RawString
{
    public void Test()
    {
        string longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    """;

        Console.WriteLine(longMessage);
        var Longitude = 10;
        var Latitude = 11;
        var location = $$"""
   You are at {{{Longitude}}, {{Latitude}}}
   """;
    }
}