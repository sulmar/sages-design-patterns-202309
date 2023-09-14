using ChainOfResponsibilityPattern.Models;
using System;
using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern.Handlers
{

    public class ExtractTaxNumberHandler : MessageHandler
    {
        private readonly string pattern = @"\b(\d{10}|\d{3}-\d{3}-\d{2}-\d{2})\b";
        private readonly Regex regex;

        public ExtractTaxNumberHandler()
        {
            regex = new Regex(pattern);
        }

        public override void Handle(MessageContext context)
        {
            Match match = regex.Match(context.Message.Body);

            if (!match.Success)
                throw new FormatException();

            string taxNumber = match.Value;

            context.TaxNumber = taxNumber;

            base.Handle(context);
        }
    }
}
