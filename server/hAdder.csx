using LogicWorld.Server;
using LogicWorld.LogicCode;
namespace LogicWorld.LogicCode
{
    public class HalfAdder : LogicComponent
    {
        protected override void DoLogicUpdate ()
        {
            if (base.Inputs[0] ^ base.Inputs[1]) 
            { 
                base.Outputs[0] = 1;
            } else {
                base.Outputs[0] = 0;
            }
        };
    }
}