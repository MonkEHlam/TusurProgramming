using System;

namespace Programming.Model
{
    internal class Movie
    {
        private int _durationInMinutes = 0;
        private double _rate;
        private int _year;

        public Movie()
        {
        }

        public Movie(string name, int durationInMinutes, int year, string genre, double rate)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            Year = year;
            Genre = genre;
            Rate = rate;
        }

        public string Name { get; set; } = "";

        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                if (Validator.AssertOnPositiveValue(value, GetType() + "." + nameof(DurationInMinutes))) _durationInMinutes = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, GetType() + "." + nameof(Year)))
                    _year = value;
            }
        }

        public string Genre { get; set; } = "";

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