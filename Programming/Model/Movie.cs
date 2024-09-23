using System;

namespace Programming.Model
{
    /// <summary>
    ///     Хранит информацию о фильме.
    /// </summary>
    internal class Movie
    {
        private int _durationInMinutes;
        private double _rate;
        private int _year;

        /// <summary>
        ///     Создает пустой экзепляр класса
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        ///     Создает экзепляр класса
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="durationInMinutes">Продолжительность</param>
        /// <param name="year">Год выхода</param>
        /// <param name="genre">Жанр</param>
        /// <param name="rate">Рейтинг</param>
        public Movie(string name, int durationInMinutes, int year, string genre, double rate)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            Year = year;
            Genre = genre;
            Rate = rate;
        }

        /// <summary>
        ///     Принимает и возвращает название.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        ///     Принимает и возвращает продолжительность.
        /// </summary>
        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                if (Validator.AssertOnPositiveValue(value, GetType() + "." + nameof(DurationInMinutes)))
                    _durationInMinutes = value;
            }
        }

        /// <summary>
        ///     Принимает и возвращает год выхода.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                if (Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, GetType() + "." + nameof(Year)))
                    _year = value;
            }
        }

        /// <summary>
        ///     Принимает и возвращает жанр.
        /// </summary>
        public string Genre { get; set; } = "";

        /// <summary>
        ///     Принимает и возвращает рейтинг.
        /// </summary>
        public double Rate
        {
            get => _rate;
            set
            {
                if (Validator.AssertOnPositiveValue(value, GetType() + nameof(Rate))) _rate = value;
            }
        }
    }
}