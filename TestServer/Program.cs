using DriverInstaller;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/api/devices", (string projectName, string token) =>
{
    var devices = new List<DeviceInfo>
    {
        new DeviceInfo { DeviceName = "Printer1", DeviceModel = "Model1", DeviceType = "Printer" },
        new DeviceInfo { DeviceName = "Printer2", DeviceModel = "Model2", DeviceType = "Printer" }
    };

    return Results.Ok(devices);
});

app.MapGet("/api/drivers/{deviceModel}", (string deviceModel) =>
{

    byte[] driverBytes = GetDriverBytesForDeviceModel(deviceModel);

    if (driverBytes == null)
    {
        return Results.NotFound();
    }

    var response = Results.Ok(driverBytes);
    return response;
});

byte[] GetDriverBytesForDeviceModel(string deviceModel)
{
    string driverFilePath = Path.Combine("Drivers", $"{deviceModel}.exe");
    if (File.Exists(driverFilePath))
    {
        return File.ReadAllBytes(driverFilePath);
    }
    else
    {
        return null;
    }
}



app.Run();
