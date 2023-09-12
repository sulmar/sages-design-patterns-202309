namespace BridgePattern.ControlDevices
{
    // Concrete Implementor B
    public class XmlProtocol : IProtocolImplementor
    {
        public string GetSetChannelMessage(byte channel)
        {
            return $"<command><channel>{channel}</channel></command>";
        }

        public string GetSwitchOffMessage()
        {
            return "<command>off</command>";
        }

        public string GetSwitchOnMessage()
        {
            return "<command>on</command>";
        }
    }
}
