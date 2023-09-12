namespace BridgePattern.ControlDevices
{
    public class ControlDevice : IControlDevice
    {
        protected ICommunicationImplementor _communication;
        protected IProtocolImplementor _protocol;

        public ControlDevice(ICommunicationImplementor communication, IProtocolImplementor protocol)
        {
            _communication = communication;
            _protocol = protocol;
        }

        public void Connect()
        {
            _communication.OpenConnection();
        }

        public void Disconnect()
        {
            _communication.CloseConnection();
        }

        public void SwitchOff()
        {
            _communication.Send(_protocol.GetSwitchOffMessage());
        }

        public void SwitchOn()
        {
            _communication.Send(_protocol.GetSwitchOnMessage());
        }
    }
}
