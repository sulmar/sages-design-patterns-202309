using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class TitleContainsTextHandler : MessageHandler
    {
        private readonly string text;

        public TitleContainsTextHandler(string text)
        {
            this.text = text;
        }

        public override void Handle(Message message)
        {
            if (!message.Title.Contains(text))
            {
                throw new Exception();
            }

            base.Handle(message);
        }
    }
}
