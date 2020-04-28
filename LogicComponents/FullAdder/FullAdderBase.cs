using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class FullAdderBase
    {
        public event ActionDel EventIN1;
        public event ActionDel EventIN2;
        public event ActionDel EventIN3;

        public Pin IN1 { get; set; }
        public Pin IN2 { get; set; }
        public Pin IN3 { get; set; }
        public Pin OUTSum { get; set; }
        public Pin OUTCarry { get; set; }

        public Or Or { get; set; } = new Or();
        public HalfAdder HalfAdder1 { get; set; } = new HalfAdder();
        public HalfAdder HalfAdder2 { get; set; } = new HalfAdder();

        public FullAdderBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += RunIN1;
            EventIN2 += RunIN2;
            EventIN3 += RunIN3;
            IN1 = new Pin(EventIN1);
            IN2 = new Pin(EventIN2);
            IN3 = new Pin(EventIN3);
            OUTSum = new Pin();
            OUTCarry = new Pin();
        }


        public virtual void RunIN1()
        {

        }

        public virtual void RunIN2()
        {

        }

        public virtual void RunIN3()
        {

        }


    }
}
