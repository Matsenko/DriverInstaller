using System.Diagnostics;
namespace DriverInstaller
{
    public class DriverInstaller : IDriverInstall
    {
        public async Task<bool> InstallDriver(string driverPath)
        {
            try
            {
                using var process = new Process();
                var startInfo = process.StartInfo;
                startInfo.FileName = "pnputil.exe";
                startInfo.Arguments = $"/add-driver \"{driverPath}\" /install";
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

                process.Start();

                while (!process.StandardOutput.EndOfStream)
                {
                    var line = await process.StandardOutput.ReadLineAsync();
                    Debug.WriteLine(line);
                }

                await process.WaitForExitAsync();
                return process.ExitCode == 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error installing driver: {ex.Message}");
                return false;
            }
        }
    }
}