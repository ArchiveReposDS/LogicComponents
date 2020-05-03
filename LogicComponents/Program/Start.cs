using LogicComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Start
    {
        public void Run()
        {

            Ram r = new Ram();

            RamHelper rh = new RamHelper(r);

            rh.Save(1, 13);
            rh.Save(1, 23);

            byte b12 = rh.Load(12);
            byte b13 = rh.Load(13);
            byte b14 = rh.Load(14);

            byte b23 = rh.Load(23);
            byte b24 = rh.Load(24);
            byte b25 = rh.Load(25);


            Cable.Join(new Pin() { State = 1 }, r.Power);
      
            // save to
            Cable.Join(new Pin() { State = 1 }, r.INRow4); // ROW
            Cable.Join(new Pin() { State = 1 }, r.INColumn2); // COLUMN
            Cable.Join(new Pin() { State = 1 }, r.DataInput);
            Cable.Join(new Pin() { State = 1 }, r.WriteEnable);
            Cable.Join(new Pin() { State = 0 }, r.WriteEnable);
            Cable.Join(new Pin() { State = 0 }, r.DataInput);


            Cable.Join(new Pin() { State = 1 }, r.INRow4);
            Cable.Join(new Pin() { State = 1 }, r.INColumn4);
            Cable.Join(new Pin() { State = 1 }, r.DataInput);
            Cable.Join(new Pin() { State = 1 }, r.WriteEnable);
            Cable.Join(new Pin() { State = 0 }, r.WriteEnable);
            Cable.Join(new Pin() { State = 0 }, r.DataInput);


      
            Cable.Join(new Pin() { State = 0 }, r.INRow0);
            Cable.Join(new Pin() { State = 0 }, r.INColumn0);

            Cable.Join(new Pin() { State = 1 }, r.ReadEnable);
            Cable.Join(new Pin() { State = 0 }, r.ReadEnable);

            Cable.Join(new Pin() { State = 1 }, r.INRow0);
            Cable.Join(new Pin() { State = 0 }, r.INColumn0);

            Cable.Join(new Pin() { State = 1 }, r.ReadEnable);
            Cable.Join(new Pin() { State = 0 }, r.ReadEnable);

            Cable.Join(new Pin() { State = 0 }, r.INRow0);
            Cable.Join(new Pin() { State = 1 }, r.INColumn0);

            Cable.Join(new Pin() { State = 1 }, r.ReadEnable);
            Cable.Join(new Pin() { State = 0 }, r.ReadEnable);

            Cable.Join(new Pin() { State = 1 }, r.INRow0);
            Cable.Join(new Pin() { State = 1 }, r.INColumn0);

            Cable.Join(new Pin() { State = 1 }, r.ReadEnable);
            Cable.Join(new Pin() { State = 0 }, r.ReadEnable);



            Demultiplexer8 d = new Demultiplexer8();




            int k = 1;






        }
    }
}
