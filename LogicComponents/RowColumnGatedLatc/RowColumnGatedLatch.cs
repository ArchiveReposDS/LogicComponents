using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class RowColumnGatedLatch : RowColumnGatedLatchBase
    {
        public override void ConnectDataInput()
        {
            Cable.Join(DataInput, GatedLatch.DataInput);
            GetOutput();
        }

        public override void ConnectRow()
        {
            Cable.Join(INRow, And1.Pin1);
            GetOutput();
        }

        public override void ConnectColumn()
        {
            Cable.Join(INColumn, And1.Pin2);
            GetOutput();
        }

        public override void ConnectWriteEnable()
        {
            Cable.Join(WriteEnable, And2.Pin1);
            GetOutput();
        }
        public override void ConnectReadEnable()
        {
            Cable.Join(ReadEnable, And3.Pin2);
            GetOutput();
        }
        private void GetOutput()
        {
            Cable.Join(And1.Output, And2.Pin2);
            Cable.Join(And1.Output, And3.Pin1);
            Cable.Join(And2.Output, GatedLatch.WriteEnable);
            Cable.Join(GatedLatch.DataOutput, And4.Pin1);
            Cable.Join(And3.Output, And4.Pin2);
            Cable.Join(And4.Output, DataOutput);
        }
    }
}
