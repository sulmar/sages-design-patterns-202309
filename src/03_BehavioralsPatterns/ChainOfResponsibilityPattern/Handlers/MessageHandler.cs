using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{


    // Abstract Base Handler
    public abstract class MessageHandler : IMessageHandler
    {
        protected IMessageHandler next;

        public IMessageHandler SetNext(IMessageHandler next)
        {
            return this.next = next;
        }

        public virtual void Handle(MessageContext context)
        {
            next?.Handle(context);
        }
    }
}
