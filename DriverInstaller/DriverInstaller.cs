using System.Diagnostics;

namespace DriverInstaller;

public class DriverInstaller : IDriverInstall
{
    public async Task<bool> InstallDriver(string driverPath)
    {
        try
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "pnputil.exe",
                Arguments = $"/add-driver \"{driverPath}\" /install",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (var process = new Process { StartInfo = startInfo })
            {
                process.Start();
                while (!process.StandardOutput.EndOfStream)
                {
                    var line = await process.StandardOutput.ReadLineAsync();
                    Debug.WriteLine(line);
                }

                await process.WaitForExitAsync();
                return process.ExitCode == 0;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error installing driver: {ex.Message}");
            return false;
        }
    }
}