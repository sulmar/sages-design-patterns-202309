using System;

namespace BridgePattern.ControlDevices
{
    // Concrete Implementor B
    public class TcpCommunication : ICommunicationImplementor
    {
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
            return $"{data} sent by TCP";
        }
    }
}
