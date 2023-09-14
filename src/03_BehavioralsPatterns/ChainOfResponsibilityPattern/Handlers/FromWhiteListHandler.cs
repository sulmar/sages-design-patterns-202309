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

        public override void Handle(MessageContext context)
        {
            if (!whiteList.Contains(context.Message.From))
            {
                throw new Exception();
            }

            base.Handle(context);
        }
    }
}
