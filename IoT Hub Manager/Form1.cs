using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Common;

namespace IoT_Hub_Manager
{
    public partial class Form1 : Form
    {
        private RegistryManager registryManager;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRegisterDevice_Click(object sender, EventArgs e)
        {

            this.registryManager = RegistryManager.CreateFromConnectionString(txtConnectionString.Text);
            try
            {
                var device = new Device(txtDeviceName.Text);

                await registryManager.AddDeviceAsync(device);

                txtResult.AppendText($"{txtDeviceName.Text} registered successfully");
                txtResult.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtResult.AppendText(ex.Message);
                txtResult.AppendText(Environment.NewLine);
            }
        }

        private async void btnDeRegister_Click(object sender, EventArgs e)
        {
            this.registryManager = RegistryManager.CreateFromConnectionString(txtConnectionString.Text);
            try
            {
                await registryManager.RemoveDeviceAsync(txtDeviceName.Text);

                txtResult.AppendText($"{txtDeviceName.Text} deregistered successfully");
                txtResult.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtResult.AppendText(ex.Message);
                txtResult.AppendText(Environment.NewLine);
            }
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private async void btnGetDevices_Click(object sender, EventArgs e)
        {
            this.registryManager = RegistryManager.CreateFromConnectionString(txtConnectionString.Text);
            try
            {
                //Max 1000 devices retrieved. Increase value for more.
                var devices = await registryManager.GetDevicesAsync(1000);

                if (devices != null)
                {
                    foreach (var device in devices)
                    {
                        txtResult.AppendText($"Id: {device.Id}");
                        txtResult.AppendText(Environment.NewLine);
                    }
                }
                else
                {
                    txtResult.AppendText("No devices registered");
                    txtResult.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                txtResult.AppendText(ex.Message);
                txtResult.AppendText(Environment.NewLine);
            }

        }

        private async void btnGetDevice_Click(object sender, EventArgs e)
        {
            this.registryManager = RegistryManager.CreateFromConnectionString(txtConnectionString.Text);
            try
            {
                var device = await registryManager.GetDeviceAsync(txtDeviceName.Text);
                txtResult.AppendText($"{txtDeviceName.Text} information...");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"Authentication Key: {device.Authentication.SymmetricKey.PrimaryKey}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"CloudtoDeviceMessageCount: {device.CloudToDeviceMessageCount}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"ConnectionState: {device.ConnectionState}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"ConnectionStateUpdatedTime: {device.ConnectionStateUpdatedTime}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"ETag: {device.ETag}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"GenerationId: {device.GenerationId}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"Id: {device.Id}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"LastActivityTime: {device.LastActivityTime}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"Status: {device.Status}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"StatusReason: {device.StatusReason}");
                txtResult.AppendText(Environment.NewLine);
                txtResult.AppendText($"StatusUpdatedTime: {device.StatusUpdatedTime}");
                txtResult.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtResult.AppendText(ex.Message);
                txtResult.AppendText(Environment.NewLine);
            }
        }
    }
}
