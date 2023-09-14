using ChainOfResponsibilityPattern.Models;
using System;
using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class ConsoleExceptionHandler : MessageHandler
    {
        public override void Handle(Message message)
        {
            try
            {
                base.Handle(message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw;
            }
        }
    }


    public class UnderConstrucionHandler : MessageHandler
    {
        public override void Handle(Message message)
        {
            
        }
    }

    public class ExtractTaxNumberHandler : MessageHandler
    {
        private readonly string pattern = @"\b(\d{10}|\d{3}-\d{3}-\d{2}-\d{2})\b";
        private readonly Regex regex;

        public ExtractTaxNumberHandler()
        {
            regex = new Regex(pattern);
        }

        public override void Handle(Message message)
        {
            Match match = regex.Match(message.Body);

            if (!match.Success)
                throw new FormatException();

            string taxNumber = match.Value;

            // TODO: return tax number

            base.Handle(message);
        }
    }
}
