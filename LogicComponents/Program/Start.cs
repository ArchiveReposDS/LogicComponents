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
