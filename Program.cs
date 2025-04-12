using System.Diagnostics;

namespace BeastExe
{
    internal static class Program
    {
        public static void Main()
        {
            var process = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "./.venv/scripts/python.exe",
                    Arguments = "./src/beast.py",
                    UseShellExecute = false
                }
            };
            process.Start();
            process.WaitForExit();
        }
    }
}
