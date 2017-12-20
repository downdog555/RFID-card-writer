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
using System.Threading;

namespace RDIFCardAlterationProgram
{
    public partial class RDIFMainWindow : Form
    {
        private SerialPort currentPort = null;
        private bool portFound;

        public RDIFMainWindow()
        {
            InitializeComponent();
        }

        private void SetComPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    currentPort = new SerialPort(port, 9600);
                    if (DetectArduino(currentPort))
                    {
                        portFound = true;
                        break;
                    }
                    else
                    {
                        currentPort.Close();
                        portFound = false;
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        private bool DetectArduino(SerialPort port)
        {
            try
            {
                //The below setting are for the Hello handshake
                byte[] buffer = new byte[5];
                //16 means message
                buffer[0] = Convert.ToByte(16);
                //128 is the number for checking if the ardunio exists
                buffer[1] = Convert.ToByte(128);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                //4 is end of message
                buffer[4] = Convert.ToByte(4);

                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;



                if (!port.IsOpen)
                {
                    port.Open();
                    Console.WriteLine("Meow port has been opened");
                }
                else
                {
                    Console.WriteLine("port was already open");
                }
                port.Write(buffer, 0, 5);
                Thread.Sleep(1000);

                int count = port.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {

                    intReturnASCII = port.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }
                //ComPort.name = returnMessage;
                Console.WriteLine("We have data");



                if (returnMessage.Contains("HELLO FROM ARDUINO"))
                {
                    Console.WriteLine("We have arduino");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private void GetComPort_Click(object sender, EventArgs e)
        {
            //we need to call the method 
            SetComPort();
            if (currentPort != null)
            {
                PortName.Text = "Port: " + currentPort.PortName;
            }
            else
            {
                PortName.Text = "Device is not found.";
            }
        }

        private void GetCardData()
        {
            try
            {
                //The below setting are for the Hello handshake
                byte[] buffer = new byte[5];
                //16 means message
                buffer[0] = Convert.ToByte(16);
                //128 is the number for checking if the ardunio exists
                buffer[1] = Convert.ToByte(130);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                //4 is end of message
                buffer[4] = Convert.ToByte(4);

                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                if (!currentPort.IsOpen)
                {
                    currentPort.Open();
                }
                //clean the buffer before getting another command
                currentPort.DiscardOutBuffer();
                currentPort.DiscardInBuffer();
                currentPort.Write(buffer, 0, 5);
                int dataCheck = currentPort.BytesToRead;
                Thread.Sleep(1000);
                while (dataCheck != currentPort.BytesToRead)
                {

                    dataCheck = currentPort.BytesToRead;
                    Console.WriteLine("Sleeping....");
                    Thread.Sleep(1000);
                }

                
                    int count = currentPort.BytesToRead;
                    string returnMessage = "";
                    while (count > 0)
                    {

                    intReturnASCII = currentPort.ReadByte();
                    //returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                        count--;
                    }
                    Console.WriteLine(returnMessage);
                //Console.WriteLine(GetCardManufactureKey(returnMessage));
                //CardKey.Text = GetCardManufactureKey(returnMessage);
            
                



            }
            catch (Exception e)
            {

            }
        }

        private void getCard_Click(object sender, EventArgs e)
        {
            GetCardData();
        }

        private string GetCardManufactureKey(string data)
        {
            string key;
            string[] dataArray = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            //we then need to get the three bits of data
            string keyPart1 = dataArray[0].Split(':')[1];
            string keyPart2 = dataArray[1].Split(':')[1];
            string keyPart3 = dataArray[2].Split(':')[1];
            Console.WriteLine(dataArray.Length);
            
            //we use the card details that are dumped splitting on : should give an array of length 6 so we need every other value
            string keyData = keyPart1+keyPart2+keyPart3;
            byte[] tempKey = System.Text.ASCIIEncoding.ASCII.GetBytes(keyData);
            key = System.Convert.ToBase64String(tempKey);



            return key;

        }
    }
}
