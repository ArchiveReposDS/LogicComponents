using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class RamHelper
    {
        public Ram8 Ram8 { get; set; }

        public RamHelper(Ram8 ram)
        {
            this.Ram8 = ram;
        }


        /// <summary>
        /// Adress Range 0-63
        /// </summary>
        /// <param name="input"> 1 or 0 </param>
        /// <param name="ramAddress"> 0 - 63 </param>
        public void Save(byte[] input, int ramAddress)
        {
            byte i4Row, i2Row, i0Row, i4Column, i2Column, i0Column;
            ConvertAddressToBinary(ramAddress, out i4Row, out i2Row, out i0Row, out i4Column, out i2Column, out i0Column);

            // INITIALIZE
            Cable.Join(new Pin() { State = 1 }, Ram8.Power);
            Cable.Join(new Pin() { State = 1 }, Ram8.WriteEnable);

            // SET ADDRESS
            Cable.Join(new Pin() { State = i0Row }, Ram8.INRow0);
            Cable.Join(new Pin() { State = i2Row }, Ram8.INRow2);
            Cable.Join(new Pin() { State = i4Row }, Ram8.INRow4);
            Cable.Join(new Pin() { State = i0Column }, Ram8.INColumn0);
            Cable.Join(new Pin() { State = i2Column }, Ram8.INColumn2);
            Cable.Join(new Pin() { State = i4Column }, Ram8.INColumn4);
            // SET INPUT VALUE
            Cable.Join(new Pin() { State = input[0] }, Ram8.DataInput1);
            Cable.Join(new Pin() { State = input[1] }, Ram8.DataInput2);
            Cable.Join(new Pin() { State = input[2] }, Ram8.DataInput3);
            Cable.Join(new Pin() { State = input[3] }, Ram8.DataInput4);
            Cable.Join(new Pin() { State = input[4] }, Ram8.DataInput5);
            Cable.Join(new Pin() { State = input[5] }, Ram8.DataInput6);
            Cable.Join(new Pin() { State = input[6] }, Ram8.DataInput7);
            Cable.Join(new Pin() { State = input[7] }, Ram8.DataInput8);

            Cable.Join(new Pin() { State = 0 }, Ram8.WriteEnable);

            DefaultSetting();
        }


        public byte[] Load(int ramAddress)
        {
            byte i4Row, i2Row, i0Row, i4Column, i2Column, i0Column;
            ConvertAddressToBinary(ramAddress, out i4Row, out i2Row, out i0Row, out i4Column, out i2Column, out i0Column);

            // SET ADDRESS
            Cable.Join(new Pin() { State = i0Row }, Ram8.INRow0);
            Cable.Join(new Pin() { State = i2Row }, Ram8.INRow2);
            Cable.Join(new Pin() { State = i4Row }, Ram8.INRow4);
            Cable.Join(new Pin() { State = i0Column }, Ram8.INColumn0);
            Cable.Join(new Pin() { State = i2Column }, Ram8.INColumn2);
            Cable.Join(new Pin() { State = i4Column }, Ram8.INColumn4);

            Cable.Join(new Pin() { State = 1 }, Ram8.ReadEnable);
            byte[] output = new byte[8];
            output[0] = Ram8.DataOutput1.State;
            output[1] = Ram8.DataOutput2.State;
            output[2] = Ram8.DataOutput3.State;
            output[3] = Ram8.DataOutput4.State;
            output[4] = Ram8.DataOutput5.State;
            output[5] = Ram8.DataOutput6.State;
            output[6] = Ram8.DataOutput7.State;
            output[7] = Ram8.DataOutput8.State;

            DefaultSetting();

            return output;
        }

        private static void ConvertAddressToBinary(int ramAddress, out byte i4Row, out byte i2Row, out byte i0Row, out byte i4Column, out byte i2Column, out byte i0Column)
        {
            byte column = (byte)(ramAddress / 8);
            byte row = (byte)(ramAddress % 8);

            i4Row = (byte)(row / 4);
            if (i4Row == 1)
                row = (byte)(row - 4);
            i2Row = (byte)(row / 2);
            if (i2Row == 1)
                row = (byte)(row - 2);
            i0Row = (byte)(row % 2);
            i4Column = (byte)(column / 4);
            if (i4Column == 1)
                column = (byte)(column - 4);
            i2Column = (byte)(column / 2);
            if (i2Column == 1)
                column = (byte)(column - 2);
            i0Column = (byte)(column % 2);
        }

        private void DefaultSetting()
        {
            Cable.Join(new Pin() { State = 0 }, Ram8.INRow0);
            Cable.Join(new Pin() { State = 0 }, Ram8.INRow2);
            Cable.Join(new Pin() { State = 0 }, Ram8.INRow4);

            Cable.Join(new Pin() { State = 0 }, Ram8.INColumn0);
            Cable.Join(new Pin() { State = 0 }, Ram8.INColumn2);
            Cable.Join(new Pin() { State = 0 }, Ram8.INColumn4);
        }
    }
}
