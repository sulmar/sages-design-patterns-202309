using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class ConsoleExceptionHandler : MessageHandler
    {
        public override void Handle(MessageContext context)
        {
            try
            {
                base.Handle(context);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw;
            }
        }
    }
}
