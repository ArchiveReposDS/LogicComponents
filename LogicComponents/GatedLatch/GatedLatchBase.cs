using LogicComponents.Gates;
using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class GatedLatchBase
    {
        public event ActionDel EventIN1;
        public event ActionDel EventIN2;
        public event ActionDel EventIN3;

        public Pin DataInput { get; set; }
        public Pin WriteEnable { get; set; }
        public Pin ReadEnable { get; set; }
        public Pin DataOutput { get; set; }

        public And And1 { get; set; } = new And();
        public And And2 { get; set; } = new And();
        public And And3 { get; set; } = new And();
        public And And4 { get; set; } = new And();
        public Not Not1 { get; set; } = new Not();
        public Not Not2 { get; set; } = new Not();
        public Or Or { get; set; } = new Or();

        public GatedLatchBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += ConnectDataInput;
            EventIN2 += ConnectWriteEnable;
            EventIN3 += ConnectReadEnable;
            DataInput = new Pin(EventIN1);
            WriteEnable = new Pin(EventIN2);
            ReadEnable = new Pin(EventIN3);
            DataOutput = new Pin();
        }


        public virtual void ConnectDataInput()
        {

        }

        public virtual void ConnectWriteEnable()
        {

        }

        public virtual void ConnectReadEnable()
        {

        }


    }

  
}
