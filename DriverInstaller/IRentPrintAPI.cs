namespace DriverInstaller;

public interface IRentPrintAPI
{
    Task<IEnumerable<DeviceInfo>> GetDeviceInfo(string projectName, string token);
    Task<byte[]> GetDriver(DeviceInfo deviceInfo);
}