using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.Threading;
using System.Collections;


namespace ComTest_1_2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool _continue;
        static SerialPort _serialPort;
        static Queue sendQueue = new Queue();
        static Queue recQueue = new Queue();
        public MainWindow()
        {
            string message;
            InitializeComponent();

            

            Thread readThread = new Thread(Read);

            // Create a new serial port
            _serialPort =new SerialPort();

            // Allow the user to set the appropriate properties
            _serialPort.PortName = "COM1";
            _serialPort.BaudRate = 9600;

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();
            _continue = true;
            readThread.Start();

            while (_continue)
            {
                message = Convert.ToString(sendQueue);
                if (message.Equals("quit"))
                {
                    _serialPort.WriteLine(string.Format("{0}", sendQueue.Dequeue()));
                    recLabel.Content = recQueue.Dequeue();
                }
            }

            readThread.Join();
            _serialPort.Close();

        }

        private void SendBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sendQueue.Enqueue(Convert.ToString(SendBox));
        }

//        public static string SetPortName(string defaultPortName)
//        {
//            string portName;
//           // TODO
//           return portName;
//        }
       

        public static void Read()
        {
            while(true)
            {
                try
                {
                    recQueue.Enqueue(_serialPort.ReadLine());
                    // string message = _serialPort.ReadLine();
                    // MainWindow.recLabel.Content = Convert.ToString(recQueue.Dequeue());
                }
                catch (TimeoutException) { }
            }
        }

    }
}
