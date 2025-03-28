namespace csharp_13.Features;

public class RefUnsafeAsyns
{
    public unsafe void MultiplyNumbers(int* numbers, int count)
    {
        for (int i = 0; i < count; i++)
        {
            // Yield return with an unsafe pointer
            Console.WriteLine(numbers[i]);
        }
    }
    public void Test()
    {
        int[] list = [1,2,3,4,5,6,7,8,9];
        unsafe
        {
            fixed (int* p = list)
            {
                MultiplyNumbers(p, list.Length);
            }
        }
    }
}