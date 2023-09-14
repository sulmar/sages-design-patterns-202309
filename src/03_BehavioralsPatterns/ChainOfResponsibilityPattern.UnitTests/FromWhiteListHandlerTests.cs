using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChainOfResponsibilityPattern.UnitTests.UnitTests
{
    [TestClass]
    public class FromWhiteListHandlerTests
    {
        [TestMethod]
        public void Handle_FromWhiteList_ShouldCallNext()
        {
            // Arrange
            string[] whiteList = new string[] { "john@domain.com", "bob@domain.com" };

            MessageHandler messageHandler = new FromWhiteListHandler(whiteList);

            Message message = new Message { From = "john@domain.com" };

            // Act
            messageHandler.Handle(message);

            // Assert


        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Handle_NotFromFromWhiteList_ShouldCallNext()
        {
            // Arrange
            string[] whiteList = new string[] { "john@domain.com", "bob@domain.com" };

            MessageHandler messageHandler = new FromWhiteListHandler(whiteList);

            Message message = new Message { From = "a@domain.com" };

            // Act
            messageHandler.Handle(message);

            // Assert


        }
    }
}
