namespace Programming.Model
{
    internal class Discipline
    {
        public Discipline()
        {
        }

        public Discipline(string name, string faculty, int hours)
        {
            Name = name;
            Faculty = faculty;
            Hours = hours;
        }

        public string Name { get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;
        public int Hours { get; set; }
    }
}