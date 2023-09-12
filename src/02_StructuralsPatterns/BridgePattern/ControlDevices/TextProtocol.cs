namespace BridgePattern.ControlDevices
{
    // Concrete Implementor A
    public class TextProtocol : IProtocolImplementor
    {
        public string GetSetChannelMessage(byte channel)
        {
            return $"SET CHANNEL {channel}";
        }

        public string GetSwitchOffMessage()
        {
            return "OFF";
        }

        public string GetSwitchOnMessage()
        {
            return "ON";
        }
    }
}
