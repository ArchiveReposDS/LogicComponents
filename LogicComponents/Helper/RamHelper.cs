using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class RamHelper
    {
        public Ram Ram { get; set; }

        public RamHelper(Ram ram)
        {
            this.Ram = ram;
        }


        /// <summary>
        /// Adress Range 0-63
        /// </summary>
        /// <param name="input"> 1 or 0 </param>
        /// <param name="ramAddress"> 0 - 63 </param>
        public void Save(byte input, int ramAddress)
        {
            byte i4Row, i2Row, i0Row, i4Column, i2Column, i0Column;
            ConvertToBinary(ramAddress, out i4Row, out i2Row, out i0Row, out i4Column, out i2Column, out i0Column);

            Cable.Join(new Pin() { State = 1 }, Ram.Power);
            Cable.Join(new Pin() { State = 1 }, Ram.WriteEnable);

            Cable.Join(new Pin() { State = i0Row }, Ram.INRow0);
            Cable.Join(new Pin() { State = i2Row }, Ram.INRow2);
            Cable.Join(new Pin() { State = i4Row }, Ram.INRow4);

            Cable.Join(new Pin() { State = i0Column }, Ram.INColumn0);
            Cable.Join(new Pin() { State = i2Column }, Ram.INColumn2);
            Cable.Join(new Pin() { State = i4Column }, Ram.INColumn4);

            Cable.Join(new Pin() { State = input }, Ram.DataInput);

            Cable.Join(new Pin() { State = 0 }, Ram.WriteEnable);

            Cable.Join(new Pin() { State = 0 }, Ram.INRow0);
            Cable.Join(new Pin() { State = 0 }, Ram.INRow2);
            Cable.Join(new Pin() { State = 0 }, Ram.INRow4);

            Cable.Join(new Pin() { State = 0 }, Ram.INColumn0);
            Cable.Join(new Pin() { State = 0 }, Ram.INColumn2);
            Cable.Join(new Pin() { State = 0 }, Ram.INColumn4);

        }
   

        public byte Load(int ramAddress)
        {
            byte i4Row, i2Row, i0Row, i4Column, i2Column, i0Column;
            ConvertToBinary(ramAddress, out i4Row, out i2Row, out i0Row, out i4Column, out i2Column, out i0Column);


            Cable.Join(new Pin() { State = i0Row }, Ram.INRow0);
            Cable.Join(new Pin() { State = i2Row }, Ram.INRow2);
            Cable.Join(new Pin() { State = i4Row }, Ram.INRow4);

            Cable.Join(new Pin() { State = i0Column }, Ram.INColumn0);
            Cable.Join(new Pin() { State = i2Column }, Ram.INColumn2);
            Cable.Join(new Pin() { State = i4Column }, Ram.INColumn4);

            Cable.Join(new Pin() { State = 1 }, Ram.ReadEnable);
            byte output = Ram.DataOutput.State;

            Cable.Join(new Pin() { State = 0 }, Ram.INRow0);
            Cable.Join(new Pin() { State = 0 }, Ram.INRow2);
            Cable.Join(new Pin() { State = 0 }, Ram.INRow4);

            Cable.Join(new Pin() { State = 0 }, Ram.INColumn0);
            Cable.Join(new Pin() { State = 0 }, Ram.INColumn2);
            Cable.Join(new Pin() { State = 0 }, Ram.INColumn4);

            return output;
        }

        private static void ConvertToBinary(int ramAddress, out byte i4Row, out byte i2Row, out byte i0Row, out byte i4Column, out byte i2Column, out byte i0Column)
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
    }
}
