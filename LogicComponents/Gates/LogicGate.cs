using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class LogicGate
    {
        public event ActionDel EventIN1;
        public event ActionDel EventIN2;

        public Pin Pin1 { get; set; }
        public Pin Pin2 { get; set; }
        public Pin Output { get; set; }

        public LogicGate()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += RunIN1;
            EventIN2 += RunIN2;
            Pin1 = new Pin(EventIN1);
            Pin2 = new Pin(EventIN2);
            Output = new Pin();
        }

        public virtual void RunIN1()
        {

        }

        public virtual void RunIN2()
        {

        }
     
    }
}
