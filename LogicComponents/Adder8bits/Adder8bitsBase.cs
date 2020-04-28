using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class Adder8bitsBase
    {
        public event ActionDel EventIN0A;
        public event ActionDel EventIN1A;
        public event ActionDel EventIN2A;
        public event ActionDel EventIN3A;
        public event ActionDel EventIN4A;
        public event ActionDel EventIN5A;
        public event ActionDel EventIN6A;
        public event ActionDel EventIN7A;

        public event ActionDel EventIN0B;
        public event ActionDel EventIN1B;
        public event ActionDel EventIN2B;
        public event ActionDel EventIN3B;
        public event ActionDel EventIN4B;
        public event ActionDel EventIN5B;
        public event ActionDel EventIN6B;
        public event ActionDel EventIN7B;


        public Pin IN0A { get; set; }
        public Pin IN1A { get; set; }
        public Pin IN2A { get; set; }
        public Pin IN3A { get; set; }
        public Pin IN4A { get; set; }
        public Pin IN5A { get; set; }
        public Pin IN6A { get; set; }
        public Pin IN7A { get; set; }

        public Pin IN0B { get; set; }
        public Pin IN1B { get; set; }
        public Pin IN2B { get; set; }
        public Pin IN3B { get; set; }
        public Pin IN4B { get; set; }
        public Pin IN5B { get; set; }
        public Pin IN6B { get; set; }
        public Pin IN7B { get; set; }


        public Pin OUTSum0 { get; set; }
        public Pin OUTSum1 { get; set; }
        public Pin OUTSum2 { get; set; }
        public Pin OUTSum3 { get; set; }
        public Pin OUTSum4 { get; set; }
        public Pin OUTSum5 { get; set; }
        public Pin OUTSum6 { get; set; }
        public Pin OUTSum7 { get; set; }
        public Pin OUTCarry { get; set; }

        public HalfAdder HalfAdder { get; set; } = new HalfAdder();
        public FullAdder FullAdder1 { get; set; } = new FullAdder();
        public FullAdder FullAdder2 { get; set; } = new FullAdder();
        public FullAdder FullAdder3 { get; set; } = new FullAdder();
        public FullAdder FullAdder4 { get; set; } = new FullAdder();
        public FullAdder FullAdder5 { get; set; } = new FullAdder();
        public FullAdder FullAdder6 { get; set; } = new FullAdder();
        public FullAdder FullAdder7 { get; set; } = new FullAdder();

        public Adder8bitsBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventIN0A += RunIN0A;
            EventIN1A += RunIN1A;
            EventIN2A += RunIN2A;
            EventIN3A += RunIN3A;
            EventIN4A += RunIN4A;
            EventIN5A += RunIN5A;
            EventIN6A += RunIN6A;
            EventIN7A += RunIN7A;

            EventIN0B += RunIN0B;
            EventIN1B += RunIN1B;
            EventIN2B += RunIN2B;
            EventIN3B += RunIN3B;
            EventIN4B += RunIN4B;
            EventIN5B += RunIN5B;
            EventIN6B += RunIN6B;
            EventIN7B += RunIN7B;

            IN0A = new Pin(EventIN0A);
            IN1A = new Pin(EventIN1A);
            IN2A = new Pin(EventIN2A);
            IN3A = new Pin(EventIN3A);
            IN4A = new Pin(EventIN4A);
            IN5A = new Pin(EventIN5A);
            IN6A = new Pin(EventIN6A);
            IN7A = new Pin(EventIN7A);

            IN0B = new Pin(EventIN0B);
            IN1B = new Pin(EventIN1B);
            IN2B = new Pin(EventIN2B);
            IN3B = new Pin(EventIN3B);
            IN4B = new Pin(EventIN4B);
            IN5B = new Pin(EventIN5B);
            IN6B = new Pin(EventIN6B);
            IN7B = new Pin(EventIN7B);

            OUTSum0 = new Pin();
            OUTSum1 = new Pin();
            OUTSum2 = new Pin();
            OUTSum3 = new Pin();
            OUTSum4 = new Pin();
            OUTSum5 = new Pin();
            OUTSum6 = new Pin();
            OUTSum7 = new Pin();
            OUTCarry = new Pin();
        }


        public virtual void RunIN0A()
        {
        }
        public virtual void RunIN1A()
        {
        }
        public virtual void RunIN2A()
        {
        }
        public virtual void RunIN3A()
        {
        }
        public virtual void RunIN4A()
        {
        }
        public virtual void RunIN5A()
        {
        }
        public virtual void RunIN6A()
        {
        }
        public virtual void RunIN7A()
        {
        }



        public virtual void RunIN0B()
        {
        }
        public virtual void RunIN1B()
        {
        }
        public virtual void RunIN2B()
        {
        }
        public virtual void RunIN3B()
        {
        }
        public virtual void RunIN4B()
        {
        }
        public virtual void RunIN5B()
        {
        }
        public virtual void RunIN6B()
        {
        }
        public virtual void RunIN7B()
        {
        }


    }
}
