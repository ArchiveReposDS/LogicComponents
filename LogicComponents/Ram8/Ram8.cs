namespace LogicComponents
{
    public class Ram8 : Ram8Base
    {
        public override void ConnectRow0()
        {
            Cable.Join(INRow0, Ram1.INRow0);
            Cable.Join(INRow0, Ram2.INRow0);
            Cable.Join(INRow0, Ram3.INRow0);
            Cable.Join(INRow0, Ram4.INRow0);
            Cable.Join(INRow0, Ram5.INRow0);
            Cable.Join(INRow0, Ram6.INRow0);
            Cable.Join(INRow0, Ram7.INRow0);
            Cable.Join(INRow0, Ram8.INRow0);
            GetOutput();
        }

        public override void ConnectRow2()
        {
            Cable.Join(INRow2, Ram1.INRow2);
            Cable.Join(INRow2, Ram2.INRow2);
            Cable.Join(INRow2, Ram3.INRow2);
            Cable.Join(INRow2, Ram4.INRow2);
            Cable.Join(INRow2, Ram5.INRow2);
            Cable.Join(INRow2, Ram6.INRow2);
            Cable.Join(INRow2, Ram7.INRow2);
            Cable.Join(INRow2, Ram8.INRow2);
            GetOutput();
        }

        public override void ConnectRow4()
        {
            Cable.Join(INRow4, Ram1.INRow4);
            Cable.Join(INRow4, Ram2.INRow4);
            Cable.Join(INRow4, Ram3.INRow4);
            Cable.Join(INRow4, Ram4.INRow4);
            Cable.Join(INRow4, Ram5.INRow4);
            Cable.Join(INRow4, Ram6.INRow4);
            Cable.Join(INRow4, Ram7.INRow4);
            Cable.Join(INRow4, Ram8.INRow4);
            GetOutput();
        }

        public override void ConnectColumn0()
        {
            Cable.Join(INColumn0, Ram1.INColumn0);
            Cable.Join(INColumn0, Ram2.INColumn0);
            Cable.Join(INColumn0, Ram3.INColumn0);
            Cable.Join(INColumn0, Ram4.INColumn0);
            Cable.Join(INColumn0, Ram5.INColumn0);
            Cable.Join(INColumn0, Ram6.INColumn0);
            Cable.Join(INColumn0, Ram7.INColumn0);
            Cable.Join(INColumn0, Ram8.INColumn0);
            GetOutput();
        }

        public override void ConnectColumn2()
        {
            Cable.Join(INColumn2, Ram1.INColumn2);
            Cable.Join(INColumn2, Ram2.INColumn2);
            Cable.Join(INColumn2, Ram3.INColumn2);
            Cable.Join(INColumn2, Ram4.INColumn2);
            Cable.Join(INColumn2, Ram5.INColumn2);
            Cable.Join(INColumn2, Ram6.INColumn2);
            Cable.Join(INColumn2, Ram7.INColumn2);
            Cable.Join(INColumn2, Ram8.INColumn2);
            GetOutput();
        }

        public override void ConnectColumn4()
        {
            Cable.Join(INColumn4, Ram1.INColumn4);
            Cable.Join(INColumn4, Ram2.INColumn4);
            Cable.Join(INColumn4, Ram3.INColumn4);
            Cable.Join(INColumn4, Ram4.INColumn4);
            Cable.Join(INColumn4, Ram5.INColumn4);
            Cable.Join(INColumn4, Ram6.INColumn4);
            Cable.Join(INColumn4, Ram7.INColumn4);
            Cable.Join(INColumn4, Ram8.INColumn4);
            GetOutput();
        }

        public override void ConnectDataInput1()
        {
            Cable.Join(DataInput1, Ram1.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput2()
        {
            Cable.Join(DataInput2, Ram2.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput3()
        {
            Cable.Join(DataInput3, Ram3.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput4()
        {
            Cable.Join(DataInput4, Ram4.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput5()
        {
            Cable.Join(DataInput5, Ram5.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput6()
        {
            Cable.Join(DataInput6, Ram6.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput7()
        {
            Cable.Join(DataInput7, Ram7.DataInput);
            GetOutput();
        }

        public override void ConnectDataInput8()
        {
            Cable.Join(DataInput8, Ram8.DataInput);
            GetOutput();
        }

        public override void ConnectPower()
        {
            Cable.Join(Power, Ram1.Power);
            Cable.Join(Power, Ram2.Power);
            Cable.Join(Power, Ram3.Power);
            Cable.Join(Power, Ram4.Power);
            Cable.Join(Power, Ram5.Power);
            Cable.Join(Power, Ram6.Power);
            Cable.Join(Power, Ram7.Power);
            Cable.Join(Power, Ram8.Power);
            GetOutput();
        }

        public override void ConnectReadEnable()
        {
            Cable.Join(ReadEnable, Ram1.ReadEnable);
            Cable.Join(ReadEnable, Ram2.ReadEnable);
            Cable.Join(ReadEnable, Ram3.ReadEnable);
            Cable.Join(ReadEnable, Ram4.ReadEnable);
            Cable.Join(ReadEnable, Ram5.ReadEnable);
            Cable.Join(ReadEnable, Ram6.ReadEnable);
            Cable.Join(ReadEnable, Ram7.ReadEnable);
            Cable.Join(ReadEnable, Ram8.ReadEnable);
            GetOutput();
        }



        public override void ConnectWriteEnable()
        {
            Cable.Join(WriteEnable, Ram1.WriteEnable);
            Cable.Join(WriteEnable, Ram2.WriteEnable);
            Cable.Join(WriteEnable, Ram3.WriteEnable);
            Cable.Join(WriteEnable, Ram4.WriteEnable);
            Cable.Join(WriteEnable, Ram5.WriteEnable);
            Cable.Join(WriteEnable, Ram6.WriteEnable);
            Cable.Join(WriteEnable, Ram7.WriteEnable);
            Cable.Join(WriteEnable, Ram8.WriteEnable);
            GetOutput();
        }

        private void GetOutput()
        {
            Cable.Join(Ram1.Or64Inputs.Output, DataOutput1);
            Cable.Join(Ram2.Or64Inputs.Output, DataOutput2);
            Cable.Join(Ram3.Or64Inputs.Output, DataOutput3);
            Cable.Join(Ram4.Or64Inputs.Output, DataOutput4);
            Cable.Join(Ram5.Or64Inputs.Output, DataOutput5);
            Cable.Join(Ram6.Or64Inputs.Output, DataOutput6);
            Cable.Join(Ram7.Or64Inputs.Output, DataOutput7);
            Cable.Join(Ram8.Or64Inputs.Output, DataOutput8);
        }
    }
}
