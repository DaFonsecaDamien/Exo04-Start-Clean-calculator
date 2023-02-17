namespace NumberOperations
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cmdArgs = new CommandLineArguments();

            if (!cmdArgs.Parse(args))
            {
                return;
            }
            
            if (cmdArgs.EnableLogging)
            {
                Logger.Log($"started");
            }
            
            var numberProcessor = new NumberProcessor();
            numberProcessor.ProcessFile(cmdArgs.Filename, cmdArgs.Operation, cmdArgs.EnableLogging);

            if (cmdArgs.EnableLogging)
            {
                Logger.Log($"end of program.");
            }
        }
    }
}