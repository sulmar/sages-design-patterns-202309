using BridgePattern.ControlDevices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgePattern.UnitTests
{
    [TestClass]
    public class ControlDeviceTests
    {
        [TestMethod]
        public void SwitchOn_TCPCommunicationAndXmlProtocol_ShouldSwitchOnDevice()
        {
            // Arrange
            IControlDevice controlDevice = new ControlDevice(new RS232Communication(), new TextProtocol());

            // Act
            controlDevice.SwitchOn();

            // Assert
        }

    }


    [TestClass]
    public class TextProtocolTests
    {
        [TestMethod]
        public void GetSwitchOnMessage_WhenCalled_ShoudReturnsOnMessage()
        {
            // Arrange
            TextProtocol protocol = new TextProtocol();

            // Act
            var result = protocol.GetSwitchOnMessage();

            // Assert
            Assert.AreEqual("ON", result);

        }

        [TestMethod]
        public void GetSwitchOffMessage_WhenCalled_ShoudReturnsOffMessage()
        {
            // Arrange
            TextProtocol protocol = new TextProtocol();

            // Act
            var result = protocol.GetSwitchOffMessage();

            // Assert
            Assert.AreEqual("OFF", result);

        }

        [TestMethod]
        public void GetSetChannelMessage_WhenCalled_ShoudReturnsChannelMessage()
        {
            // Arrange
            TextProtocol protocol = new TextProtocol();

            // Act
            var result = protocol.GetSetChannelMessage(1);

            // Assert
            Assert.AreEqual("SET CHANNEL 1", result);

        }


    }



    [TestClass]
    public class BluetoothRemoteControlSamsungLedTVTests
    {
        [TestMethod]
        public void SwitchOn_ShouldOnTrue()
        {
            // Arrange
            RemoteControl remoteControl = new BluetoothRemoteControl(new SonyLedTV());

            // Act
            remoteControl.SwitchOn();

            //
            // Assert.IsTrue(remoteControl.On);
        }

        [TestMethod]
        public void SwitchOn_ShouldOnFalse()
        {
            // Arrange
            BluetoothRemoteControlSamsungLedTV ledTV = new BluetoothRemoteControlSamsungLedTV();

            // Act
            ledTV.SwitchOff();

            //
            Assert.IsFalse(ledTV.On);
        }

        [TestMethod]
        public void SetChannel_ShouldSetCurrentChannel()
        {
            // Arrange
            BluetoothRemoteControlSamsungLedTV ledTV = new BluetoothRemoteControlSamsungLedTV();

            // Act
            ledTV.SetChannel(10);

            //
            Assert.AreEqual(10, ledTV.CurrentChannel);
        }
    }
}
