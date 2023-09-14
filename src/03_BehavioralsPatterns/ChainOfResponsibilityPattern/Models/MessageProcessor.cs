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

            exceptionHandler.SetNextHandler(whiteListHandler)
                .SetNextHandler(titleHandler)
                    // .SetNextHandler(underConstruction)
                        .SetNextHandler(taxNumberHandler)
                            .SetNextHandler(taxNumberHandler);

            messageHandler = exceptionHandler;

        }

        public string Process(Message message)
        {
            messageHandler.Handle(message);

            var taxNumber = "";

            return taxNumber;

        }

       
    }
}
