namespace csharp_13.Features;

public class LockObj
{
    public void Test()
    {
        var counter = new ThreadSafeCounter();

        var threads = new List<Thread>();
        for (int i = 0; i < 10; i++)
        {
            var thread = new Thread(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    counter.Increment();
                }
            });
            thread.Start();
            threads.Add(thread);
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"Final Count: {counter.GetCount()}");
    }
}

public class ThreadSafeCounter
{
    private Lock _lock = new Lock();
    private int _count;

    public void Increment()
    {
        using (var scope = _lock.EnterScope())
        {
            _count++;
        }
    }

    public int GetCount()
    {
        lock (_lock)
        {
            return _count;
        }
    }
}