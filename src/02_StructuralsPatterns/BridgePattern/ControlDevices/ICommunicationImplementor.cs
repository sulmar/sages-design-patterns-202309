namespace BridgePattern.ControlDevices
{
    // Communication (RS232, TCP)
    // Protocol (Text, XML, JSON, binary)

    // Abstract Implementor 
    public interface ICommunicationImplementor
    {
        void OpenConnection();
        string Send(string data);
        void CloseConnection();
    }
}
