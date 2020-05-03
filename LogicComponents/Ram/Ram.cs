using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Ram :RamBase
    {
        public override void ConnectPower()
        {
            Cable.Join(Power, Demultiplexer8Column.Power);
            Cable.Join(Power, Demultiplexer8Row.Power);
            GetOutput();
        }
        public override void ConnectDataInput()
        {
            Cable.Join(DataInput, RowColumnGatedLatch1.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch2.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch3.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch4.DataInput);
            GetOutput();
        }

        public override void ConnectWriteEnable()
        {
            Cable.Join(WriteEnable, RowColumnGatedLatch1.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch2.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch3.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch4.WriteEnable);
            GetOutput();
        }

        public override void ConnectReadEnable()
        {
            Cable.Join(ReadEnable, RowColumnGatedLatch1.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch2.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch3.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch4.ReadEnable);
            GetOutput();
        }


        public override void ConnectColumn0()
        {
            Cable.Join(INColumn0, Demultiplexer8Column.IN1);
            GetOutput();
        }
        public override void ConnectColumn2()
        {
            Cable.Join(INColumn2, Demultiplexer8Column.IN2);
            GetOutput();
        }
        public override void ConnectColumn4()
        {
            Cable.Join(INColumn4, Demultiplexer8Column.IN3);
            GetOutput();
        }

        public override void ConnectRow0()
        {
            Cable.Join(INRow0, Demultiplexer8Row.IN1);
            GetOutput();
        }
        public override void ConnectRow2()
        {
            Cable.Join(INRow2, Demultiplexer8Row.IN2);
            GetOutput();
        }
        public override void ConnectRow4()
        {
            Cable.Join(INRow4, Demultiplexer8Row.IN3);
            GetOutput();
        }

        private void GetOutput()
        {
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch1.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch2.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch3.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch4.INRow);

            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch1.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch3.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch2.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch4.INColumn);

            Cable.Join(RowColumnGatedLatch1.DataOutput, Or4Inputs.Pin1);
            Cable.Join(RowColumnGatedLatch2.DataOutput, Or4Inputs.Pin2);
            Cable.Join(RowColumnGatedLatch3.DataOutput, Or4Inputs.Pin3);
            Cable.Join(RowColumnGatedLatch4.DataOutput, Or4Inputs.Pin4);

            Cable.Join(Or4Inputs.Output, DataOutput);
        }

    }
}
