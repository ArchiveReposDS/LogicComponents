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
            int a = CounterClass.CounterCable;
            int aa = CounterClass.CounterAction;

            Ram8 r = new Ram8();

            RamHelper rh = new RamHelper(r);

            byte[] value1 = new byte[] { 1, 0, 0, 0, 0, 0, 0, 1 };
            byte[] value2 = new byte[] { 1, 0, 0, 1, 1, 0, 0, 1 };

            rh.Save(value1, 0);
            var b12 = rh.Load(0);


            Cable.Join(new Pin() { State = 1 }, r.Power);

        



            Demultiplexer8 d = new Demultiplexer8();




            int k = 1;






        }
    }
}
