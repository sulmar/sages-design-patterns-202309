using System;

namespace StatePattern.LightSwitchStates
{
    public class On : LightSwitchState
    {
        public On(LightSwitch lightSwitch) : base(lightSwitch)
        {
        }

        public override void Push()
        {
            Console.WriteLine("wyłącz przekaźnik");

            lightSwitch.SetState(new Off(lightSwitch));
        }
    }
}
