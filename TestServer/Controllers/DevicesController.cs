using DriverInstaller;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestServer.Controllers
{
    [ApiController]
    [Route("api/devices")]
    public class DevicesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<DeviceInfo> GetDevices(string projectName, string token)
        {
            // Здесь вы можете вернуть эмулированные данные устройств
            return new List<DeviceInfo>
            {
                new DeviceInfo { DeviceName = "Printer1", DeviceModel = "Model1", DeviceType = "Printer" },
                new DeviceInfo { DeviceName = "Printer2", DeviceModel = "Model2", DeviceType = "Printer" }
            };
        }
    }
}
