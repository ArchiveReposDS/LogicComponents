using System;
using System.Collections.Generic;
using System.Text;

namespace LogicComponents
{
    public class Ram :RamBase
    {
        public override void ConnectPower()
        {
            Cable.Join(Power, Demultiplexer8Column.Power);
            Cable.Join(Power, Demultiplexer8Row.Power);
            GetOutput();
        }
        public override void ConnectDataInput()
        {
            Cable.Join(DataInput, RowColumnGatedLatch1.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch2.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch3.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch4.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch5.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch6.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch7.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch8.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch9.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch10.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch11.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch12.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch13.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch14.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch15.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch16.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch17.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch18.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch19.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch20.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch21.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch22.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch23.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch24.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch25.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch26.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch27.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch28.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch29.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch30.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch31.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch32.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch33.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch34.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch35.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch36.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch37.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch38.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch39.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch40.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch41.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch42.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch43.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch44.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch45.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch46.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch47.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch48.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch49.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch50.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch51.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch52.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch53.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch54.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch55.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch56.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch57.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch58.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch59.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch60.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch61.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch62.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch63.DataInput);
            Cable.Join(DataInput, RowColumnGatedLatch64.DataInput);
            GetOutput();
        }

        public override void ConnectWriteEnable()
        {
            Cable.Join(WriteEnable, RowColumnGatedLatch1.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch2.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch3.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch4.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch5.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch6.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch7.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch8.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch9.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch10.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch11.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch12.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch13.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch14.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch15.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch16.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch17.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch18.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch19.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch20.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch21.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch22.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch23.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch24.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch25.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch26.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch27.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch28.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch29.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch30.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch31.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch32.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch33.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch34.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch35.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch36.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch37.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch38.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch39.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch40.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch41.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch42.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch43.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch44.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch45.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch46.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch47.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch48.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch49.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch50.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch51.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch52.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch53.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch54.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch55.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch56.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch57.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch58.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch59.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch60.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch61.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch62.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch63.WriteEnable);
            Cable.Join(WriteEnable, RowColumnGatedLatch64.WriteEnable);

            GetOutput();
        }

        public override void ConnectReadEnable()
        {
            Cable.Join(ReadEnable, RowColumnGatedLatch1.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch2.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch3.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch4.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch5.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch6.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch7.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch8.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch9.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch10.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch11.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch12.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch13.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch14.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch15.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch16.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch17.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch18.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch19.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch20.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch21.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch22.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch23.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch24.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch25.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch26.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch27.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch28.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch29.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch30.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch31.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch32.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch33.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch34.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch35.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch36.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch37.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch38.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch39.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch40.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch41.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch42.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch43.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch44.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch45.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch46.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch47.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch48.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch49.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch50.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch51.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch52.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch53.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch54.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch55.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch56.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch57.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch58.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch59.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch60.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch61.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch62.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch63.ReadEnable);
            Cable.Join(ReadEnable, RowColumnGatedLatch64.ReadEnable);

            GetOutput();
        }


        public override void ConnectColumn0()
        {
            Cable.Join(INColumn0, Demultiplexer8Column.IN1);
            GetOutput();
        }
        public override void ConnectColumn2()
        {
            Cable.Join(INColumn2, Demultiplexer8Column.IN2);
            GetOutput();
        }
        public override void ConnectColumn4()
        {
            Cable.Join(INColumn4, Demultiplexer8Column.IN3);
            GetOutput();
        }

        public override void ConnectRow0()
        {
            Cable.Join(INRow0, Demultiplexer8Row.IN1);
            GetOutput();
        }
        public override void ConnectRow2()
        {
            Cable.Join(INRow2, Demultiplexer8Row.IN2);
            GetOutput();
        }
        public override void ConnectRow4()
        {
            Cable.Join(INRow4, Demultiplexer8Row.IN3);
            GetOutput();
        }

