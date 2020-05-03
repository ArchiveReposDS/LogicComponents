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

            Pin pin0 = new Pin();
            pin0.Set(0);
            Pin pin1 = new Pin();
            pin1.Set(1);
            Pin pin2 = new Pin();
            pin2.Set(0);
            Pin pin3 = new Pin();
            pin3.Set(0);
            Pin pin4 = new Pin();
            pin4.Set(0);
            Pin pin5 = new Pin();
            pin5.Set(0);
            Pin pin6 = new Pin();
            pin6.Set(0);
            Pin pin7 = new Pin();
            pin7.Set(0);


            Pin pin0B = new Pin();
            pin0B.Set(1);
            Pin pin1B = new Pin();
            pin1B.Set(1);
            Pin pin2B = new Pin();
            pin2B.Set(1);
            Pin pin3B = new Pin();
            pin3B.Set(0);
            Pin pin4B = new Pin();
            pin4B.Set(0);
            Pin pin5B = new Pin();
            pin5B.Set(0);
            Pin pin6B = new Pin();
            pin6B.Set(0);
            Pin pin7B = new Pin();
            pin7B.Set(0);


            Ram r = new Ram();

            Cable.Join(new Pin() { State = 1 }, r.Power);
      
            Cable.Join(new Pin() { State = 0 }, r.INRow0);
            Cable.Join(new Pin() { State = 0 }, r.INColumn0);
            Cable.Join(new Pin() { State = 1 }, r.DataInput);
            Cable.Join(new Pin() { State = 1 }, r.WriteEnable);
            Cable.Join(new Pin() { State = 0 }, r.WriteEnable);
            Cable.Join(new Pin() { State = 0 }, r.DataInput);


            Cable.Join(new Pin() { State = 1 }, r.INRow0);
            Cable.Join(new Pin() { State = 1 }, r.INColumn0);
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




            Cable.Join(pin1, d.Power);
            Cable.Join(pin1, d.IN1);
            Cable.Join(pin1, d.IN2);
            Cable.Join(pin1, d.IN3);


            Adder8bits adder8bits = new Adder8bits();

            Cable.Join(pin0, adder8bits.IN0A);
            Cable.Join(pin1, adder8bits.IN1A);
            Cable.Join(pin2, adder8bits.IN2A);
            Cable.Join(pin3, adder8bits.IN3A);
            Cable.Join(pin4, adder8bits.IN4A);
            Cable.Join(pin5, adder8bits.IN5A);
            Cable.Join(pin6, adder8bits.IN6A);
            Cable.Join(pin7, adder8bits.IN7A);

            Cable.Join(pin0B, adder8bits.IN0B);
            Cable.Join(pin1B, adder8bits.IN1B);
            Cable.Join(pin2B, adder8bits.IN2B);
            Cable.Join(pin3B, adder8bits.IN3B);
            Cable.Join(pin4B, adder8bits.IN4B);
            Cable.Join(pin5B, adder8bits.IN5B);
            Cable.Join(pin6B, adder8bits.IN6B);
            Cable.Join(pin7B, adder8bits.IN7B);

            int k = 1;






        }
    }
}
