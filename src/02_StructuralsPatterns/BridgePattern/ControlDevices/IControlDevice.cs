using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ControlDevices
{
    // Abstraction Interface
    public interface IControlDevice
    {
        void Connect();
        void SwitchOn();
        void SwitchOff();
        void Disconnect();
    }
}
