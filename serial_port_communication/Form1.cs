using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial_port_communication
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort serialPort;
        delegate void delegate1();
        delegate1 mydelegate;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            mydelegate = new delegate1(displayReceived);

        }
        private void displayReceived(/*object sender, SerialDataReceivedEventArgs e*/)
        {
            string message = "";
            try
            {
                message = serialPort.ReadLine();
            }
            catch (Exception ex)
            {
                message = "Receiving message goes wrong";
            }
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            ReceivedTextBox.Invoke(mydelegate);
        }
        private void Connect_button_Click(object sender, EventArgs e)
        {
            
            if (serialPort.IsOpen)
            {
                MessageBox.Show("Already connected to the device");
                Connect_button.BackColor = Color.Green;
            }
            else
                try
                {
                    serialPort.PortName = this.COM_comboBox.Text;
                    serialPort.BaudRate = Int32.Parse(this.Baud_Rate_comboBox.Text);
                    serialPort.DataBits = Int32.Parse(this.Data_Bits_comboBox.Text);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.Stop_bits_comboBox.Text);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.Parity_comboBox.Text);
                    serialPort.Open();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Connection error: " + exc.Message);
                    Connect_button.BackColor = Color.Red;
                }
        }
 
        private void Send_button_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine(SendTextBox.Text);
            SendTextBox.Text = "";
        }
        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Refresh_button.Text = Char.ConvertFromUtf32(81);
            updateAvailablePorts();
        }

        private void updateAvailablePorts()
        {
            COM_comboBox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                COM_comboBox.Items.Add(s);
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            SendTextBox.Clear();
            ReceivedTextBox.Clear();
        }

      
    }
}
