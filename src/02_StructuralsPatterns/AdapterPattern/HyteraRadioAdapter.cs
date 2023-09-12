using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{

    // Concrete Adapter B
    public class HyteraRadioAdapter : IRadioAdapter
    {
        private HyteraRadio radio = new HyteraRadio();

        public void SendMessage(string message, byte channel)
        {
            radio.Init();
            radio.SendMessage(channel, message);
            radio.Release();
        }
    }
}
