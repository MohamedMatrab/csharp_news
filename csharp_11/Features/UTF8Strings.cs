namespace csharp_11.Features;

public class UTF8Strings
{
    public void Test()
    {
        ReadOnlySpan<byte> utf8String = "Hello, UTF-8!"u8;
        string normalString = System.Text.Encoding.UTF8.GetString(utf8String);

        Console.WriteLine(normalString);

    }
}