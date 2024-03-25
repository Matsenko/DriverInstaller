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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = textBox1.Text;
                string accessCode = textBox2.Text;
                string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
                RentPrintAPI rentPrintAPI = new RentPrintAPI(baseUrl);
                var devices = await rentPrintAPI.GetDeviceInfo(projectName, accessCode);
                Form3 form3 = new Form3(devices);
                form3.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
 
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

