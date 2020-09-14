using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public delegate void AlarmHandler(object sender, AlarmEventArgs args);

    public class AlarmEventArgs
    {
        public long CurrentTime;//现在的时间
        public AlarmEventArgs(Alarm alarm)
        {
            CurrentTime = alarm.CurrentTime;
        }
    }

    public class Alarm
    {
        public long CurrentTime;//现在的时间
        private long ClockTime;//表示多久后响铃
        private long BeginTime;//开始时间

        public event AlarmHandler TickEvent;
        public event AlarmHandler AlarmEvent;

        public Alarm()
        {
            CurrentTime = 0;
            ClockTime = -1;
            BeginTime = 0;
        }

        public void SetClock(long second)
        {
            BeginTime = CurrentTime;
            ClockTime = second;
        }

        public void Start()
        {
            Console.Write("Start\n");
            Console.Write("Please enter the time to alarm:");
            string input = Console.ReadLine();
            long ClockNum;
            try
            {
                ClockNum = Int64.Parse(input);
                if (ClockNum > 0)
                    ClockTime = ClockNum;
                else ClockTime = 5;
            }
            catch (Exception e) { Console.Write(e); }

            while (true)
            {
                System.Threading.Thread.Sleep(1000);//休眠一秒
                CurrentTime++;

                TickEvent(this, new AlarmEventArgs(this));

                if ((CurrentTime - BeginTime) % ClockTime == 0)
                    AlarmEvent(this, new AlarmEventArgs(this));
            }

        }

    }
}
