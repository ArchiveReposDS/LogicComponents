using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;

namespace LogicComponents
{
    public class DataBusBase
    {
        public event ActionDel EventFromA;
        public event ActionDel EventFromB;
        public event ActionDel EventFromRam;
        public event ActionDel EventToA;
        public event ActionDel EventToB;
        public event ActionDel EventToRam;
        public event ActionDel EventRamAddressRow1;
        public event ActionDel EventRamAddressRow2;
        public event ActionDel EventRamAddressRow3;
        public event ActionDel EventRamAddressColumn1;
        public event ActionDel EventRamAddressColumn2;
        public event ActionDel EventRamAddressColumn3;
        public event ActionDel EventDataWire1;
        public event ActionDel EventDataWire2;
        public event ActionDel EventDataWire3;
        public event ActionDel EventDataWire4;
        public event ActionDel EventDataWire5;
        public event ActionDel EventDataWire6;
        public event ActionDel EventDataWire7;
        public event ActionDel EventDataWire8;

        // INPUTS
        public Pin FromA { get; set; }
        public Pin FromB { get; set; }
        public Pin FromRam { get; set; }
        public Pin ToA { get; set; }
        public Pin ToB { get; set; }
        public Pin ToRam { get; set; }
        public Pin RamAddressRow1 { get; set; }
        public Pin RamAddressRow2 { get; set; }
        public Pin RamAddressRow3 { get; set; }
        public Pin RamAddressColumn1 { get; set; }
        public Pin RamAddressColumn2 { get; set; }
        public Pin RamAddressColumn3 { get; set; }

        public Pin DataWire1 { get; set; }
        public Pin DataWire2 { get; set; }
        public Pin DataWire3 { get; set; }
        public Pin DataWire4 { get; set; }
        public Pin DataWire5 { get; set; }
        public Pin DataWire6 { get; set; }
        public Pin DataWire7 { get; set; }
        public Pin DataWire8 { get; set; }

        // ELEMENTS
        public Register RegisterA { get; set; } = new Register();
        public Register RegisterB { get; set; } = new Register();
        public Ram8 Ram { get; set; } = new Ram8();
        public Not Not { get; set; } = new Not();

        public DataBusBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            EventFromA += MethodFromA;
            EventFromB += MethodFromB;
            EventFromRam += MethodFromRam;
            EventToA += MethodToA;
            EventToB += MethodToB;
            EventToRam += MethodToRam;
            EventRamAddressRow1 += MethodRamAddressRow1;
            EventRamAddressRow2 += MethodRamAddressRow2;
            EventRamAddressRow3 += MethodRamAddressRow3;
            EventRamAddressColumn1 += MethodRamAddressColumn1;
            EventRamAddressColumn2 += MethodRamAddressColumn2;
            EventRamAddressColumn3 += MethodRamAddressColumn3;
            EventDataWire1 += MethodDataWire1;
            EventDataWire1 += MethodDataWire2;
            EventDataWire1 += MethodDataWire3;
            EventDataWire1 += MethodDataWire4;
            EventDataWire1 += MethodDataWire5;
            EventDataWire1 += MethodDataWire6;
            EventDataWire1 += MethodDataWire7;
            EventDataWire1 += MethodDataWire8;


            FromA = new Pin(EventFromA);
            FromB = new Pin(EventFromB);
            FromRam = new Pin(EventFromRam);
            ToA = new Pin(EventToA);
            ToB = new Pin(EventToB);
            ToRam = new Pin(EventToRam);
            RamAddressRow1 = new Pin(EventRamAddressRow1);
            RamAddressRow2 = new Pin(EventRamAddressRow2);
            RamAddressRow3 = new Pin(EventRamAddressRow3);
            RamAddressColumn1 = new Pin(EventRamAddressColumn1);
            RamAddressColumn2 = new Pin(EventRamAddressColumn2);
            RamAddressColumn3 = new Pin(EventRamAddressColumn3);
            DataWire1 = new Pin(EventDataWire1);
            DataWire2 = new Pin(EventDataWire2);
            DataWire3 = new Pin(EventDataWire3);
            DataWire4 = new Pin(EventDataWire4);
            DataWire5 = new Pin(EventDataWire5);
            DataWire6 = new Pin(EventDataWire6);
            DataWire7 = new Pin(EventDataWire7);
            DataWire8 = new Pin(EventDataWire8);


        }

        private void MethodDataWire1() { }
        private void MethodDataWire2() { }
        private void MethodDataWire3() { }
        private void MethodDataWire4() { }
        private void MethodDataWire5() { }
        private void MethodDataWire6() { }
        private void MethodDataWire7() { }
        private void MethodDataWire8() { }

        public virtual void MethodFromA() { }
        public virtual void MethodFromB() { }
        public virtual void MethodFromRam() { }
        public virtual void MethodToA() { }
        public virtual void MethodToB() { }
        public virtual void MethodToRam() { }
        public virtual void MethodRamAddressRow1() { }
        public virtual void MethodRamAddressRow2() { }
        public virtual void MethodRamAddressRow3() { }
        public virtual void MethodRamAddressColumn1() { }
        public virtual void MethodRamAddressColumn2() { }
        public virtual void MethodRamAddressColumn3() { }
    }
}
