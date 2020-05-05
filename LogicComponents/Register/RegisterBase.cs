using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class RegisterBase
    {
        public event ActionDel EventIN1;
        public event ActionDel EventIN2;
        public event ActionDel EventIN3;
        public event ActionDel EventIN4;
        public event ActionDel EventIN5;
        public event ActionDel EventIN6;
        public event ActionDel EventIN7;
        public event ActionDel EventIN8;
        public event ActionDel EventWriteEnable;
        public event ActionDel EventReadEnable;

        public Pin DataInput1 { get; set; }
        public Pin DataInput2 { get; set; }
        public Pin DataInput3 { get; set; }
        public Pin DataInput4 { get; set; }
        public Pin DataInput5 { get; set; }
        public Pin DataInput6 { get; set; }
        public Pin DataInput7 { get; set; }
        public Pin DataInput8 { get; set; }

  
        public Pin DataOutput1 { get; set; }
        public Pin DataOutput2 { get; set; }
        public Pin DataOutput3 { get; set; }
        public Pin DataOutput4 { get; set; }
        public Pin DataOutput5 { get; set; }
        public Pin DataOutput6 { get; set; }
        public Pin DataOutput7 { get; set; }
        public Pin DataOutput8 { get; set; }

        public Pin WriteEnable { get; set; }
        public Pin ReadEnable { get; set; }

        public GatedLatch GatedLatch1 { get; set; } = new GatedLatch();
        public GatedLatch GatedLatch2 { get; set; } = new GatedLatch();
        public GatedLatch GatedLatch3 { get; set; } = new GatedLatch();
        public GatedLatch GatedLatch4 { get; set; } = new GatedLatch();
        public GatedLatch GatedLatch5 { get; set; } = new GatedLatch();
        public GatedLatch GatedLatch6 { get; set; } = new GatedLatch();
        public GatedLatch GatedLatch7 { get; set; } = new GatedLatch();
        public GatedLatch GatedLatch8 { get; set; } = new GatedLatch();

        public RegisterBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += ConnectDataInput1;
            EventIN2 += ConnectDataInput2;
            EventIN3 += ConnectDataInput3;
            EventIN4 += ConnectDataInput4;
            EventIN5 += ConnectDataInput5;
            EventIN6 += ConnectDataInput6;
            EventIN7 += ConnectDataInput7;
            EventIN8 += ConnectDataInput8;
            EventWriteEnable += ConnectWriteEnable;
            EventReadEnable += ConnectReadEnable;
            DataInput1 = new Pin(EventIN1);
            DataInput2 = new Pin(EventIN2);
            DataInput3 = new Pin(EventIN3);
            DataInput4 = new Pin(EventIN4);
            DataInput5 = new Pin(EventIN5);
            DataInput6 = new Pin(EventIN6);
            DataInput7 = new Pin(EventIN7);
            DataInput8 = new Pin(EventIN8);
            WriteEnable = new Pin(EventWriteEnable);
            ReadEnable = new Pin(EventReadEnable);
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
        public virtual void ConnectWriteEnable() { }
        public virtual void ConnectReadEnable() { }
    }
}
