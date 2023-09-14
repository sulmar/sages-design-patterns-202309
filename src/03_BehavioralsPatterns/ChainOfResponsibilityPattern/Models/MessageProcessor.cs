using ChainOfResponsibilityPattern.Handlers;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern.Models
{

    public class MessageProcessor
    {
        private string[] whiteList;

        private MessageHandler messageHandler;

        public MessageProcessor(string[] whiteList)
        {
            this.whiteList = whiteList;

            // Inicjalizacja łańcucha odpowiedzialności
            MessageHandler whiteListHandler = new FromWhiteListHandler(whiteList);
            MessageHandler titleHandler = new TitleContainsTextHandler("Order");
            MessageHandler taxNumberHandler = new ExtractTaxNumberHandler();
            MessageHandler underConstruction = new UnderConstrucionHandler();
            MessageHandler exceptionHandler = new ConsoleExceptionHandler();

            exceptionHandler.SetNext(whiteListHandler)
                .SetNext(titleHandler)
                    // .SetNextHandler(underConstruction)
                        .SetNext(taxNumberHandler)
                            .SetNext(taxNumberHandler);

            messageHandler = exceptionHandler;

        }

        public string Process(Message message)
        {
            MessageContext context = new MessageContext(message);

            messageHandler.Handle(context);

            var taxNumber = "";

            return taxNumber;

        }

       
    }
}
