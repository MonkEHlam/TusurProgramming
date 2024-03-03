using System;

namespace Programming.Model
{
    internal class Movie
    {
        public string Name { get; set; } = "";
        public int DurationInMinutes { get; set; } = 0;
        private int _year = 0;
        public int Year
        {
            get {  return _year; }
            set
            {
                _year = value > 1900 ? value : throw new ArgumentException();
            }
        }
        public string Genre { get; set; } = "";
        public double Rate { get; set; } = 0;
        public Movie() { }

        public Movie(string name, int durationInMinutes, int year, string genre, double rate) 
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            Year = year;
            Genre = genre;
            Rate = rate;
        }
    }
}
