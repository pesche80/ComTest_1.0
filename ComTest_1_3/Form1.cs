using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComTest_1_3
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();
        public Form1()
        {
            //  Initialize Window
            InitializeComponent();

            //  Add baudrates to dropdown
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600);
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();
            cboBaudRate.Text = cboBaudRate.Items[0].ToString();
        }

        /// <summary>
        ///  Reacts to a click on the button "Ports"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
                string[] ArrayComPortsNames = null;                     // Array for the names of connected COM Ports
                int index = -1;                                         // index for COM Port array
                string ComPortName = null;                              // string for chosen Port Name

                btnPortState.Text = "closed";                           // write "closed" to button
                ArrayComPortsNames = SerialPort.GetPortNames();         // look for installed COM Ports on computer and write in the array

                do                                                      // write all installed COM Port names to the dropdown
                {
                    index += 1;
                    cboPorts.Items.Add(ArrayComPortsNames[index]);
                    // rtbIncomingData.Text += ArrayComPortsNames[index] + "\n";
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));

                Array.Sort(ArrayComPortsNames);                         // sort COM Port array

                if (index == ArrayComPortsNames.GetUpperBound(0))       // if only one COM Port installed
                {
                    ComPortName = ArrayComPortsNames[0];                // choose this COM Port
                }
                cboPorts.Text = ArrayComPortsNames[0];                  // write the first COM Port name visible to the dropdown

               
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPortState_Click(object sender, EventArgs e)     // if Port State button is clicked
        {
            if (btnPortState.Text == "open")                            // and a COM Port is opened
            {
                ComPort.Close();                                        // close COM Port
                btnPortState.Text = "closed";                           // and write closed on the button
            }




            else                                                        // if no COM Port is opened
            {
                try
                {
                    ComPort.PortName = Convert.ToString(cboPorts.Text); // try to set chosen COM Port
                    ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);   // and chosen baudrate
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);                        // show error message if name or baudrate could not be set
                }
                

                try
                {
                    ComPort.Open();                                     //  try to open the chosen COM Port
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);                        // show error message if the port opening was unautorized
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);                        // show error message if Port is already opened
                }

                if (ComPort.IsOpen)
                {
                    btnPortState.Text = "open";                         // write "open" to port state button, if port could be opened
                }
                else
                {
                    btnPortState.Text = "close";                        // write "closed" to port state button, if port could not be opened
                    rtbIncomingData.Text = "Port \"" + Convert.ToString(ComPort.PortName) + "\" could not be opened"; // and write wich port could not be opened to the rich text box
                }
            }
        }
    }
}
