using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class GatedLatch : GatedLatchBase
    {
        public override void ConnectDataInput()
        {
            Cable.Join(DataInput, And1.Pin1);
            Cable.Join(DataInput, Not1.Pin1);
            GetOutput();
        }

        public override void ConnectWriteEnable()
        {
            Cable.Join(WriteEnable, And1.Pin2);
            Cable.Join(WriteEnable, And2.Pin2);
            GetOutput();
        }

        public override void ConnectReadEnable()
        {
            Cable.Join(ReadEnable, And4.Pin2);
            GetOutput();
        }

        private void GetOutput()
        {
            Cable.Join(Not1.Output, And2.Pin1);
            Cable.Join(And1.Output, Or.Pin2);
            Cable.Join(And2.Output, Not2.Pin1);
            Cable.Join(Or.Output, And3.Pin1);
            Cable.Join(Not2.Output, And3.Pin2);
            Cable.Join(And3.Output, Or.Pin1);
            Cable.Join(And3.Output, And4.Pin1);
     
            Cable.Join(And4.Output, DataOutput);
        }


    }
}
