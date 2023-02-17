namespace NumberOperations;

public class Logger
{
    public static void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HHmmss:ffffff}][log] {message}");
    }
}