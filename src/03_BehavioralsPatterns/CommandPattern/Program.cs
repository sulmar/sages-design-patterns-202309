using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello Command Pattern!");

            Message message = new Message("555000123", "555888000", "Hello World!");

            ICommand printCommand = new PrintCommand(message, 3);
            ICommand sendCommand = new SendCommand(message);

            Stack<ICommand> stack = new Stack<ICommand>();
            stack.Push(printCommand);
            stack.Push(sendCommand);

            ICommand command2 = stack.Pop();

            Queue<ICommand> commands = new Queue<ICommand>();
            commands.Enqueue(printCommand);
            commands.Enqueue(sendCommand);

            Task cancelTask = Task.Run(() => Console.ReadKey());

            Task delayTask = Task.Delay(TimeSpan.FromSeconds(5));

            await Task.WhenAny(cancelTask, delayTask);

            if (cancelTask.IsCompleted)
                return;

            while (commands.Count > 0)
            {
                ICommand command = commands.Dequeue();

                if (command.CanExecute())
                {
                    command.Execute();
                }
            }


            //if (message.CanPrint())
            //{
            //    message.Print();
            //}

            //if (message.CanSend())
            //{
            //    message.Send();
            //}    
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}
