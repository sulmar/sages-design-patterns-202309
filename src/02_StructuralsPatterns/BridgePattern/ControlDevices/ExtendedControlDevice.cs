namespace BridgePattern.ControlDevices
{
    public class ExtendedControlDevice : ControlDevice
    {
        public ExtendedControlDevice(ICommunicationImplementor communication, IProtocolImplementor protocol) : base(communication, protocol)
        {
        }

        public void SetChannel(byte channel)
        {
            _communication.Send(_protocol.GetSetChannelMessage(channel));
        }
    }
}
