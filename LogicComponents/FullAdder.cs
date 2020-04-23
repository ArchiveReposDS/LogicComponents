//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LogicComponents
//{
//    public class FullAdder
//    {

//        public byte I1 { get; set; }
//        public byte I2 { get; set; }
//        public byte I3 { get; set; }
//        public byte Sum { get; set; }
//        public byte Carry { get; set; }
//        public byte HasChanged { get; set; }


//        public HalfAdder HalfAdder1 { get; set; } = new HalfAdder();
//        public HalfAdder HalfAdder2 { get; set; } = new HalfAdder();
//        public Or Or { get; set; } = new Or();


//        public void SetI1(byte i)
//        {
//            byte CurrentI = I1;
//            I1 = i;
//            if (CurrentI != I1)
//            {
//                RunI1(i);
//            }
//        }

//        public void SetI2(byte i)
//        {
//            byte CurrentI = I2;
//            I2 = i;
//            if (CurrentI != I2)
//            {
//                RunI2(i);
//            }
//        }

//        public void SetI3(byte i)
//        {
//            byte CurrentI = I3;
//            I3 = i;
//            if (CurrentI != I3)
//            {
//                RunI3(i);
//            }
//        }

//        private void RunI1(byte i)
//        {
//            HalfAdder1.SetI1(i);
//            Run();
            
//        }

//        private void RunI2(byte i)
//        {
//            HalfAdder1.SetI2(i);
//            Run();

//        }

//        private void RunI3(byte i)
//        {
//            HalfAdder2.SetI2(i);
//            Run();
//        }
//        private void Run()
//        {
//            Or.SetI1(HalfAdder1.Carry);
//            HalfAdder2.SetI1(HalfAdder1.Sum);
//            HalfAdder2.SetI2(I3);
//            Or.SetI2(HalfAdder2.Carry);

//            Carry = Or.Output;
//            Sum = HalfAdder2.Sum;
//        }

//    }
//}
