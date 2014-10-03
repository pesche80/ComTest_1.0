using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace ComTest_1_4
{
    class Program
    {
        static SerialPort _serialPort;
        static bool _continue = false;
        static void Main(string[] args)
        {
            string name;
            string message;
            string[] ArrayComPorts = null;
            int iArray = 0;
            string comPortName = null;

            
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            //Thread readThread = new Thread(Read);
            
            // Create a new SerialPort object with deafault settings.
            _serialPort = new SerialPort();

            // Get COM port names
            ArrayComPorts = SerialPort.GetPortNames();
            Console.WriteLine("Available COM Ports:");

            for (iArray = 0; iArray <= ArrayComPorts.GetUpperBound(0); iArray++)
            {
                Console.Write(" {0}\n", ArrayComPorts[iArray]);
            }

            // allow the user to set the appropriate properties
            Console.WriteLine("\nSet COM Port: ");
            _serialPort.PortName = Console.ReadLine();
            Console.WriteLine("\nSet baud rate: ");
            _serialPort.BaudRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSet parity (None, Odd, Even, Mark, Space): ");
            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), Console.ReadLine());
            Console.WriteLine("\nSet data bits (5...8): ");
            _serialPort.DataBits = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nSet stop bits (One, OnePointFife, Two): ");
            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Console.ReadLine());
            Console.WriteLine("\nSet handshaking (None, RequestToSend, RequestToSendXOnXOff): ");
            _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), Console.ReadLine());

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

            _serialPort.Open();
            _continue = true;
            //readThread.Start();

            Console.WriteLine("Type QUIT to exit");

            while (_continue)
            {
                message = Console.ReadLine();

                if (stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
                else
                {
                    _serialPort.WriteLine(String.Format("{0}", message));
                }
            }

            //readThread.Join();
            _serialPort.Close();
        }

        private static void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort incomePort = (SerialPort)sender;
            string incomeData = incomePort.ReadExisting();
            Console.WriteLine(incomeData + "\n");
        }

        //private static void Read(object obj)
        //{
        //    while (_continue)
        //    {
        //        try
        //        {
        //            string message = _serialPort.ReadLine();
        //            Console.WriteLine(message);
        //        }
        //        catch (TimeoutException)
        //        {
        //            //Console.WriteLine(e);
        //        }
        //    }
        //}
    }
}
