using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.LightSwitchStates
{
    // Abstract State
    public abstract class LightSwitchState
    {
        protected LightSwitch lightSwitch;

        protected LightSwitchState(LightSwitch lightSwitch)
        {
            this.lightSwitch = lightSwitch;
        }

        // Handle
        public abstract void Push();
    }
}
