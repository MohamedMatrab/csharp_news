namespace csharp_14.Features;

public class LambdaParams
{
    delegate bool TryParse<T>(string text, out T result);
    public static void Test()
    {
        //TryParse<int> parse1 = (text, out result) => Int32.TryParse(text, out result);

        TryParse<int> parse2 = (string text, out int result) => Int32.TryParse(text, out result);
    }
}
