namespace PrnLib.AltProcess;

public class TestRunner : IRunner
{
    private Result Result;
    public readonly List<Request> Requests;

    public TestRunner(Result result)
    {
        Result = result;
        Requests = new();
    }

    public Result Run(string command, string[] args)
    {
        Requests.Add(new Request(command, args));
        return Result;
    }

    public class Request
    {
        public Request(string command, string[] arguments)
        {
            Command = command;
            Arguments = arguments;
        }

        public readonly string Command;
        public readonly string[] Arguments;
    }

    public static StreamReader StandardStream(string lines)
    {
        MemoryStream ms = new MemoryStream();
        StreamWriter writer = new(ms);
        foreach (var line in lines)
        {
            writer.WriteLine(line);
        }

        ms.Seek(0, SeekOrigin.Begin);

        return new StreamReader(ms);
    }
}
