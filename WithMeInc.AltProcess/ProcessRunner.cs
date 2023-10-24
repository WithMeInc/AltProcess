namespace PrnLib.AltProcess;

public class ProcessRunner : IRunner
{
    public Result Run(string command, string[] args)
    {
        using (System.Diagnostics.Process process = new System.Diagnostics.Process())
        {
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = command;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            foreach (var arg in args)
            {
                process.StartInfo.ArgumentList.Add(arg);
            }

            process.Start();

            process.WaitForExit();

            return new Result(
                process.ExitCode,
                process.StandardOutput,
                process.StandardError
            );
        }
    }
}
