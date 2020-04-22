using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class HalfAdder
    {

        public byte I1 { get; set; }
        public byte I2 { get; set; }
        public byte Sum { get; set; }
        public byte Carry { get; set; }
        public byte HasChanged { get; set; }

        public And AndGate { get; set; } = new And();
        public Xor XorGate { get; set; } = new Xor();



        public void SetI1(byte i)
        {
            byte CurrentI = I1;
            I1 = i;
            if (CurrentI != I1)
            {
                RunI1(i);
            }
        }

        public void SetI2(byte i)
        {
            byte CurrentI = I2;
            I2 = i;
            if (CurrentI != I2)
            {
                RunI2(i);
            }
        }

        private void RunI1(byte i)
        {
            XorGate.SetI1(i);
            AndGate.SetI2(i);
            Getoutput();
        }

        private void RunI2(byte i)
        {
            XorGate.SetI2(i);
            AndGate.SetI1(i);
            Getoutput();
        }

        private void Getoutput()
        {
            Sum = XorGate.Output;
            Carry = AndGate.Output;
        }
    }
}
