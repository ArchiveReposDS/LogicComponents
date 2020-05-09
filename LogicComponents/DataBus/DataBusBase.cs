using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class DataBusBase
    {
        public event ActionDel EventFromAReady;
        public event ActionDel EventFromAGo;
        public event ActionDel EventFromB;
        public event ActionDel EventFromRam;
        public event ActionDel EventToA;
        public event ActionDel EventToB;
        public event ActionDel EventToRam;
        public event ActionDel EventFromRamAddressReg;
        public event ActionDel EventToRamAddressReg;
        public event ActionDel EventDataWire1;
        public event ActionDel EventDataWire2;
        public event ActionDel EventDataWire3;
        public event ActionDel EventDataWire4;
        public event ActionDel EventDataWire5;
        public event ActionDel EventDataWire6;
        public event ActionDel EventDataWire7;
        public event ActionDel EventDataWire8;
        public event ActionDel EventClock;

        // INPUTS PUBLIC
        public Pin INClock { get; set; }
        public Pin INToA { get; set; }
        public Pin INToB { get; set; }
        public Pin INToRam { get; set; }
        public Pin INToRamAddressReg { get; set; } 
        public Pin INFromA { get; set; }
        public Pin INFromB { get; set; }
        public Pin INFromRam { get; set; }
        public Pin INFromRamAddressReg { get; set; } // to by moglo wykonywac sie z automatu

        // ELEMENTS PINS
        internal Pin INFromAGo { get; set; }

        internal Pin DataWire1 { get; set; }
        internal Pin DataWire2 { get; set; }
        internal Pin DataWire3 { get; set; }
        internal Pin DataWire4 { get; set; }
        internal Pin DataWire5 { get; set; }
        internal Pin DataWire6 { get; set; }
        internal Pin DataWire7 { get; set; }
        internal Pin DataWire8 { get; set; }

        // ELEMENTS
        public Register RegisterA { get; set; } = new Register();
        public Register RegisterB { get; set; } = new Register();
        public Register RamAddressRegister { get; set; } = new Register();
        public Ram8 Ram { get; set; } = new Ram8();
        public And AndGateClockFromA { get; set; } = new And();

        public DataBusBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventFromAReady += MethodFromAReady;
            EventFromAGo += MethodFromAGo;
            EventFromB += MethodFromB;
            EventFromRam += MethodFromRam;
            EventToA += MethodToA;
            EventToB += MethodToB;
            EventToRam += MethodToRam;
            EventFromRamAddressReg += MethodFromRamAddressReg;
            EventToRamAddressReg += MethodToRamAddressReg;
            EventDataWire1 += MethodDataWire1;
            EventDataWire1 += MethodDataWire2;
            EventDataWire1 += MethodDataWire3;
            EventDataWire1 += MethodDataWire4;
            EventDataWire1 += MethodDataWire5;
            EventDataWire1 += MethodDataWire6;
            EventDataWire1 += MethodDataWire7;
            EventDataWire1 += MethodDataWire8;
            EventClock += MethodClock;


            INFromA = new Pin(EventFromA);
            INFromAGo = new Pin(EventFromAGo);
            INFromB = new Pin(EventFromB);
            INFromRam = new Pin(EventFromRam);
            INToA = new Pin(EventToA);
            INToB = new Pin(EventToB);
            INToRam = new Pin(EventToRam);
            INFromRamAddressReg = new Pin(EventFromRamAddressReg);
            INToRamAddressReg = new Pin(EventToRamAddressReg);
            DataWire1 = new Pin(EventDataWire1);
            DataWire2 = new Pin(EventDataWire2);
            DataWire3 = new Pin(EventDataWire3);
            DataWire4 = new Pin(EventDataWire4);
            DataWire5 = new Pin(EventDataWire5);
            DataWire6 = new Pin(EventDataWire6);
            DataWire7 = new Pin(EventDataWire7);
            DataWire8 = new Pin(EventDataWire8);
            INClock = new Pin(EventClock);

        }

        private void MethodDataWire1() { }
        private void MethodDataWire2() { }
        private void MethodDataWire3() { }
        private void MethodDataWire4() { }
        private void MethodDataWire5() { }
        private void MethodDataWire6() { }
        private void MethodDataWire7() { }
        private void MethodDataWire8() { }

        public virtual void MethodFromAReady() { }
        public virtual void MethodFromAGo() { }
        public virtual void MethodFromB() { }
        public virtual void MethodFromRam() { }
        public virtual void MethodToA() { }
        public virtual void MethodToB() { }
        public virtual void MethodToRam() { }
        public virtual void MethodFromRamAddressReg() { }
        public virtual void MethodToRamAddressReg() { }
        public virtual void MethodClock() { }
    }
}
