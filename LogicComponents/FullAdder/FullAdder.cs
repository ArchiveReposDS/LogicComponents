using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class FullAdder : FullAdderBase
    {
        public override void RunIN1()
        {
            Cable.Join(IN1, HalfAdder1.IN1);
            GetOutput();
        }

        public override void RunIN2()
        {
            Cable.Join(IN2, HalfAdder1.IN2);
            GetOutput();
        }

        public override void RunIN3()
        {
            Cable.Join(IN3, HalfAdder2.IN2);
            GetOutput();
        }

        private void GetOutput()
        {
            Cable.Join(HalfAdder1.OUTCarry, Or.Pin1);
            Cable.Join(HalfAdder1.OUTSum, HalfAdder2.IN1);
            Cable.Join(HalfAdder2.OUTCarry, Or.Pin2);
            Cable.Join(Or.Output, OUTCarry);
            Cable.Join(HalfAdder2.OUTSum, OUTSum);
        }


    }
}
