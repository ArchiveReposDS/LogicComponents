using LogicComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{

    // Address0 - AEX - ACCUMULATION REGISTER
    // Address1 - BEX
    // Address2 - CEX
    // Address3 - DEX - DATA REGISTER 
    // Address4 - EEX
    // Address6 - FEX - FLAG REGISTER
    // Address7 - GEX -
    // Address8 - IPX - Instuction Pointer 
    // Address9 - IST - Stack TOP 
    // Address10 - ISB - Stack BOTTOM 


    public class Start
    {
        public void Run()
        {
            CounterClass.CounterCable = 0;
            CounterClass.CounterAction = 0;



            Ram8 r = new Ram8();

            DataBus Db = new DataBus();
            Register registerA = new Register();

            Db.RegisterA = registerA;

            Cable.Join(new Pin() { State = 1 }, registerA.WriteEnable);

            Cable.Join(new Pin() { State = 1 }, registerA.DataInput1);
            Cable.Join(new Pin() { State = 1 }, registerA.DataInput2);
            Cable.Join(new Pin() { State = 1 }, registerA.DataInput3);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput4);
            Cable.Join(new Pin() { State = 1 }, registerA.DataInput5);
            Cable.Join(new Pin() { State = 1 }, registerA.DataInput6);
            Cable.Join(new Pin() { State = 1 }, registerA.DataInput7);
            Cable.Join(new Pin() { State = 1 }, registerA.DataInput8);

            //z A do B
            Cable.Join(new Pin() { State = 1 }, Db.FromA);
            Cable.Join(new Pin() { State = 1 }, Db.ToB);

            // z A do Ramu adres:111111 (64)
            Cable.Join(new Pin() { State = 1 }, Db.FromA);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressColumn1);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressColumn2);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressColumn3);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressRow1);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressRow2);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressRow3);
            Cable.Join(new Pin() { State = 1 }, Db.ToRam);

            // z Ramu adres 000000 (0) do B - skasowanie B
            Cable.Join(new Pin() { State = 0 }, Db.RamAddressColumn1);
            Cable.Join(new Pin() { State = 0 }, Db.RamAddressColumn2);
            Cable.Join(new Pin() { State = 0 }, Db.RamAddressColumn3);
            Cable.Join(new Pin() { State = 0 }, Db.RamAddressRow1);
            Cable.Join(new Pin() { State = 0 }, Db.RamAddressRow2);
            Cable.Join(new Pin() { State = 0 }, Db.RamAddressRow3);
            Cable.Join(new Pin() { State = 1 }, Db.FromRam);
       
            Cable.Join(new Pin() { State = 0 }, Db.ToB);
            Cable.Join(new Pin() { State = 1 }, Db.ToB);

            // z Ramu adres 11 do B - Przywrocenie stanu B
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressColumn1);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressColumn2);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressColumn3);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressRow1);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressRow2);
            Cable.Join(new Pin() { State = 1 }, Db.RamAddressRow3);
            Cable.Join(new Pin() { State = 0 }, Db.FromRam);
            Cable.Join(new Pin() { State = 1 }, Db.FromRam);
            Cable.Join(new Pin() { State = 0 }, Db.ToB);
            Cable.Join(new Pin() { State = 1 }, Db.ToB);



            int i1 = registerA.DataOutput1.State;
            int i2 = registerA.DataOutput2.State;
            int i3 = registerA.DataOutput3.State;
            int i4 = registerA.DataOutput4.State;
            int i5 = registerA.DataOutput5.State;
            int i6 = registerA.DataOutput6.State;
            int i7 = registerA.DataOutput7.State;
            int i8 = registerA.DataOutput8.State;


            Cable.Join(new Pin() { State = 0 }, registerA.WriteEnable);

            Cable.Join(new Pin() { State = 0 }, registerA.DataInput1);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput2);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput3);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput4);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput5);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput6);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput7);
            Cable.Join(new Pin() { State = 0 }, registerA.DataInput8);

            int q1 = registerA.DataOutput1.State;
            int q2 = registerA.DataOutput2.State;
            int q3 = registerA.DataOutput3.State;
            int q4 = registerA.DataOutput4.State;
            int q5 = registerA.DataOutput5.State;
            int q6 = registerA.DataOutput6.State;
            int q7 = registerA.DataOutput7.State;
            int q8 = registerA.DataOutput8.State;


            Cable.Join(new Pin() { State = 1 }, registerA.ReadEnable);

            int w1 = registerA.DataOutput1.State;
            int w2 = registerA.DataOutput2.State;
            int w3 = registerA.DataOutput3.State;
            int w4 = registerA.DataOutput4.State;
            int w5 = registerA.DataOutput5.State;
            int w6 = registerA.DataOutput6.State;
            int w7 = registerA.DataOutput7.State;
            int w8 = registerA.DataOutput8.State;












            // 1. zaladowac program do ramu

            Ram8 ram = new Ram8();
            RamHelper ramHelper = new RamHelper(ram);

            string ins1 = "mov eax, 3";


            byte[] value1 = new byte[] { 1, 0, 0, 0, 0, 0, 0, 1 };
            byte[] value2 = new byte[] { 1, 0, 0, 1, 1, 0, 0, 1 };

            ramHelper.Save(value1, 0);
            var aa = ramHelper.Load(0);

            // 2. uruchomic program
            // zegar tworzy impulsy, licznik impulsow uruchamia odpowiednia sciezke ktora wykonuje kroki programu
            // a) Instruction counter ++ 
            // b) Fetch instruction
            // c) decoding 
            // d) executing


















        }
    }
}
