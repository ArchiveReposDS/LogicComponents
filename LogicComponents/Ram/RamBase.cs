using LogicComponents;
using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class RamBase
    {
        public event ActionDel EventDataInput;
        public event ActionDel EventWriteEnable;
        public event ActionDel EventReadEnable;
        public event ActionDel EventRow0;
        public event ActionDel EventRow2;
        public event ActionDel EventRow4;
        public event ActionDel EventColumn0;
        public event ActionDel EventColumn2;
        public event ActionDel EventColumn4;

        // INPUT
        public Pin DataInput { get; set; }
        public Pin WriteEnable { get; set; }
        public Pin ReadEnable { get; set; }
        public Pin INRow0 { get; set; }
        public Pin INRow2 { get; set; }
        public Pin INRow4 { get; set; }
        public Pin INColumn0 { get; set; }
        public Pin INColumn2 { get; set; }
        public Pin INColumn4 { get; set; }

        // OUTPUT
        protected Pin DataOutput { get; set; }

        // ELEMENTS
        public RowColumnGatedLatch RowColumnGatedLatch1 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch2 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch3 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch4 { get; set; } = new RowColumnGatedLatch();
        public Demultiplexer8 Demultiplexer8Row { get; set; } = new Demultiplexer8();
        public Demultiplexer8 Demultiplexer8Column { get; set; } = new Demultiplexer8();
        public And4 And4Inputs { get; set; } = new And4();

        public RamBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventDataInput += ConnectDataInput;
            EventWriteEnable += ConnectWriteEnable;
            EventReadEnable += ConnectReadEnable;
            EventRow0 += ConnectRow0;
            EventRow2 += ConnectRow2;
            EventRow4 += ConnectRow4;
            EventColumn0 += ConnectColumn0;
            EventColumn2 += ConnectColumn2;
            EventColumn4 += ConnectColumn4;

            DataInput = new Pin(EventDataInput);
            WriteEnable = new Pin(EventWriteEnable);
            ReadEnable = new Pin(EventReadEnable);
            INRow0 = new Pin(EventRow0);
            INRow2 = new Pin(EventRow2);
            INRow4 = new Pin(EventRow4);
            INColumn0 = new Pin(EventColumn0);
            INColumn2 = new Pin(EventColumn2);
            INColumn4 = new Pin(EventColumn4);

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
    }
}
