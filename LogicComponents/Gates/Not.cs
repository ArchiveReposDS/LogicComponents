using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents.Gates
{
    public class Not
    {
        public event ActionDel EventIN1;

        public Pin Pin1 { get; set; }
        public Pin Output { get; set; }

        public Not()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += RunIN1;
            Pin1 = new Pin(EventIN1);
            Output = new Pin();
            Output.State = 1;
        }

        public void RunIN1()
        {
            if (Pin1.State == 0)
                Output.State = 1;
            else
                Output.State = 0;
        }

    }
}
