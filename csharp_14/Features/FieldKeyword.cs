namespace csharp_14.Features;

public class FieldKeyword
{
    public static void Test()
    {
        var obj = new FieldKeyword() { Message = "Hello, World!" };
        Console.WriteLine(obj.Message);
    }
    //private string _msg;
    //public string Message
    //{
    //    get => _msg;
    //    set => _msg = value ?? throw new ArgumentNullException(nameof(value));
    //}

    public string Message
    {
        get;
        set => field = value ?? throw new ArgumentNullException(nameof(value));
    }
}