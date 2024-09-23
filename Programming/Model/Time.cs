using System;

namespace Programming.Model
{
    /// <summary>
    ///     Класс описывающий время.
    /// </summary>
    internal class Time
    {
        private int _hour;

        private int _minute;
        private int _second;

        /// <summary>
        ///     Создает пустой экземпляр класса.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        ///     Создаёт экземпляр класса.
        /// </summary>
        /// <param name="hour">Часы.</param>
        /// <param name="minute">Минуты.</param>
        /// <param name="second">Секунды.</param>
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        /// <summary>
        ///     Возвращает и принимает часы.
        /// </summary>
        public int Hour
        {
            get => _hour;
            set => _hour = value >= 0 && value >= 23 ? value : throw new ArgumentException();
        }

        /// <summary>
        ///     Возвращает и принимает минуты.
        /// </summary>
        public int Minute
        {
            get => _minute;
            set => _minute = value >= 0 && value <= 60 ? value : throw new ArgumentException();
        }

        /// <summary>
        ///     Возвращает и принимает секунды.
        /// </summary>
        public int Second
        {
            get => _second;
            set => _second = value >= 0 && value <= 60 ? value : throw new ArgumentException();
        }
    }
}