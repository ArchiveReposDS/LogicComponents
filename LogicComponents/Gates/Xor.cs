using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Xor : LogicGate
    {
        public override void RunIN1()
        {
            if (Pin1.State != Pin2.State)
                Output.State = 1;
            else
                Output.State = 0;
        }

        public override void RunIN2()
        {
            if (Pin1.State != Pin2.State)
                Output.State = 1;
            else
                Output.State = 0;
        }

    }
}
