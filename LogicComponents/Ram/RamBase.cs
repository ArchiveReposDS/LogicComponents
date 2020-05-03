using LogicComponents;
using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class RamBase
    {
        public event ActionDel EventPower;
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
        public Pin Power { get; set; }
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
        public Pin DataOutput { get; set; }

        // ELEMENTS
        public RowColumnGatedLatch RowColumnGatedLatch1 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch2 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch3 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch4 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch5 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch6 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch7 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch8 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch9 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch10 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch11 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch12 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch13 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch14 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch15 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch16 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch17 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch18 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch19 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch20 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch21 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch22 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch23 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch24 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch25 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch26 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch27 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch28 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch29 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch30 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch31 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch32 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch33 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch34 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch35 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch36 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch37 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch38 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch39 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch40 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch41 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch42 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch43 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch44 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch45 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch46 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch47 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch48 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch49 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch50 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch51 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch52 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch53 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch54 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch55 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch56 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch57 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch58 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch59 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch60 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch61 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch62 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch63 { get; set; } = new RowColumnGatedLatch();
        public RowColumnGatedLatch RowColumnGatedLatch64 { get; set; } = new RowColumnGatedLatch();




        public Demultiplexer8 Demultiplexer8Row { get; set; } = new Demultiplexer8();
        public Demultiplexer8 Demultiplexer8Column { get; set; } = new Demultiplexer8();
        public Or64Inputs Or64Inputs { get; set; } = new Or64Inputs();

        public RamBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventPower += ConnectPower;
            EventDataInput += ConnectDataInput;
            EventWriteEnable += ConnectWriteEnable;
            EventReadEnable += ConnectReadEnable;
            EventRow0 += ConnectRow0;
            EventRow2 += ConnectRow2;
            EventRow4 += ConnectRow4;
            EventColumn0 += ConnectColumn0;
            EventColumn2 += ConnectColumn2;
            EventColumn4 += ConnectColumn4;
            EventColumn4 += ConnectPower;

            DataInput = new Pin(EventDataInput);
            WriteEnable = new Pin(EventWriteEnable);
            ReadEnable = new Pin(EventReadEnable);
            INRow0 = new Pin(EventRow0);
            INRow2 = new Pin(EventRow2);
            INRow4 = new Pin(EventRow4);
            INColumn0 = new Pin(EventColumn0);
            INColumn2 = new Pin(EventColumn2);
            INColumn4 = new Pin(EventColumn4);
            Power = new Pin(EventPower);

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
        public virtual void ConnectPower()
        {
        }
    }
}
