using ChainOfResponsibilityPattern.Models;
using System;
using System.Linq;

namespace ChainOfResponsibilityPattern.Handlers
{
    // Concrete Handler
    public class FromWhiteListHandler : MessageHandler
    {
        private string[] whiteList;

        public FromWhiteListHandler(string[] whiteList)
        {
            this.whiteList = whiteList;
        }

        public override void Handle(Message message)
        {
            if (!whiteList.Contains(message.From))
            {
                throw new Exception();
            }

            base.Handle(message);
        }
    }
}
