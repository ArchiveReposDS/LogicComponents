using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class DataBus : DataBusBase
    {
        public override void MethodFromA()
        {
            Cable.Join(FromA, RegisterA.ReadEnable);
            Cable.Join(RegisterA.GatedLatch1.DataOutput, DataWire1);
            Cable.Join(RegisterA.GatedLatch2.DataOutput, DataWire2);
            Cable.Join(RegisterA.GatedLatch3.DataOutput, DataWire3);
            Cable.Join(RegisterA.GatedLatch4.DataOutput, DataWire4);
            Cable.Join(RegisterA.GatedLatch5.DataOutput, DataWire5);
            Cable.Join(RegisterA.GatedLatch6.DataOutput, DataWire6);
            Cable.Join(RegisterA.GatedLatch7.DataOutput, DataWire7);
            Cable.Join(RegisterA.GatedLatch8.DataOutput, DataWire8);

        }

        public override void MethodFromB()
        {
            Cable.Join(FromB, RegisterB.ReadEnable);
            Cable.Join(RegisterB.GatedLatch1.DataOutput, DataWire1);
            Cable.Join(RegisterB.GatedLatch2.DataOutput, DataWire2);
            Cable.Join(RegisterB.GatedLatch3.DataOutput, DataWire3);
            Cable.Join(RegisterB.GatedLatch4.DataOutput, DataWire4);
            Cable.Join(RegisterB.GatedLatch5.DataOutput, DataWire5);
            Cable.Join(RegisterB.GatedLatch6.DataOutput, DataWire6);
            Cable.Join(RegisterB.GatedLatch7.DataOutput, DataWire7);
            Cable.Join(RegisterB.GatedLatch8.DataOutput, DataWire8);
        }

        public override void MethodFromRam()
        {
            Cable.Join(FromRam, Ram.ReadEnable);
            Cable.Join(Ram.Ram1.DataOutput, DataWire1);
            Cable.Join(Ram.Ram2.DataOutput, DataWire2);
            Cable.Join(Ram.Ram3.DataOutput, DataWire3);
            Cable.Join(Ram.Ram4.DataOutput, DataWire4);
            Cable.Join(Ram.Ram5.DataOutput, DataWire5);
            Cable.Join(Ram.Ram6.DataOutput, DataWire6);
            Cable.Join(Ram.Ram7.DataOutput, DataWire7);
            Cable.Join(Ram.Ram8.DataOutput, DataWire8);
        }

        public override void MethodRamAddressColumn1()
        {
            Cable.Join(RamAddressColumn1, Ram.Ram1.INColumn0);
            Cable.Join(RamAddressColumn1, Ram.Ram2.INColumn0);
            Cable.Join(RamAddressColumn1, Ram.Ram3.INColumn0);
            Cable.Join(RamAddressColumn1, Ram.Ram4.INColumn0);
            Cable.Join(RamAddressColumn1, Ram.Ram5.INColumn0);
            Cable.Join(RamAddressColumn1, Ram.Ram6.INColumn0);
            Cable.Join(RamAddressColumn1, Ram.Ram7.INColumn0);
            Cable.Join(RamAddressColumn1, Ram.Ram8.INColumn0);
        }

        public override void MethodRamAddressColumn2()
        {
            Cable.Join(RamAddressColumn2, Ram.Ram1.INColumn2);
            Cable.Join(RamAddressColumn2, Ram.Ram2.INColumn2);
            Cable.Join(RamAddressColumn2, Ram.Ram3.INColumn2);
            Cable.Join(RamAddressColumn2, Ram.Ram4.INColumn2);
            Cable.Join(RamAddressColumn2, Ram.Ram5.INColumn2);
            Cable.Join(RamAddressColumn2, Ram.Ram6.INColumn2);
            Cable.Join(RamAddressColumn2, Ram.Ram7.INColumn2);
            Cable.Join(RamAddressColumn2, Ram.Ram8.INColumn2);
        }

        public override void MethodRamAddressColumn3()
        {
            Cable.Join(RamAddressColumn3, Ram.Ram1.INColumn4);
            Cable.Join(RamAddressColumn3, Ram.Ram2.INColumn4);
            Cable.Join(RamAddressColumn3, Ram.Ram3.INColumn4);
            Cable.Join(RamAddressColumn3, Ram.Ram4.INColumn4);
            Cable.Join(RamAddressColumn3, Ram.Ram5.INColumn4);
            Cable.Join(RamAddressColumn3, Ram.Ram6.INColumn4);
            Cable.Join(RamAddressColumn3, Ram.Ram7.INColumn4);
            Cable.Join(RamAddressColumn3, Ram.Ram8.INColumn4);
        }

        public override void MethodRamAddressRow1()
        {
            Cable.Join(RamAddressRow1, Ram.Ram1.INRow0);
            Cable.Join(RamAddressRow1, Ram.Ram2.INRow0);
            Cable.Join(RamAddressRow1, Ram.Ram3.INRow0);
            Cable.Join(RamAddressRow1, Ram.Ram4.INRow0);
            Cable.Join(RamAddressRow1, Ram.Ram5.INRow0);
            Cable.Join(RamAddressRow1, Ram.Ram6.INRow0);
            Cable.Join(RamAddressRow1, Ram.Ram7.INRow0);
            Cable.Join(RamAddressRow1, Ram.Ram8.INRow0);
        }

        public override void MethodRamAddressRow2()
        {
            Cable.Join(RamAddressRow2, Ram.Ram1.INRow2);
            Cable.Join(RamAddressRow2, Ram.Ram2.INRow2);
            Cable.Join(RamAddressRow2, Ram.Ram3.INRow2);
            Cable.Join(RamAddressRow2, Ram.Ram4.INRow2);
            Cable.Join(RamAddressRow2, Ram.Ram5.INRow2);
            Cable.Join(RamAddressRow2, Ram.Ram6.INRow2);
            Cable.Join(RamAddressRow2, Ram.Ram7.INRow2);
            Cable.Join(RamAddressRow2, Ram.Ram8.INRow2);
        }

        public override void MethodRamAddressRow3()
        {
            Cable.Join(RamAddressRow3, Ram.Ram1.INRow4);
            Cable.Join(RamAddressRow3, Ram.Ram2.INRow4);
            Cable.Join(RamAddressRow3, Ram.Ram3.INRow4);
            Cable.Join(RamAddressRow3, Ram.Ram4.INRow4);
            Cable.Join(RamAddressRow3, Ram.Ram5.INRow4);
            Cable.Join(RamAddressRow3, Ram.Ram6.INRow4);
            Cable.Join(RamAddressRow3, Ram.Ram7.INRow4);
            Cable.Join(RamAddressRow3, Ram.Ram8.INRow4);
        }

        public override void MethodToA()
        {
            Cable.Join(ToA, RegisterA.WriteEnable);
            Cable.Join(DataWire1, RegisterA.DataInput1);
            Cable.Join(DataWire2, RegisterA.DataInput2);
            Cable.Join(DataWire3, RegisterA.DataInput3);
            Cable.Join(DataWire4, RegisterA.DataInput4);
            Cable.Join(DataWire5, RegisterA.DataInput5);
            Cable.Join(DataWire6, RegisterA.DataInput6);
            Cable.Join(DataWire7, RegisterA.DataInput7);
            Cable.Join(DataWire8, RegisterA.DataInput8);

        }

        public override void MethodToB()
        {
            Cable.Join(ToB, RegisterB.WriteEnable);
            Cable.Join(DataWire1, RegisterB.DataInput1);
            Cable.Join(DataWire2, RegisterB.DataInput2);
            Cable.Join(DataWire3, RegisterB.DataInput3);
            Cable.Join(DataWire4, RegisterB.DataInput4);
            Cable.Join(DataWire5, RegisterB.DataInput5);
            Cable.Join(DataWire6, RegisterB.DataInput6);
            Cable.Join(DataWire7, RegisterB.DataInput7);
            Cable.Join(DataWire8, RegisterB.DataInput8);
        }

        public override void MethodToRam()
        {
            Cable.Join(ToRam, Ram.WriteEnable);
            Cable.Join(DataWire1, Ram.Ram1.DataInput);
            Cable.Join(DataWire2, Ram.Ram2.DataInput);
            Cable.Join(DataWire3, Ram.Ram3.DataInput);
            Cable.Join(DataWire4, Ram.Ram4.DataInput);
            Cable.Join(DataWire5, Ram.Ram5.DataInput);
            Cable.Join(DataWire6, Ram.Ram6.DataInput);
            Cable.Join(DataWire7, Ram.Ram7.DataInput);
            Cable.Join(DataWire8, Ram.Ram8.DataInput);
        }
    }
}
