using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class DataBusHelper
    {
        public DataBus DataBus { get; set; }

        public DataBusHelper(DataBus dataBus)
        {
            this.DataBus = dataBus;
        }


        /// <summary>
        /// Adress Range 0-63
        /// </summary>
        /// <param name="input"> 1 or 0 </param>
        /// <param name="ramAddress"> 0 - 63 </param>
        public void SetRamAddress(int ramAddress)
        {
            byte i4Row, i2Row, i0Row, i4Column, i2Column, i0Column;
            ConvertAddressToBinary(ramAddress, out i4Row, out i2Row, out i0Row, out i4Column, out i2Column, out i0Column);

            // SET ADDRESS
            Cable.Join(new Pin() { State = i0Row }, DataBus.RamAddressRow1);
            Cable.Join(new Pin() { State = i2Row }, DataBus.RamAddressRow2);
            Cable.Join(new Pin() { State = i4Row }, DataBus.RamAddressRow3);
            Cable.Join(new Pin() { State = i0Column }, DataBus.RamAddressColumn1);
            Cable.Join(new Pin() { State = i2Column }, DataBus.RamAddressColumn2);
            Cable.Join(new Pin() { State = i4Column }, DataBus.RamAddressColumn3);
        }
       

        public void PutDataToRegisterA(byte[] input)
        {
            Cable.Join(new Pin() { State = 1 }, DataBus.RegisterA.WriteEnable);
            Cable.Join(new Pin() { State = input[0] }, DataBus.RegisterA.DataInput1);
            Cable.Join(new Pin() { State = input[1] }, DataBus.RegisterA.DataInput2);
            Cable.Join(new Pin() { State = input[2] }, DataBus.RegisterA.DataInput3);
            Cable.Join(new Pin() { State = input[3] }, DataBus.RegisterA.DataInput4);
            Cable.Join(new Pin() { State = input[4] }, DataBus.RegisterA.DataInput5);
            Cable.Join(new Pin() { State = input[5] }, DataBus.RegisterA.DataInput6);
            Cable.Join(new Pin() { State = input[6] }, DataBus.RegisterA.DataInput7);
            Cable.Join(new Pin() { State = input[7] }, DataBus.RegisterA.DataInput8);
            Cable.Join(new Pin() { State = 0 }, DataBus.RegisterA.WriteEnable);
        }


        private static void ConvertAddressToBinary(int ramAddress, out byte i4Row, out byte i2Row, out byte i0Row, out byte i4Column, out byte i2Column, out byte i0Column)
        {
            if (ramAddress > 63)
            {
                Console.WriteLine("WRONG RAM ADDREESS - RAM ADDRESS BEETWEN 0 - 63");
            }
            // ram address 0- 63
            i0Row = 0; i2Row = 0; i4Row = 0; i0Column = 0; i2Column = 0; i4Column = 0;
            int row;
            int column;

            column = ramAddress/8;
            row = ramAddress - (column * 8);


            switch (row)
            {
                case 0: i0Row = 0; i2Row = 0; i4Row = 0; break;
                case 1: i0Row = 1; i2Row = 0; i4Row = 0; break;
                case 2: i0Row = 0; i2Row = 1; i4Row = 0; break;
                case 3: i0Row = 1; i2Row = 1; i4Row = 0; break;
                case 4: i0Row = 0; i2Row = 0; i4Row = 1; break;
                case 5: i0Row = 1; i2Row = 0; i4Row = 1; break;
                case 6: i0Row = 0; i2Row = 1; i4Row = 1; break;
                case 7: i0Row = 1; i2Row = 1; i4Row = 1; break;
            }

            switch (column)
            {
                case 0: i0Column = 0; i2Column = 0; i4Column = 0; break;
                case 1: i0Column = 1; i2Column = 0; i4Column = 0; break;
                case 2: i0Column = 0; i2Column = 1; i4Column = 0; break;
                case 3: i0Column = 1; i2Column = 1; i4Column = 0; break;
                case 4: i0Column = 0; i2Column = 0; i4Column = 1; break;
                case 5: i0Column = 1; i2Column = 0; i4Column = 1; break;
                case 6: i0Column = 0; i2Column = 1; i4Column = 1; break;
                case 7: i0Column = 1; i2Column = 1; i4Column = 1; break;
            }
        }
    }
}
