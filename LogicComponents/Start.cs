using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Start
    {
        public void Run()
        {
            FullAdder fullAdder = new FullAdder();



            fullAdder.SetI1(1);
            fullAdder.SetI2(1);
            fullAdder.SetI3(1);
            fullAdder.SetI1(0);
            fullAdder.SetI1(1);
            fullAdder.SetI1(0);
            fullAdder.SetI2(0);
            fullAdder.SetI1(1);
            fullAdder.SetI2(1);




            int s = 1;

        }
    }
}
