namespace ChainOfResponsibilityPattern.Models
{
    // Context
    public class MessageContext
    {
        public Message Message { get; set; }
        public string TaxNumber { get; set; }

        public MessageContext(Message message)
        {
            Message = message;
        }
    }
}
