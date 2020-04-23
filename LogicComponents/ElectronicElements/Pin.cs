using System;
using System.Collections.Generic;
using System.Text;
using static LogicComponents.DelegateDS;
using static LogicComponents.LogicGate;

namespace LogicComponents
{
    public class Pin
    {
        public ActionDel ActionEvent { get; set; }

        private byte state;
        public byte State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                if (ActionEvent != null)
                    ActionEvent.Invoke();
            }
        }

        public Pin(){}
        public Pin(ActionDel actionEvent)
        {
            ActionEvent = actionEvent;
        }

        public void Set(byte impuls)
        {
            if (impuls != state)
            {
                state = impuls;
            }
        }

    }
}
