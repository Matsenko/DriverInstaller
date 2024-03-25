using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverInstallerWinForms
{
    public partial class Form4 : Form
    {
        private List<string> _InstalledDevices;

        public Form4(List<string> installedDevices)
        {
            InitializeComponent();
            _InstalledDevices = installedDevices;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(_InstalledDevices.ToArray());
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
