using DriverInstaller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverInstallerWinForms
{
    public partial class Form3 : Form
    {
        private IEnumerable<DeviceInfo> _devices;
        private List<string> _InstalledDevices;
        public Form3(IEnumerable<DeviceInfo> devices)
        {
            InitializeComponent();
            _devices = devices;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (_devices != null)
            {
                foreach (var device in _devices)
                {
                    checkedListBox1.Items.Add(device.DeviceName);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private async void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                string selectedDevice = checkedListBox1.Items[e.Index].ToString();
                DeviceInfo deviceInfo = await GetDeviceInfoByName(selectedDevice);
                string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
                RentPrintAPI rentPrintAPI = new RentPrintAPI(baseUrl);
                byte[] driverBytes = await rentPrintAPI.GetDriver(deviceInfo);
                string driverString = Convert.ToBase64String(driverBytes);
                DriverInstaller.DriverInstaller driverInstaller = new DriverInstaller.DriverInstaller();
                driverInstaller.InstallDriver(driverString);
                _InstalledDevices.Add(selectedDevice);
            }
        }
        private Task<DeviceInfo> GetDeviceInfoByName(string deviceName)
        {
 
            var device = _devices.FirstOrDefault(d => d.DeviceName == deviceName);

            if (device != null)
            {
                return Task.FromResult(device);
            }
            else
            {
                throw new Exception($"Device with name '{deviceName}' not found.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_InstalledDevices);
            form4.Show();
            this.Hide();
        }
    }
}
