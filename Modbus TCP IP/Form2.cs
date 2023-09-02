using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using NModbus;

namespace Modbus_TCP_IP
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Dictionary<string, string> dataDict;
        private IModbusMaster modbusMaster;
        private string[] registerNames = { "Name1", "Name2", "Name3", "Name4", "Name5", "Name6", "Name7", "Name8", "Name9", "Name10" };
        private Timer updateTimer;
        private bool errorMessageDisplayed = false;
        private string receivedData = "";

        public Form2(Form1 form1Instance)
        {
            InitializeComponent();
            updateTimer = new Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;
            MaskedtxtIPAddress.Enabled = false;

            // Store the reference to Form1
            form1 = form1Instance;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                SomeModbusFunction();
            }
            catch (Exception ex)
            {
                if (!errorMessageDisplayed)
                {
                    MessageBox.Show($"Modbus communication error: {ex.Message}", "Modbus Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorMessageDisplayed = true;
                }
            }
        }

        public void SetData(string data)
        {
            receivedData = data;
        }

        private void RBipv4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RBipv4.Checked)
            {
                ShowIPAddressFormatMessage("IPv4");
                MaskedtxtIPAddress.Enabled = true;
            }
        }

        private void RBipv6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RBipv6.Checked)
            {
                ShowIPAddressFormatMessage("IPv6");
                MaskedtxtIPAddress.Enabled = true;
            }
        }

        private void ShowIPAddressFormatMessage(string format)
        {
            string exampleIP = format == "IPv4" ? "192.168.0.17" : "2001:0db8:85a3:0000:0000:8a2e:0370:7334";
            MessageBox.Show($"Please enter an IP address like this: {exampleIP}", "IP Address Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            comBoxConnection.Text = "";
            MaskedtxtIPAddress.Text = string.Empty;
            txtServerPort.Text = "502";
            txtConnectTimeout.Text = "3000";
            txtResponseTimeout.Text = "1000";
            txtDelayBetPolls.Text = "500";
            this.Close();
        }

        private bool InitializeModbusMaster()
        {
            errorMessageDisplayed = false;

            if (string.IsNullOrEmpty(comBoxConnection.Text) || comBoxConnection.Text == " ")
            {
                MessageBox.Show("Please select a valid connection type (Modbus TCP/IP).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(MaskedtxtIPAddress.Text))
            {
                MessageBox.Show("Please enter an IP address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!RBipv4.Checked && !RBipv6.Checked)
            {
                MessageBox.Show("Please select either IPv4 or IPv6.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            IPAddress ipAddress;
            if (RBipv4.Checked)
            {
                if (!IPAddress.TryParse(MaskedtxtIPAddress.Text, out ipAddress) || ipAddress.AddressFamily != AddressFamily.InterNetwork)
                {
                    MessageBox.Show("Please enter a valid IPv4 address.", "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (RBipv6.Checked)
            {
                if (!IPAddress.TryParse(MaskedtxtIPAddress.Text, out ipAddress) || ipAddress.AddressFamily != AddressFamily.InterNetworkV6)
                {
                    MessageBox.Show("Please enter a valid IPv6 address.", "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtServerPort.Text))
            {
                MessageBox.Show("Please enter a Port number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtConnectTimeout.Text))
            {
                MessageBox.Show("Please enter a Connect Timeout value.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtResponseTimeout.Text))
            {
                MessageBox.Show("Please enter a Response Timeout value.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtDelayBetPolls.Text))
            {
                MessageBox.Show("Please enter a Delay Between Polls value.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                string ipAddressStr = MaskedtxtIPAddress.Text;
                int port = int.Parse(txtServerPort.Text);

                var tcpClient = new TcpClient(ipAddressStr, port);

                var factory = new ModbusFactory();
                modbusMaster = factory.CreateMaster(tcpClient);

                modbusMaster.Transport.Retries = 3;
                modbusMaster.Transport.WaitToRetryMilliseconds = 1000;

                return true;
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Unable to connect to the Modbus slave: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing Modbus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void SomeModbusFunction()
        {
            ushort startAddress = 0;
            ushort numRegisters = 10;
            ushort[] registers = modbusMaster.ReadHoldingRegisters(1, startAddress, numRegisters);

            for (int i = 0; i < numRegisters; i++)
            {
                txtData.AppendText($"{registerNames[i]}: {registers[i]}\r\n");
            }

            // Assuming you want to update Form1's table with this data
            dataDict = new Dictionary<string, string>();
            for (int i = 0; i < numRegisters; i++)
            {
                dataDict[registerNames[i]] = registers[i].ToString();
            }

            if (form1 != null)
            {
                // Update Form1's table
                form1.UpdateTable(dataDict);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InitializeModbusMaster())
            {
                updateTimer.Start();
            }
        }

        private void comBoxConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxConnection.SelectedItem != null && comBoxConnection.SelectedItem.ToString() == "Modbus TCP/IP")
            {
                gBoxRemoteModbusServer.Enabled = true;
            }
            else
            {
                gBoxRemoteModbusServer.Enabled = false;
            }
        }
    }
}
