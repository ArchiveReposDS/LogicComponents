using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents.Gates
{
   public class And4
    {
        public event ActionDel EventIN1;
        public event ActionDel EventIN2;
        public event ActionDel EventIN3;
        public event ActionDel EventIN4;

        public Pin Pin1 { get; set; }
        public Pin Pin2 { get; set; }
        public Pin Pin3 { get; set; }
        public Pin Pin4 { get; set; }
        public Pin Output { get; set; }

        public And4()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += RunIN1;
            EventIN2 += RunIN2;
            EventIN3 += RunIN3;
            EventIN4 += RunIN4;
            Pin1 = new Pin(EventIN1);
            Pin2 = new Pin(EventIN2);
            Pin3 = new Pin(EventIN3);
            Pin4 = new Pin(EventIN4);
            Output = new Pin();
        }

        public void RunIN1()
        {
            GateLogic();
        }

        public void RunIN2()
        {
            GateLogic();
        }
        public void RunIN3()
        {
            GateLogic();
        }

        public void RunIN4()
        {
            GateLogic();
        }

        public virtual void GateLogic()
        {
            if (Pin1.State == 1 && Pin2.State == 1 && Pin3.State == 1 && Pin4.State == 1)
                Output.State = 1;
            else
                Output.State = 0;
        }

    }
}
