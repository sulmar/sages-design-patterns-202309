using NGeoHash;
using System;

namespace AdapterPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Adapter Pattern!");

            MotorolaRadioTest();

            HyteraRadioTest();

        }

        private static void MotorolaRadioTest()
        {
            IRadioAdapter radio = new MotorolaRadioAdapter("1234");
            radio.SendMessage("Hello World!", 10);
        }

        private static void HyteraRadioTest()
        {
            IRadioAdapter radio = new HyteraRadioAdapter();
            radio.SendMessage("Hello World!", 10);            
        }
    }

    


}