        private void GetOutput()
        {
          // ROWS
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch1.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch2.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch3.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch4.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch5.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch6.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch7.INRow);
            Cable.Join(Demultiplexer8Row.OUT0, RowColumnGatedLatch8.INRow);

            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch9.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch10.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch11.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch12.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch13.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch14.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch15.INRow);
            Cable.Join(Demultiplexer8Row.OUT1, RowColumnGatedLatch16.INRow);

            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch17.INRow);
            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch18.INRow);
            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch19.INRow);
            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch20.INRow);
            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch21.INRow);
            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch22.INRow);
            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch23.INRow);
            Cable.Join(Demultiplexer8Row.OUT2, RowColumnGatedLatch24.INRow);

            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch25.INRow);
            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch26.INRow);
            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch27.INRow);
            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch28.INRow);
            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch29.INRow);
            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch30.INRow);
            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch31.INRow);
            Cable.Join(Demultiplexer8Row.OUT3, RowColumnGatedLatch32.INRow);

            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch33.INRow);
            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch34.INRow);
            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch35.INRow);
            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch36.INRow);
            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch37.INRow);
            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch38.INRow);
            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch39.INRow);
            Cable.Join(Demultiplexer8Row.OUT4, RowColumnGatedLatch40.INRow);

            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch41.INRow);
            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch42.INRow);
            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch43.INRow);
            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch44.INRow);
            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch45.INRow);
            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch46.INRow);
            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch47.INRow);
            Cable.Join(Demultiplexer8Row.OUT5, RowColumnGatedLatch48.INRow);

            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch49.INRow);
            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch50.INRow);
            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch51.INRow);
            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch52.INRow);
            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch53.INRow);
            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch54.INRow);
            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch55.INRow);
            Cable.Join(Demultiplexer8Row.OUT6, RowColumnGatedLatch56.INRow);

            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch57.INRow);
            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch58.INRow);
            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch59.INRow);
            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch60.INRow);
            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch61.INRow);
            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch62.INRow);
            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch63.INRow);
            Cable.Join(Demultiplexer8Row.OUT7, RowColumnGatedLatch64.INRow);


            // COLUMNS
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch1.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch9.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch17.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch25.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch33.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch41.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch49.INColumn);
            Cable.Join(Demultiplexer8Column.OUT0, RowColumnGatedLatch57.INColumn);

            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch2.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch10.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch18.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch26.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch34.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch42.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch50.INColumn);
            Cable.Join(Demultiplexer8Column.OUT1, RowColumnGatedLatch58.INColumn);

            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch3.INColumn);
            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch11.INColumn);
            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch19.INColumn);
            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch27.INColumn);
            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch35.INColumn);
            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch43.INColumn);
            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch51.INColumn);
            Cable.Join(Demultiplexer8Column.OUT2, RowColumnGatedLatch59.INColumn);

            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch4.INColumn);
            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch12.INColumn);
            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch20.INColumn);
            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch28.INColumn);
            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch36.INColumn);
            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch44.INColumn);
            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch52.INColumn);
            Cable.Join(Demultiplexer8Column.OUT3, RowColumnGatedLatch60.INColumn);

            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch5.INColumn);
            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch13.INColumn);
            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch21.INColumn);
            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch29.INColumn);
            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch37.INColumn);
            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch45.INColumn);
            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch53.INColumn);
            Cable.Join(Demultiplexer8Column.OUT4, RowColumnGatedLatch61.INColumn);

            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch6.INColumn);
            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch14.INColumn);
            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch22.INColumn);
            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch30.INColumn);
            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch38.INColumn);
            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch46.INColumn);
            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch54.INColumn);
            Cable.Join(Demultiplexer8Column.OUT5, RowColumnGatedLatch62.INColumn);

            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch7.INColumn);
            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch15.INColumn);
            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch23.INColumn);
            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch31.INColumn);
            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch39.INColumn);
            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch47.INColumn);
            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch55.INColumn);
            Cable.Join(Demultiplexer8Column.OUT6, RowColumnGatedLatch63.INColumn);

            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch8.INColumn);
            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch16.INColumn);
            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch24.INColumn);
            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch32.INColumn);
            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch40.INColumn);
            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch48.INColumn);
            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch56.INColumn);
            Cable.Join(Demultiplexer8Column.OUT7, RowColumnGatedLatch64.INColumn);


            // JOIN TO OR GATE
            Cable.Join(RowColumnGatedLatch1.DataOutput, Or64Inputs.Pin1);
            Cable.Join(RowColumnGatedLatch2.DataOutput, Or64Inputs.Pin2);
            Cable.Join(RowColumnGatedLatch3.DataOutput, Or64Inputs.Pin3);
            Cable.Join(RowColumnGatedLatch4.DataOutput, Or64Inputs.Pin4);
            Cable.Join(RowColumnGatedLatch5.DataOutput, Or64Inputs.Pin5);
            Cable.Join(RowColumnGatedLatch6.DataOutput, Or64Inputs.Pin6);
            Cable.Join(RowColumnGatedLatch7.DataOutput, Or64Inputs.Pin7);
            Cable.Join(RowColumnGatedLatch8.DataOutput, Or64Inputs.Pin8);
            Cable.Join(RowColumnGatedLatch9.DataOutput, Or64Inputs.Pin9);
            Cable.Join(RowColumnGatedLatch10.DataOutput, Or64Inputs.Pin10);
            Cable.Join(RowColumnGatedLatch11.DataOutput, Or64Inputs.Pin11);
            Cable.Join(RowColumnGatedLatch12.DataOutput, Or64Inputs.Pin12);
            Cable.Join(RowColumnGatedLatch13.DataOutput, Or64Inputs.Pin13);
            Cable.Join(RowColumnGatedLatch14.DataOutput, Or64Inputs.Pin14);
            Cable.Join(RowColumnGatedLatch15.DataOutput, Or64Inputs.Pin15);
            Cable.Join(RowColumnGatedLatch16.DataOutput, Or64Inputs.Pin16);
            Cable.Join(RowColumnGatedLatch17.DataOutput, Or64Inputs.Pin17);
            Cable.Join(RowColumnGatedLatch18.DataOutput, Or64Inputs.Pin18);
            Cable.Join(RowColumnGatedLatch19.DataOutput, Or64Inputs.Pin19);
            Cable.Join(RowColumnGatedLatch20.DataOutput, Or64Inputs.Pin20);
            Cable.Join(RowColumnGatedLatch21.DataOutput, Or64Inputs.Pin21);
            Cable.Join(RowColumnGatedLatch22.DataOutput, Or64Inputs.Pin22);
            Cable.Join(RowColumnGatedLatch23.DataOutput, Or64Inputs.Pin23);
            Cable.Join(RowColumnGatedLatch24.DataOutput, Or64Inputs.Pin24);
            Cable.Join(RowColumnGatedLatch25.DataOutput, Or64Inputs.Pin25);
            Cable.Join(RowColumnGatedLatch26.DataOutput, Or64Inputs.Pin26);
            Cable.Join(RowColumnGatedLatch27.DataOutput, Or64Inputs.Pin27);
            Cable.Join(RowColumnGatedLatch28.DataOutput, Or64Inputs.Pin28);
            Cable.Join(RowColumnGatedLatch29.DataOutput, Or64Inputs.Pin29);
            Cable.Join(RowColumnGatedLatch30.DataOutput, Or64Inputs.Pin30);
            Cable.Join(RowColumnGatedLatch31.DataOutput, Or64Inputs.Pin31);
            Cable.Join(RowColumnGatedLatch32.DataOutput, Or64Inputs.Pin32);
            Cable.Join(RowColumnGatedLatch33.DataOutput, Or64Inputs.Pin33);
            Cable.Join(RowColumnGatedLatch34.DataOutput, Or64Inputs.Pin34);
            Cable.Join(RowColumnGatedLatch35.DataOutput, Or64Inputs.Pin35);
            Cable.Join(RowColumnGatedLatch36.DataOutput, Or64Inputs.Pin36);
            Cable.Join(RowColumnGatedLatch37.DataOutput, Or64Inputs.Pin37);
            Cable.Join(RowColumnGatedLatch38.DataOutput, Or64Inputs.Pin38);
            Cable.Join(RowColumnGatedLatch39.DataOutput, Or64Inputs.Pin39);
            Cable.Join(RowColumnGatedLatch40.DataOutput, Or64Inputs.Pin40);
            Cable.Join(RowColumnGatedLatch41.DataOutput, Or64Inputs.Pin41);
            Cable.Join(RowColumnGatedLatch42.DataOutput, Or64Inputs.Pin42);
            Cable.Join(RowColumnGatedLatch43.DataOutput, Or64Inputs.Pin43);
            Cable.Join(RowColumnGatedLatch44.DataOutput, Or64Inputs.Pin44);
            Cable.Join(RowColumnGatedLatch45.DataOutput, Or64Inputs.Pin45);
            Cable.Join(RowColumnGatedLatch46.DataOutput, Or64Inputs.Pin46);
            Cable.Join(RowColumnGatedLatch47.DataOutput, Or64Inputs.Pin47);
            Cable.Join(RowColumnGatedLatch48.DataOutput, Or64Inputs.Pin48);
            Cable.Join(RowColumnGatedLatch49.DataOutput, Or64Inputs.Pin49);
            Cable.Join(RowColumnGatedLatch50.DataOutput, Or64Inputs.Pin50);
            Cable.Join(RowColumnGatedLatch51.DataOutput, Or64Inputs.Pin51);
            Cable.Join(RowColumnGatedLatch52.DataOutput, Or64Inputs.Pin52);
            Cable.Join(RowColumnGatedLatch53.DataOutput, Or64Inputs.Pin53);
            Cable.Join(RowColumnGatedLatch54.DataOutput, Or64Inputs.Pin54);
            Cable.Join(RowColumnGatedLatch55.DataOutput, Or64Inputs.Pin55);
            Cable.Join(RowColumnGatedLatch56.DataOutput, Or64Inputs.Pin56);
            Cable.Join(RowColumnGatedLatch57.DataOutput, Or64Inputs.Pin57);
            Cable.Join(RowColumnGatedLatch58.DataOutput, Or64Inputs.Pin58);
            Cable.Join(RowColumnGatedLatch59.DataOutput, Or64Inputs.Pin59);
            Cable.Join(RowColumnGatedLatch60.DataOutput, Or64Inputs.Pin60);
            Cable.Join(RowColumnGatedLatch61.DataOutput, Or64Inputs.Pin61);
            Cable.Join(RowColumnGatedLatch62.DataOutput, Or64Inputs.Pin62);
            Cable.Join(RowColumnGatedLatch63.DataOutput, Or64Inputs.Pin63);
            Cable.Join(RowColumnGatedLatch64.DataOutput, Or64Inputs.Pin64);


            Cable.Join(Or64Inputs.Output, DataOutput);
        }

    }
}
