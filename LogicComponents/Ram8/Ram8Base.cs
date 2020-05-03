using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class Ram8Base
    {
        public event ActionDel EventPower;
        public event ActionDel EventDataInput1;
        public event ActionDel EventDataInput2;
        public event ActionDel EventDataInput3;
        public event ActionDel EventDataInput4;
        public event ActionDel EventDataInput5;
        public event ActionDel EventDataInput6;
        public event ActionDel EventDataInput7;
        public event ActionDel EventDataInput8;
        public event ActionDel EventWriteEnable;
        public event ActionDel EventReadEnable;
        public event ActionDel EventRow0;
        public event ActionDel EventRow2;
        public event ActionDel EventRow4;
        public event ActionDel EventColumn0;
        public event ActionDel EventColumn2;
        public event ActionDel EventColumn4;

        // INPUT
        public Pin Power { get; set; }
        public Pin DataInput1 { get; set; }
        public Pin DataInput2 { get; set; }
        public Pin DataInput3 { get; set; }
        public Pin DataInput4 { get; set; }
        public Pin DataInput5 { get; set; }
        public Pin DataInput6 { get; set; }
        public Pin DataInput7 { get; set; }
        public Pin DataInput8 { get; set; }
        public Pin WriteEnable { get; set; }
        public Pin ReadEnable { get; set; }
        public Pin INRow0 { get; set; }
        public Pin INRow2 { get; set; }
        public Pin INRow4 { get; set; }
        public Pin INColumn0 { get; set; }
        public Pin INColumn2 { get; set; }
        public Pin INColumn4 { get; set; }

        // OUTPUT
        public Pin DataOutput1 { get; set; }
        public Pin DataOutput2 { get; set; }
        public Pin DataOutput3 { get; set; }
        public Pin DataOutput4 { get; set; }
        public Pin DataOutput5 { get; set; }
        public Pin DataOutput6 { get; set; }
        public Pin DataOutput7 { get; set; }
        public Pin DataOutput8 { get; set; }

        // ELEMENTS

        public Ram Ram1 { get; set; } = new Ram();
        public Ram Ram2 { get; set; } = new Ram();
        public Ram Ram3 { get; set; } = new Ram();
        public Ram Ram4 { get; set; } = new Ram();
        public Ram Ram5 { get; set; } = new Ram();
        public Ram Ram6 { get; set; } = new Ram();
        public Ram Ram7 { get; set; } = new Ram();
        public Ram Ram8 { get; set; } = new Ram();

        public Ram8Base()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventPower += ConnectPower;
            EventDataInput1 += ConnectDataInput1;
            EventDataInput2 += ConnectDataInput2;
            EventDataInput3 += ConnectDataInput3;
            EventDataInput4 += ConnectDataInput4;
            EventDataInput5 += ConnectDataInput5;
            EventDataInput6 += ConnectDataInput6;
            EventDataInput7 += ConnectDataInput7;
            EventDataInput8 += ConnectDataInput8;
            EventWriteEnable += ConnectWriteEnable;
            EventReadEnable += ConnectReadEnable;
            EventRow0 += ConnectRow0;
            EventRow2 += ConnectRow2;
            EventRow4 += ConnectRow4;
            EventColumn0 += ConnectColumn0;
            EventColumn2 += ConnectColumn2;
            EventColumn4 += ConnectColumn4;
            EventColumn4 += ConnectPower;

            DataInput1 = new Pin(EventDataInput1);
            DataInput2 = new Pin(EventDataInput2);
            DataInput3 = new Pin(EventDataInput3);
            DataInput4 = new Pin(EventDataInput4);
            DataInput5 = new Pin(EventDataInput5);
            DataInput6 = new Pin(EventDataInput6);
            DataInput7 = new Pin(EventDataInput7);
            DataInput8 = new Pin(EventDataInput8);
            WriteEnable = new Pin(EventWriteEnable);
            ReadEnable = new Pin(EventReadEnable);
            INRow0 = new Pin(EventRow0);
            INRow2 = new Pin(EventRow2);
            INRow4 = new Pin(EventRow4);
            INColumn0 = new Pin(EventColumn0);
            INColumn2 = new Pin(EventColumn2);
            INColumn4 = new Pin(EventColumn4);
            Power = new Pin(EventPower);

            DataOutput1 = new Pin();
            DataOutput2 = new Pin();
            DataOutput3 = new Pin();
            DataOutput4 = new Pin();
            DataOutput5 = new Pin();
            DataOutput6 = new Pin();
            DataOutput7 = new Pin();
            DataOutput8 = new Pin();

        }


        public virtual void ConnectDataInput1() { }
        public virtual void ConnectDataInput2() { }
        public virtual void ConnectDataInput3() { }
        public virtual void ConnectDataInput4() { }
        public virtual void ConnectDataInput5() { }
        public virtual void ConnectDataInput6() { }
        public virtual void ConnectDataInput7() { }
        public virtual void ConnectDataInput8() { }

        public virtual void ConnectWriteEnable()
        {
        }

        public virtual void ConnectReadEnable()
        {
        }

        public virtual void ConnectRow0()
        {
        }

        public virtual void ConnectRow2()
        {
        }

        public virtual void ConnectRow4()
        {
        }

        public virtual void ConnectColumn0()
        {
        }
        public virtual void ConnectColumn2()
        {
        }
        public virtual void ConnectColumn4()
        {
        }
        public virtual void ConnectPower()
        {
        }
    }
}
