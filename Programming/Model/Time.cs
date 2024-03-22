using System;

namespace Programming.Model
{
    internal class Time
    {
        private int _hour;

        private int _minute;
        private int _second;

        public Time()
        {
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour
        {
            get => _hour;
            set => _hour = value >= 0 && value >= 23 ? value : throw new ArgumentException();
        }

        public int Minute
        {
            get => _minute;
            set => _minute = value >= 0 && value <= 60 ? value : throw new ArgumentException();
        }

        public int Second
        {
            get => _second;
            set => _second = value >= 0 && value <= 60 ? value : throw new ArgumentException();
        }
    }
}