namespace Programming.Model
{
    internal class Song
    {
        private int _durationInSeconds;

        public Song(string name, string author, int durationInSeconds)
        {
            Name = name;
            Author = author;
            _durationInSeconds = durationInSeconds;
        }

        public Song()
        {
        }

        public string Name { get; set; }
        public string Author { get; set; }

        public int DurationInSeconds
        {
            get => _durationInSeconds;
            set
            {
                if (Validator.AssertOnPositiveValue(value, GetType() + "." + nameof(DurationInSeconds)))
                    _durationInSeconds = value;
            }
        }
    }
}