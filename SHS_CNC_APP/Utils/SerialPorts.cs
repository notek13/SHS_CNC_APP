using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHS_CNC_APP.Utils
{
    public class SerialPorts
    {
        public static string[] GetPortNames()
        {
            return System.IO.Ports.SerialPort.GetPortNames();
        }  
        
        public static void PrintPortNames()
        {
            string[] ports = GetPortNames();
            Console.WriteLine("Available Ports:");
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }
        }

        public bool InitPort(string portName, int baudRate)
        {
            return true;
        }   
    }
}
