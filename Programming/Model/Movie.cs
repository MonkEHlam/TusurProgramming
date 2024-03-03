﻿using System;

namespace Programming.Model
{
    internal class Movie
    {
        public string Name { get; set; } = "";
        private int _durationInMinutes = 0;
        public int DurationInMinutes { get { return _durationInMinutes; } set { _durationInMinutes = value > 0 ? value : throw new ArgumentException(); } }
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
        private double _rate = 0;
        public double Rate { get { return _rate; } set { _rate = value >= 0 ? value : throw new ArgumentException(); } }
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
