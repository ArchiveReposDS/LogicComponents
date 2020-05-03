using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Cable
    {
        public static void Join(Pin from, Pin to)
        {
            CounterClass.CounterCable++;

            if (from.State != to.State)
            {
                CounterClass.CounterAction++;
                to.State = from.State;
            }
        }
    }
}
