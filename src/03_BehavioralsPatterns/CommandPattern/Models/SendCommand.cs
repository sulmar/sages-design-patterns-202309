using System;

namespace CommandPattern
{
    public class SendCommand : ICommand
    {
        private readonly Message message;

        public SendCommand(Message message)
        {
            this.message = message;
        }

        public bool CanExecute()
        {
            return !(string.IsNullOrEmpty(message.From) || string.IsNullOrEmpty(message.To) || string.IsNullOrEmpty(message.Content));
        }

        public void Execute()
        {
            Console.WriteLine($"Send message from <{message.From}> to <{message.To}> {message.Content}");
        }
    }

}
