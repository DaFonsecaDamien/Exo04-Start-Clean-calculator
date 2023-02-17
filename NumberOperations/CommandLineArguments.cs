namespace NumberOperations;

public class CommandLineArguments
{
    public string Filename { get; private set; }
    public string Operation { get; private set; }
    public bool EnableLogging { get; private set; }
    
    public bool Parse(string[] args)
    {
        if (args.Length < 2 || args.Length > 3)
        {
            Console.WriteLine("Usage: NumberOperations <filename> <operation> [-log]");
            return false;
        }

        Filename = args[0];
        Operation = args[1];
        EnableLogging = (args.Length == 3 && args[2] == "-log");

        return true;
    }
}