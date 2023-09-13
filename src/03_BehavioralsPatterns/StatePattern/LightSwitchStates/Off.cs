using System;

namespace StatePattern.LightSwitchStates
{
    public class Off : LightSwitchState
    {
        public Off(LightSwitch lightSwitch) : base(lightSwitch)
        {
        }

        public override void Push()
        {
            Console.WriteLine("załącz przekaźnik");

            lightSwitch.SetState(new On(lightSwitch));
        }
        
    }
}
