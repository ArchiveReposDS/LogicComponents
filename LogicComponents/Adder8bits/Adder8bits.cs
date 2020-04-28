using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Adder8bits : Adder8bitsBase
    {
        public override void RunIN0A()
        {
            Cable.Join(IN0A, HalfAdder.IN1);
            GetOutput();
        }

        public override void RunIN0B()
        {
            Cable.Join(IN0B, HalfAdder.IN2);
            GetOutput();
        }

        public override void RunIN1A()
        {
            Cable.Join(IN1A, FullAdder1.IN2);
            GetOutput();
        }

        public override void RunIN1B()
        {
            Cable.Join(IN1B, FullAdder1.IN3);
            GetOutput();
        }

        public override void RunIN2A()
        {
            Cable.Join(IN2A, FullAdder2.IN2);
            GetOutput();
        }

        public override void RunIN2B()
        {
            Cable.Join(IN2B, FullAdder2.IN3);
            GetOutput();
        }


        public override void RunIN3A()
        {
            Cable.Join(IN3A, FullAdder2.IN2);
            GetOutput();
        }

        public override void RunIN3B()
        {
            Cable.Join(IN3B, FullAdder2.IN3);
            GetOutput();
        }

        public override void RunIN4A()
        {
            Cable.Join(IN4A, FullAdder2.IN2);
            GetOutput();
        }

        public override void RunIN4B()
        {
            Cable.Join(IN4B, FullAdder2.IN3);
            GetOutput();
        }

        public override void RunIN5A()
        {
            Cable.Join(IN5A, FullAdder2.IN2);
            GetOutput();
        }

        public override void RunIN5B()
        {
            Cable.Join(IN5B, FullAdder2.IN3);
            GetOutput();
        }

        public override void RunIN6A()
        {
            Cable.Join(IN6A, FullAdder2.IN2);
            GetOutput();
        }

        public override void RunIN6B()
        {
            Cable.Join(IN6B, FullAdder2.IN3);
            GetOutput();
        }

        public override void RunIN7A()
        {
            Cable.Join(IN7A, FullAdder2.IN2);
            GetOutput();
        }

        public override void RunIN7B()
        {
            Cable.Join(IN7B, FullAdder2.IN3);
            GetOutput();
        }

        private void GetOutput()
        {
            Cable.Join(HalfAdder.OUTCarry, FullAdder1.IN1);
            Cable.Join(FullAdder1.OUTCarry, FullAdder2.IN1);
            Cable.Join(FullAdder2.OUTCarry, FullAdder3.IN1);
            Cable.Join(FullAdder3.OUTCarry, FullAdder4.IN1);
            Cable.Join(FullAdder4.OUTCarry, FullAdder5.IN1);
            Cable.Join(FullAdder5.OUTCarry, FullAdder6.IN1);
            Cable.Join(FullAdder6.OUTCarry, FullAdder7.IN1);


            OUTSum0.State = HalfAdder.OUTSum.State;
            OUTSum1.State = FullAdder1.OUTSum.State;
            OUTSum2.State = FullAdder2.OUTSum.State;
            OUTSum3.State = FullAdder3.OUTSum.State;
            OUTSum4.State = FullAdder4.OUTSum.State;
            OUTSum5.State = FullAdder5.OUTSum.State;
            OUTSum6.State = FullAdder6.OUTSum.State;
            OUTSum7.State = FullAdder7.OUTSum.State;

            OUTCarry.State = FullAdder7.OUTCarry.State;
        }
    }
}
