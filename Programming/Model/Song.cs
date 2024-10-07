namespace Programming.Model
{
    /// <summary>
    ///     Хранит данные о песне.
    /// </summary>
    internal class Song
    {
        private int _durationInSeconds;

        /// <summary>
        ///     Создает экземпляр класса.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="author">Автор.</param>
        /// <param name="durationInSeconds">Длительность.</param>
        public Song(string name, string author, int durationInSeconds)
        {
            Name = name;
            Author = author;
            _durationInSeconds = durationInSeconds;
        }

        /// <summary>
        ///     Создаёт пустой экземпляр класса.
        /// </summary>
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