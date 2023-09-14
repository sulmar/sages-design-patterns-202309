using ChainOfResponsibilityPattern.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    // Abstract Handler
    public abstract class MessageHandler
    {
        protected MessageHandler next;

        public MessageHandler SetNextHandler(MessageHandler next)
        {
            return this.next = next;
        }

        public virtual void Handle(Message message)
        {
            if (next != null)
            {
                next.Handle(message);
            }
        }
    }
}
