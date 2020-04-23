using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class HalfAdderBase
    {
        public event ActionDel EventIN1;
        public event ActionDel EventIN2;

        public Pin IN1 { get; set; }
        public Pin IN2 { get; set; }
        public Pin OUTSum { get; set; }
        public Pin OUTCarry { get; set; }

        public And And { get; set; } = new And();
        public Xor Xor { get; set; } = new Xor();

        public HalfAdderBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += RunIN1;
            EventIN2 += RunIN2;
            IN1 = new Pin(EventIN1);
            IN2 = new Pin(EventIN2);
            OUTSum = new Pin();
            OUTCarry = new Pin();
        }


        public virtual void RunIN1()
        {

        }

        public virtual void RunIN2()
        {
          
        }


    }
}
