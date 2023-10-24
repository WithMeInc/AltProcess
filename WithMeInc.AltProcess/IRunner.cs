namespace PrnLib.AltProcess;

public interface IRunner
{
    public Result Run(string command, string[] args);
}
