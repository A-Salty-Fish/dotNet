using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class Form
    {
        public Homework3.Alarm alarm = new Homework3.Alarm();
        void Clock_Tick(object sender, AlarmEventArgs args)
        {
            Console.Write("Now:" + args.CurrentTime + '\n');
        }
        void Clock_Alarm(object sender, AlarmEventArgs args)
        {
            Console.Write("Alarm:" + args.CurrentTime + '\n');
        }

        public Form()
        {
            alarm.TickEvent += Clock_Tick;

            alarm.AlarmEvent += Clock_Alarm;

        }
    }
}
