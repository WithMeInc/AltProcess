namespace PrnLib.AltProcess;

public class Result
{
    public Result(int ExitCode, StreamReader StandardOutput, StreamReader StandardError)
    {
        this.ExitCode = ExitCode;
        this.StandardOutput = StandardOutput;
        this.StandardError = StandardError;
    }

    public int ExitCode;

    public StreamReader StandardOutput;
    public StreamReader StandardError;
}
