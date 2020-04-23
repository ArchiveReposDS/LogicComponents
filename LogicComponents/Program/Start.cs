using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Start
    {
        public void Run()
        {

            Pin pin1 = new Pin();
            pin1.Set(1);

            Pin pin0 = new Pin();

            HalfAdder half = new HalfAdder();

            Cable.Join(pin1, half.IN1);
            Cable.Join(pin1, half.IN1);

            Cable.Join(pin1, half.IN2);
            Cable.Join(pin1, half.IN2);




        }
    }
}
