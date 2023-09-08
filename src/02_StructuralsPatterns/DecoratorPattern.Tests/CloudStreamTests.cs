using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorPattern.UnitTests
{
    [TestClass]
    public class CloudStreamTests
    {
        [TestMethod]
        public void Write()
        {
            // Arrange
            CloudStream cloudStream = new CloudStream();

            // Act
            cloudStream.Write("Here's some data");

            // Arrange

        }
    }
}
