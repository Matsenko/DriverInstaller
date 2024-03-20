namespace DriverInstaller;

public interface IDriverInstall
{
    Task<bool> InstallDriver(string driverPath);
}

