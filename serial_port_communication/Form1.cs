using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Globalization;
namespace serial_port_communication
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort serialPort;
        delegate void delegate1();
        delegate1 mydelegate;
        TextWriter txt = new StreamWriter("data.txt");
        Stopwatch stopwatch = new Stopwatch();
        bool flag;
        int duty = 0;
        float temp_min;
        string value;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            mydelegate = new delegate1(displayReceived);
            chart1.Series["Temperature"].BorderWidth = 3;
            chart1.Series["Set temperature"].BorderWidth = 3;
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



            if (checkBox1.Checked && !checkBox3.Checked)
            {
                CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                ci.NumberFormat.CurrencyDecimalSeparator = ".";
                ReceivedTextBox.Text = message;
                stopwatch.Start();
                var seconds = stopwatch.ElapsedMilliseconds / 1000;
                if (seconds<5 && seconds>1)
                {
                    temp_min = float.Parse(message, NumberStyles.Any, ci);
                }
                chart1.Series["Temperature"].Points.AddXY(seconds, message);
                chart1.Series["Set temperature"].Points.AddXY(seconds, duty);
                if (flag != true)
                {
                    txt.Write(message);
                    txt.Write(seconds);

                }

            }

            if (checkBox3.Checked)
            {
                flag = true;
                txt.Close();
                stopwatch.Stop();
            }
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            ReceivedTextBox.Invoke(mydelegate);
        }


        private void Connect_button_Click(object sender, EventArgs e)
        {
            Connect_button.BackColor = Color.LightGreen;
            if (serialPort.IsOpen)
            {
                
                MessageBox.Show("Already connected to the device");
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

            if (serialPort.IsOpen)
            {
                value = SendTextBox.Text;
                if (float.Parse(value) >= temp_min && float.Parse(value) <= 40)
                {
                    duty = int.Parse(value);
                    serialPort.Write(value);
                    SendTextBox.Clear();
                    SetTemp.Text = value;

                }
                else {

                    duty = 0;
                    MessageBox.Show("Choose a temperature value between " + temp_min + "°C and 40°C");
                }
                    
            }
            else
            {
                MessageBox.Show("You have no connection to the device");
            }

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
            chart1.Series["Temperature"].Points.Clear();
            chart1.Series["Duty"].Points.Clear();
            SendTextBox.Clear();
            ReceivedTextBox.Clear();
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            updateAvailablePorts();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string value = "01";
            serialPort.Write(value);
        }
        private void SendChartbutton_Click(object sender, EventArgs e)
        {
            string pathImage = Environment.CurrentDirectory + "\\temperatureChart.png";
            chart1.SaveImage(pathImage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            MessageBox.Show("Chart saved to the files");
        }
    }
}
