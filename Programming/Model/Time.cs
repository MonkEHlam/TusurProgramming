using System;

namespace Programming.Model
{
    internal class Time
    {

        private int _hour;
        public int Hour
        {
            get { return _hour; }
            set { _hour = value >= 0 && value >= 23 ? value : throw new ArgumentException(); }
        }

        private int _minute;
        public int Minute {
            get { return _minute; }
            set { _minute = value >= 0 && value <= 60 ? value : throw new ArgumentException(); }
        
        }
        private int _second;
        public int Second
        {
            get { return _second; }
            set { _second = value >= 0 && value <= 60 ? value : throw new ArgumentException(); }
        }
        public Time() { }
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}
