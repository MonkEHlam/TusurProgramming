using System;

namespace Programming.Model
{
    internal class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        private int _durationInSeconds;

        public int DurationInSeconds
        {
            get { return _durationInSeconds; }
            set { if (Validator.AssertOnPositiveValue(value, this.GetType() + "." + nameof(DurationInSeconds))) _durationInSeconds = value; }
        }

        public Song(string name, string author, int durationInSeconds)
        {
            Name = name;
            Author = author;
            _durationInSeconds = durationInSeconds;
        }

        public Song() { }
    }
}
