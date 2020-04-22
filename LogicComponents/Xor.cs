using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Xor
    {

        private byte I1 { get; set; }
        private byte I2 { get; set; }
        public byte Output { get; set; }
        public byte HasChanged { get; set; }

        public void SetI1(byte i1)
        {
            if (I1 != i1)
            {
                I1 = i1;
                Run();
            }

        }

        public void SetI2(byte i2)
        {
            if (I2 != i2)
            {
                I2 = i2;
                Run();
            }

        }

        private void Run()
        {
            byte CurrentOutput = Output;
            if (I1 != I2)
            {
                Output = 1;
            }
            else
            {
                Output = 0;
            }

            if (CurrentOutput == Output)
            {
                HasChanged = 1;
            }
        }

    }
}
