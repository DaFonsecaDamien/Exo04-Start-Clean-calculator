namespace NumberOperations;

public class NumberProcessor
{
    public int ProcessFile(string filename, string operation, bool enableLogging)
        {
            if (enableLogging)
                Logger.Log($"applying operation {GetOperation(operation)}");
            
            var total = operation == "*" ? 1 : 0;
            
            using (var reader = new StreamReader(filename))
            {
                string line;
                var lineNumber = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line, out var number))
                    {
                        if (enableLogging)
                            Logger.Log($"parsed value = {number}");
                        
                        // if first number print it
                        if (lineNumber == 1)
                        {
                            Console.WriteLine($"{number}");
                            total = number;
                        }
                        else
                        {
                            total = DoOperation(total, number, operation);
                            Console.WriteLine($"{operation}{number} (= {total})");
                        }

                        if (enableLogging)
                            Logger.Log($"accumulation : {total} on line {lineNumber}");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Invalid number on line {lineNumber}: {line}");
                    }

                    lineNumber++;
                }
            }

            Console.WriteLine("-------");
            Console.WriteLine($"Total = {total}" + $" ({GetOperation(operation)})");

            return total;
        }
    
    private static string GetOperation(string operation)
    {
        return operation switch
        {
            "+" => "addition",
            "-" => "subtraction",
            "*" => "multiplication",
            _ => "invalid operation"
        };
    }
    
    private static int DoOperation(int total, int number, string operation)
    {
        return operation switch
        {
            "+" => total + number,
            "-" => total - number,
            "*" => total * number,
            _ => total
        };
    }
}