using System;
using System.IO.Ports;
using System.Windows;

namespace ProgettoPlotter.Classes
{
    class CSerialPort
    {
        /* Properties */
        public SerialPort COM { get; set; }

        /* Constructor */
        public CSerialPort()
        {
            COM = new SerialPort();
        }

        /* Methods */
        public void ConnectTo(string PortName)
        {
            try
            {
                COM.PortName = PortName;  /* Set serial port name */

                if (!COM.IsOpen) /* If port is not opened */
                {
                    COM.Open();  /* Open port */
                    MessageBox.Show("Connection estabilished!");
                }
                    
                else
                    MessageBox.Show("Already connected to this port"); /* Show error message */
            }
            catch (Exception)
            {
                MessageBox.Show("Selected serial port does not exist!"); /* Show error message */
            }
        }

    }
}
