namespace BridgePattern.ControlDevices
{
    // Abstract Implementor 
    public interface IProtocolImplementor
    {
        string GetSwitchOnMessage();
        string GetSwitchOffMessage();
        string GetSetChannelMessage(byte channel);
    }
   
}
