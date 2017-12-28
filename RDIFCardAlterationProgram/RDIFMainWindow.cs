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
                Thread.Sleep(1500);
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
                        
                        returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                        count--;
                    }
                    //Console.WriteLine(returnMessage);
                //Console.WriteLine(returnMessage.Split(':')[1]);
                string uid = returnMessage.Split(':')[1];
                string hashedByBase = returnMessage.Split(':')[2];
                manData.Text = hashedByBase;





            }
            catch (Exception e)
            {

            }
        }

        private void getCard_Click(object sender, EventArgs e)
        {
            GetCardData();
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            //we need some unique data such as the timecode
            long temp = DateTime.Now.ToBinary();
            dataWriteBox.Text = temp.ToString();
        }

        private void DataWrite_Click(object sender, EventArgs e)
        {
            string data = dataWriteBox.Text;
            long dataLong = Convert.ToInt64(dataWriteBox.Text);
            //clean the buffer before getting another command
            currentPort.DiscardOutBuffer();
            currentPort.DiscardInBuffer();
            Console.WriteLine(dataLong);
            try
            {
                //The below setting are for the Hello handshake
                byte[] buffer = new byte[4];
                //16 means message
                buffer[0] = Convert.ToByte(16);
                //128 is the number for checking if the ardunio exists
                buffer[1] = Convert.ToByte(131);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
               

                //4 is end of message
                

                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                if (!currentPort.IsOpen)
                {
                    currentPort.Open();
                }
                //clean the buffer before getting another command
                currentPort.DiscardOutBuffer();
                currentPort.DiscardInBuffer();
                currentPort.Write(buffer, 0, 4);
                //we create base64 of datalong
                string dataBase64 = Convert.ToBase64String(BitConverter.GetBytes(dataLong));
                Console.WriteLine(dataBase64);
                byte[] writeData = Encoding.ASCII.GetBytes(dataBase64);
                Console.WriteLine("byte array length: "+writeData.Length);
                currentPort.Write(writeData, 0, writeData.Length);
                byte[] temp = new byte[2];
                temp[0] = Convert.ToByte(Convert.ToInt32(accessLevel.Text));
                temp[1] = Convert.ToByte(4);
                currentPort.Write(temp, 0,2);

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

                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }
                Console.WriteLine("We have data");
                Console.WriteLine(returnMessage);


            }
            catch (Exception e1)
            {

            }
        }

        private void dataRead_Click(object sender, EventArgs e)
        {
            try
            {

               
                byte[] buffer = new byte[5];
                //16 means message
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(132);
                buffer[2] = Convert.ToByte(0);
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
                byte[] temp = new byte[currentPort.BytesToRead];
                currentPort.Read(temp, 0, currentPort.BytesToRead);
                int accessLevel = temp[count - 1];

                foreach(byte b in temp)
                {

                    intReturnASCII = b;

                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }
                

                Console.WriteLine(returnMessage);
                Console.WriteLine(accessLevel);







            }
            catch (Exception e1)
            {

            }
        }

        private void DumpData_Click(object sender, EventArgs e)
        {
            try
            {
                //The below setting are for the Hello handshake
                byte[] buffer = new byte[5];
                //16 means message
                buffer[0] = Convert.ToByte(16);
                //128 is the number for checking if the ardunio exists
                buffer[1] = Convert.ToByte(100);
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

                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }
                Console.WriteLine(returnMessage);
                





            }
            catch (Exception e1)
            {

            }
        }
    }
}
