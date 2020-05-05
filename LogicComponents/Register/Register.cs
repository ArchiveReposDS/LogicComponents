using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Register : RegisterBase
    {
        public override void ConnectDataInput1()
        {
            Cable.Join(DataInput1, GatedLatch1.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput2()
        {
            Cable.Join(DataInput2, GatedLatch2.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput3()
        {
            Cable.Join(DataInput3, GatedLatch3.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput4()
        {
            Cable.Join(DataInput4, GatedLatch4.DataInput);
            GetOutput();
        }


        public override void ConnectDataInput5()
        {
            Cable.Join(DataInput5, GatedLatch5.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput6()
        {
            Cable.Join(DataInput6, GatedLatch6.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput7()
        {
            Cable.Join(DataInput7, GatedLatch7.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput8()
        {
            Cable.Join(DataInput8, GatedLatch8.DataInput);
            GetOutput();
        }

        public override void ConnectReadEnable()
        {
            Cable.Join(ReadEnable, GatedLatch1.ReadEnable);
            Cable.Join(ReadEnable, GatedLatch2.ReadEnable);
            Cable.Join(ReadEnable, GatedLatch3.ReadEnable);
            Cable.Join(ReadEnable, GatedLatch4.ReadEnable);
            Cable.Join(ReadEnable, GatedLatch5.ReadEnable);
            Cable.Join(ReadEnable, GatedLatch6.ReadEnable);
            Cable.Join(ReadEnable, GatedLatch7.ReadEnable);
            Cable.Join(ReadEnable, GatedLatch8.ReadEnable);
            GetOutput();
        }

        public override void ConnectWriteEnable()
        {
            Cable.Join(WriteEnable, GatedLatch1.WriteEnable);
            Cable.Join(WriteEnable, GatedLatch2.WriteEnable);
            Cable.Join(WriteEnable, GatedLatch3.WriteEnable);
            Cable.Join(WriteEnable, GatedLatch4.WriteEnable);
            Cable.Join(WriteEnable, GatedLatch5.WriteEnable);
            Cable.Join(WriteEnable, GatedLatch6.WriteEnable);
            Cable.Join(WriteEnable, GatedLatch7.WriteEnable);
            Cable.Join(WriteEnable, GatedLatch8.WriteEnable);
            GetOutput();
        }

        public void GetOutput()
        {
            Cable.Join(GatedLatch1.DataOutput, DataOutput1);
            Cable.Join(GatedLatch2.DataOutput, DataOutput2);
            Cable.Join(GatedLatch3.DataOutput, DataOutput3);
            Cable.Join(GatedLatch4.DataOutput, DataOutput4);
            Cable.Join(GatedLatch5.DataOutput, DataOutput5);
            Cable.Join(GatedLatch6.DataOutput, DataOutput6);
            Cable.Join(GatedLatch7.DataOutput, DataOutput7);
            Cable.Join(GatedLatch8.DataOutput, DataOutput8);
        }
    }
}
