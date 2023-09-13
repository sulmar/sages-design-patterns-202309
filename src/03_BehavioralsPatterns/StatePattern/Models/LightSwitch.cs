using StatePattern.LightSwitchStates;
using System;

namespace StatePattern
{
    // Context
    public class LightSwitch
    {
        public LightSwitchState State { get; private set; }        

        public LightSwitch()
        {
            SetState(new Off(this));   // Initial State
        }

        public void SetState(LightSwitchState state)
        {
            this.State = state;
        }

        public void Push() => State.Push();
    }

    

}
