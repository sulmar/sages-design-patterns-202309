using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    public interface IMessageHandler
    {
        IMessageHandler SetNext(IMessageHandler next);
        void Handle(MessageContext context);
    }
}
