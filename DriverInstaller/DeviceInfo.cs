using System.Text.Json.Serialization;

namespace DriverInstaller;

public class DeviceInfo
{
    [JsonPropertyName("deviceName")]
    public string DeviceName { get; set; }

    [JsonPropertyName("deviceModel")]
    public string DeviceModel { get; set; }

    [JsonPropertyName("deviceType")]
    public string DeviceType { get; set; }
}