using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Demultiplexer8 : DemultiplexerBase
    {
        public override void ConnectIN1()
        {
            Cable.Join(IN1, And1.Pin4);
            Cable.Join(IN1, And3.Pin4);
            Cable.Join(IN1, And5.Pin4);
            Cable.Join(IN1, And7.Pin4);
            Cable.Join(IN1, Not3.Pin1);
            GetOutput();
        }
        public override void ConnectIN2()
        {
            Cable.Join(IN2, And2.Pin3);
            Cable.Join(IN2, And3.Pin3);
            Cable.Join(IN2, And6.Pin3);
            Cable.Join(IN2, And7.Pin3);
            Cable.Join(IN2, Not2.Pin1);
            GetOutput();
        }
        public override void ConnectIN3()
        {
            Cable.Join(IN3, And4.Pin2);
            Cable.Join(IN3, And5.Pin2);
            Cable.Join(IN3, And6.Pin2);
            Cable.Join(IN3, And7.Pin2);
            Cable.Join(IN3, Not1.Pin1);
            GetOutput();
        }

        public override void ConnectPower()
        {
            Cable.Join(Power, And0.Pin1);
            Cable.Join(Power, And1.Pin1);
            Cable.Join(Power, And2.Pin1);
            Cable.Join(Power, And3.Pin1);
            Cable.Join(Power, And4.Pin1);
            Cable.Join(Power, And5.Pin1);
            Cable.Join(Power, And6.Pin1);
            Cable.Join(Power, And7.Pin1);
            GetOutput();
        }

        private void GetOutput()
        {
            Cable.Join(Not1.Output, And0.Pin2);
            Cable.Join(Not1.Output, And1.Pin2);
            Cable.Join(Not1.Output, And2.Pin2);
            Cable.Join(Not1.Output, And3.Pin2);

            Cable.Join(Not2.Output, And0.Pin3);
            Cable.Join(Not2.Output, And1.Pin3);
            Cable.Join(Not2.Output, And4.Pin3);
            Cable.Join(Not2.Output, And5.Pin3);

            Cable.Join(Not3.Output, And0.Pin4);
            Cable.Join(Not3.Output, And2.Pin4);
            Cable.Join(Not3.Output, And4.Pin4);
            Cable.Join(Not3.Output, And6.Pin4);

            Cable.Join(And0.Output, OUT0);
            Cable.Join(And1.Output, OUT1);
            Cable.Join(And2.Output, OUT2);
            Cable.Join(And3.Output, OUT3);
            Cable.Join(And4.Output, OUT4);
            Cable.Join(And5.Output, OUT5);
            Cable.Join(And6.Output, OUT6);
            Cable.Join(And7.Output, OUT7);

        }
    }
}
