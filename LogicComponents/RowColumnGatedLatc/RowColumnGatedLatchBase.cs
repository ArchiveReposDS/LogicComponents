using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class RowColumnGatedLatchBase
    {
        public event ActionDel EventDataInput;
        public event ActionDel EventWriteEnable;
        public event ActionDel EventReadEnable;
        public event ActionDel EventRow;
        public event ActionDel EventColumn;

        // INPUT
        public Pin DataInput { get; set; }
        public Pin WriteEnable { get; set; }
        public Pin ReadEnable { get; set; }
        public Pin INRow { get; set; }
        public Pin INColumn { get; set; }

        // OUTPUT
        public Pin DataOutput { get; set; }

        // ELEMENTS
        public GatedLatch GatedLatch { get; set; } = new GatedLatch();
        public And And1 { get; set; } = new And();
        public And And2 { get; set; } = new And();
        public And And3 { get; set; } = new And();
        public And And4 { get; set; } = new And();

        public RowColumnGatedLatchBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventDataInput += ConnectDataInput;
            EventWriteEnable += ConnectWriteEnable;
            EventReadEnable += ConnectReadEnable;
            EventRow += ConnectRow;
            EventColumn += ConnectColumn;

            DataInput = new Pin(EventDataInput);
            WriteEnable = new Pin(EventWriteEnable);
            ReadEnable = new Pin(EventReadEnable);
            INRow = new Pin(EventRow);
            INColumn = new Pin(EventColumn);

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

        public virtual void ConnectRow()
        {
        }

        public virtual void ConnectColumn()
        {
        }
    }
}
