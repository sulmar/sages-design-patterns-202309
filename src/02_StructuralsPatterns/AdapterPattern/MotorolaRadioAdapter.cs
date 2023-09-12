namespace AdapterPattern
{
    // Wariant obiektowy

    // Concrete Adapter A
    public class MotorolaRadioAdapter : IRadioAdapter
    {
        // Adaptee
        private MotorolaRadio radio = new MotorolaRadio();

        private string pincode;

        public MotorolaRadioAdapter(string pincode)
        {
            this.pincode = pincode;
        }

        public void SendMessage(string message, byte channel)
        {
            radio.PowerOn(pincode);
            radio.SelectChannel(channel);
            radio.Send(message);
            radio.PowerOff();
        }        
    }
}
