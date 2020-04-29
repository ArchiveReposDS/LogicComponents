using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class HalfAdder : HalfAdderBase
    {
        public override void RunIN1()
        {
            Cable.Join(IN1, Xor.Pin1);
            Cable.Join(IN1, And.Pin1);
            GetOutput();
        }

        public override void RunIN2()
        {
            Cable.Join(IN2, Xor.Pin2);
            Cable.Join(IN2, And.Pin2);
            GetOutput();
        }

        private void GetOutput()
        {
            Cable.Join(Xor.Output, OUTSum);
            Cable.Join(And.Output, OUTCarry);
        }

    }
}
