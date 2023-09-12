using System;
using System.IO.Ports;

namespace BridgePattern.ControlDevices
{
    // Concrete Implementor A
    public class RS232Communication : ICommunicationImplementor
    {
        private SerialPort serialPort = new SerialPort();

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public string Send(string data)
        {
            return $"{data} sent by SerialPort";
        }
    }
}
