namespace AdapterPattern
{
    // Abstract Adapter
    public interface IRadioAdapter
    {
       void SendMessage(string message, byte channel);
    }
}
