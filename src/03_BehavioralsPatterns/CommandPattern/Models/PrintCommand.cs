using System;

namespace CommandPattern
{
    public class PrintCommand : ICommand 
    {
        private readonly Message message;

        public int Copies { get; private set; }

        public PrintCommand(Message message, int copies = 1)
        {
            this.message = message;

            Copies = copies;
        }

        public void Execute()
        {
            for (int i = 0; i < Copies; i++)
            {
                Console.WriteLine($"Print message from <{message.From}> to <{message.To}> {message.Content}");
            }
        }

        public bool CanExecute()
        {
            return string.IsNullOrEmpty(message.Content);
        }
    }

}
