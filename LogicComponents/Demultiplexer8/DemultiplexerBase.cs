using LogicComponents.Gates;
using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{ 
    public class DemultiplexerBase
    {
        public event ActionDel EventIN1;
        public event ActionDel EventIN2;
        public event ActionDel EventIN3;
        public event ActionDel EventIN4;

        public Pin IN1 { get; set; }
        public Pin IN2 { get; set; }
        public Pin IN3 { get; set; }
        public Pin Power { get; set; }
        public Pin OUT0 { get; set; }
        public Pin OUT1 { get; set; }
        public Pin OUT2 { get; set; }
        public Pin OUT3 { get; set; }
        public Pin OUT4 { get; set; }
        public Pin OUT5 { get; set; }
        public Pin OUT6 { get; set; }
        public Pin OUT7 { get; set; }
        public Not Not1 { get; set; } = new Not();
        public Not Not2 { get; set; } = new Not();
        public Not Not3 { get; set; } = new Not();
        public And4 And0 { get; set; } = new And4();
        public And4 And1 { get; set; } = new And4();
        public And4 And2 { get; set; } = new And4();
        public And4 And3 { get; set; } = new And4();
        public And4 And4 { get; set; } = new And4();
        public And4 And5 { get; set; } = new And4();
        public And4 And6 { get; set; } = new And4();
        public And4 And7 { get; set; } = new And4();

        public DemultiplexerBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN1 += ConnectIN1;
            EventIN2 += ConnectIN2;
            EventIN3 += ConnectIN3;
            EventIN4 += ConnectPower;
            IN3 = new Pin(EventIN3);
            IN2 = new Pin(EventIN2);
            IN1 = new Pin(EventIN1);
            Power = new Pin(EventIN4);
            OUT0 = new Pin();
            OUT1 = new Pin();
            OUT2 = new Pin();
            OUT3 = new Pin();
            OUT4 = new Pin();
            OUT5 = new Pin();
            OUT6 = new Pin();
            OUT7 = new Pin();
        }


        public virtual void ConnectIN3()
        {

        }

        public virtual void ConnectIN2()
        {

        }

        public virtual void ConnectIN1()
        {

        }
        public virtual void ConnectPower()
        {

        }
    }
}
