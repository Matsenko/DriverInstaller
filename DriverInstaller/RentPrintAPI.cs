using System.Text.Json;
using DriverInstaller;

public class RentPrintAPI : IRentPrintAPI
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public RentPrintAPI(string baseUrl)
    {
        _baseUrl = baseUrl;
        _httpClient = new HttpClient();
    }

    public async Task<IEnumerable<DeviceInfo>> GetDeviceInfo(string projectName, string token)
    {
        var url = $"{_baseUrl}/api/devices?project={projectName}&token={token}";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var devices = JsonSerializer.Deserialize<List<DeviceInfo>>(content);

        return devices;
    }

    public async Task<byte[]> GetDriver(DeviceInfo deviceInfo)
    {
        var driverUrl = $"{_baseUrl}/api/drivers/{deviceInfo.DeviceModel}";

        var response = await _httpClient.GetAsync(driverUrl);
        response.EnsureSuccessStatusCode();

        var driverBytes = await response.Content.ReadAsByteArrayAsync();
        return driverBytes;
    }
}