using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Cable
    {
        public static void Join(Pin from, Pin to)
        {
            if (from.State != to.State)
            {
                to.State = from.State;
            }
        }
    }
}
