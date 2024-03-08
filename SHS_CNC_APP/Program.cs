// See https://aka.ms/new-console-template for more information
using SHS_CNC_APP.Utils;

Console.WriteLine("SHS CNC Tester App");
SerialPorts.PrintPortNames();
SerialPorts.Equals("COM5", 11500);