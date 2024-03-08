using System.IO;
using System;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Management;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main()
        {
            //string[] ports = SerialPort.GetPortNames();

            //foreach (string element in ports)
            //{
            //    Console.WriteLine(element + "\r\n");
            //}

            SerialPortManager manager = new SerialPortManager("COM1", "COM2");
            manager.ConfigurePorts();
            await manager.ReadWriteDataInParallel();
        }
        //private static void Main(string[] args)
        //{
        //    // Get a list of serial port names.
        //    using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
        //    {
        //        var portnames = SerialPort.GetPortNames();
        //        var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

        //        var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

        //        foreach (string s in portList)
        //        {
        //            Console.WriteLine(s);
        //        }
        //    }
        //}

    }
}
